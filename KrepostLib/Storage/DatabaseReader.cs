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
            if (!dbFile.ValidateHead())
                throw new InvalidOperationException("DatabaseFile head is compromised");
            if (!dbFile.ValidateBody())
                throw new InvalidOperationException("DatabaseFile body is compromised");

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
