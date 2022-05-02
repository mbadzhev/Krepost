using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;

using KrepostLib.Cryptography;
using KrepostLib.Security;

namespace KrepostLib.Storage
{
    public static class DatabaseWriter
    {
        /// <summary>
        /// Creates a new <see cref="Database"/> object.
        /// </summary>
        /// <param name="masterHash">The hash of the master password used to access the new <see cref="Database"/>.</param>
        /// <param name="iv">The initialization vector used during encryption of the <see cref="DatabaseBody"/>.</param>
        /// <returns>The object reference to the <see cref="Database"/> object.</returns>
        public static Database CreateDatabase(string masterHash, byte[] iv)
        {
            DatabaseHead dbHead = new DatabaseHead();
            dbHead.HashFunction = HashId.SHA256;
            dbHead.CipherAlgorithm = CipherId.AES256;
            dbHead.AccessHash = masterHash;
            dbHead.BodyIv = iv;

            DatabaseBody dbBody = new DatabaseBody();
            //dbBody.HeadSalt = Generator.GenerateBytes(16);
            dbBody.EntryList = new List<DatabaseEntry>();

            dbHead.IntegrityHash = ComputeDatabaseHeadHash(dbHead, dbHead.BodyIv);

            Database db = new Database(dbHead, dbBody);
            return db;
        }
        /// <summary>
        /// Serializes a <see cref="Database"/> to a <see cref="DatabaseFile"/>.
        /// </summary>
        /// <param name="db">The <see cref="Database"/> to be serealized.</param>
        /// <param name="key">The cryptograpic key used to encrypt the <see cref="DatabaseBody"/>.</param>
        /// <param name="path">The path where the <see cref="Database"/> will be serialized to.</param>
        public static void SerializeDatabase(Database db, SecureByteArray key, string path)
        {
            DatabaseFile dbF = new DatabaseFile();
            dbF.Salt = Generator.GenerateBytes(32);
            dbF.Head = ObjectToByteArray(db.Head);
            dbF.HeadHash = HmacEngine.ComputeHmac(dbF.Head, key, dbF.Salt);
            dbF.Body = AesEngine.Encrypt(ObjectToByteArray(db.Body), key, db.Head.BodyIv);
            dbF.BodyHash = HmacEngine.ComputeHmac(dbF.Body, key, dbF.Salt);

            // Use new line and indentadion in xml output.
            XmlWriterSettings xmlWriterSettings = new()
            {
                Indent = true
            };
            XmlSerializer serializer = new(typeof(DatabaseFile));
            using XmlWriter xmlWriter = XmlWriter.Create(path, xmlWriterSettings);
            serializer.Serialize(xmlWriter, dbF);
            xmlWriter.Close();
        }
        /// <summary>
        /// Serializes a object to a byte array.
        /// </summary>
        /// <param name="obj">The object to be serialized.</param>
        /// <returns>The byte arrays of the serialized object.</returns>
        public static byte[] ObjectToByteArray(object obj)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                formatter.Serialize(ms, obj);
                return ms.ToArray();
            }
        }
        /// <summary>
        /// Computes the HMAC of a <see cref="DatabaseHead"/> for integrity validation.
        /// </summary>
        /// <param name="dbH">The <see cref="DatabaseHead"/> to be validated.</param>
        /// <param name="salt">The salt used to compute the HMAC.</param>
        /// <returns>The computed HMAC of the <see cref="DatabaseHead"/>.</returns>
        public static string ComputeDatabaseHeadHash(DatabaseHead dbH, byte[] salt)
        {
            string headFields = dbH.HashFunction + dbH.AccessHash + dbH.CipherAlgorithm + dbH.BodyIv;
            string headHash = Sha256Engine.ComputeSha256Hash(headFields, salt);
            return headHash;
        }
        /// <summary>
        /// Copies the contents of one <see cref="Database"/> to another.
        /// </summary>
        /// <param name="dbOld">The <see cref="Database"/> to be copied from.</param>
        /// <param name="dbNew">The <see cref="Database"/> to be copied to.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void CopyDatabaseContent(Database dbOld, Database dbNew)
        {
            if (dbOld is null)
                throw new ArgumentNullException(nameof(dbOld));
            if (dbNew is null)
                throw new ArgumentNullException(nameof(dbNew));
            
            dbNew.Head.HashFunction = dbOld.Head.HashFunction;
            dbNew.Head.CipherAlgorithm = dbOld.Head.CipherAlgorithm;
            dbNew.Head.BodyIv = dbOld.Head.BodyIv;
            dbNew.Body.EntryList = dbOld.Body.EntryList;
        }
    }
}
