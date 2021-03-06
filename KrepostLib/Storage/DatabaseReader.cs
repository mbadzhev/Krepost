using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;

using KrepostLib.Cryptography;
using KrepostLib.Security;

namespace KrepostLib.Storage
{
    public static class DatabaseReader
    {
        public static Database OpenDatabase(string path, SecureByteArray key)
        {
            // Deserialize and validate database file
            DatabaseFile dbFile = DeserializeDatabaseFile(path);
            //if (!dbFile.ValidateHead(key))
            //    throw new InvalidOperationException("DatabaseFile head is compromised");
            //if (!dbFile.ValidateBody(key))
            //    throw new InvalidOperationException("DatabaseFile body is compromised");

            // Deserialize and validate database head 
            DatabaseHead dbHead = (DatabaseHead)ByteArrayToObject(dbFile.Head);
            if (dbHead.IntegrityHash != DatabaseWriter.ComputeDatabaseHeadHash(dbHead, dbHead.BodyIv))
            {
                throw new InvalidOperationException("Database head is compromised");
            }

            // Deserialize and decrypt database body
            byte[] tempDbBody = AesEngine.Decrypt(dbFile.Body, key, dbHead.BodyIv);
            DatabaseBody dbBody = (DatabaseBody)ByteArrayToObject(tempDbBody);

            // Construct database
            Database db = new Database(dbHead, dbBody);

            return db;
        }

        public static DatabaseFile DeserializeDatabaseFile(string path)
        {
            // Create a new file stream to read the stored DatabaseFile.
            Stream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            DatabaseFile dbF;

            using (XmlReader reader = XmlReader.Create(fs))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(DatabaseFile));
                if (deserializer.CanDeserialize(reader))
                {
                    dbF = deserializer.Deserialize(reader) as DatabaseFile;
                }
                else
                {
                    return null;
                }
            }
            fs.Close();

            return dbF;
        }

        public static DatabaseHead DeserializeDatabaseHead(DatabaseFile dbF)
        {
            // Deserialize and validate database head 
            DatabaseHead dbHead = (DatabaseHead)ByteArrayToObject(dbF.Head);
            if (dbHead.IntegrityHash != DatabaseWriter.ComputeDatabaseHeadHash(dbHead, dbHead.BodyIv))
            {
                throw new InvalidOperationException("Database head is compromised");
            }

            return dbHead;
        }
        public static DatabaseBody DeserializeDatabaseBody(DatabaseFile dbF, DatabaseHead dbH, SecureByteArray key)
        {
            // Deserialize and decrypt database body
            byte[] tempDbBody = AesEngine.Decrypt(dbF.Body, key, dbH.BodyIv);
            DatabaseBody dbBody = (DatabaseBody)ByteArrayToObject(tempDbBody);
            Array.Clear(tempDbBody, 0, tempDbBody.Length);

            return dbBody;
        }
        /// <summary>
        /// Authenticates the <see cref="DatabaseFile"/> signitures to check the file integrity.
        /// </summary>
        /// <param name="dbF"><see cref="DatabaseFile"/> to validate.</param>
        /// <param name="key">Secret used to generate the authentication key. </param>
        /// <returns>True, if the file was authenticated. False, if at least one of the signitures was invalid.</returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static bool AuthenticateDatabaseFile(DatabaseFile dbF, SecureByteArray key)
        {
            int check = 0;
            if (dbF.Head is null)
                throw new InvalidOperationException("Database file head is null");
            if (dbF.Head.Length <= 0)
                throw new InvalidOperationException("Head cannot be <= 0");
            if (dbF.HeadHash == HmacEngine.ComputeHmac(dbF.Head, key, dbF.Salt))
                check += 1;
            if (dbF.Body is null)
                throw new InvalidOperationException("Body is null");
            if (dbF.Body.Length <= 0)
                throw new InvalidOperationException("Body cannot be <= 0");
            if (dbF.BodyHash == HmacEngine.ComputeHmac(dbF.Body, key, dbF.Salt))
                check += 1;
            if (check == 2)
                return true;
            return false;
        }
        public static bool ValidateDatabaseHead(Database db)
        {
            // TODO: Allow for different values in header fields

            // Concatenate all fields of database header
            string headerString = db.Head.HashFunction + db.Head.AccessHash + db.Head.CipherAlgorithm + db.Head.BodyIv;
            // Hash concatenated string and compare result with stored hash
            if (db.Head.IntegrityHash != Cryptography.Sha256Engine.ComputeSha256Hash(headerString))
            {
                return false;
            }
            return true;
        }
        public static bool ValidateDatabaseHead(DatabaseHead dbH)
        {
            // Concatenate all fields of database header
            string headerString = dbH.HashFunction + dbH.AccessHash + dbH.CipherAlgorithm + dbH.BodyIv;
            // Hash concatenated string and compare result with stored hash
            if (dbH.IntegrityHash != Sha256Engine.ComputeSha256Hash(headerString, dbH.BodyIv))
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Deserializes a byte array to an object.
        /// </summary>
        /// <param name="byteArray">Byte array of a serialized object.</param>
        /// <returns></returns>
        public static object ByteArrayToObject(byte[] byteArray)
        {
            MemoryStream ms = new MemoryStream(byteArray);
            ms.Position = 0;

            BinaryFormatter bf = new BinaryFormatter();

            return bf.Deserialize(ms);
        }
    }
}
