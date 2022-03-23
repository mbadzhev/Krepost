using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;

using KrepostLib.Cryptography;
using KrepostLib.Security;

namespace KrepostLib.Storage
{
    public static class DatabaseWriter
    {
        public static Database CreateDatabase(string masterHash, byte[] iv)
        {
            // TODO: Complete implementation
            DatabaseHead dbHead = new DatabaseHead();
            dbHead.HashFunction = HashId.SHA256;
            dbHead.CipherAlgorithm = CipherId.AES256;
            dbHead.AccessHash = masterHash;
            dbHead.BodyIv = iv;

            DatabaseBody dbBody = new DatabaseBody();
            dbBody.HeadSalt = Generator.GenerateBytes(16);
            dbBody.EntryList = new List<DatabaseEntry>();

            dbHead.IntegrityHash = ComputeDatabaseHeadHash(dbHead, dbBody.HeadSalt);

            Database db = new Database(dbHead, dbBody);
            return db;
        }
        public static void SerializeDatabase(Database db, SecureByteArray key, string path)
        {
            // TODO: Validate arguments

            DatabaseFile dbF = new DatabaseFile();
            dbF.Salt = Generator.GenerateBytes(16);
            dbF.Head = ObjectToByteArray(db.Head);
            dbF.HeadHash = Sha256Engine.ComputeSha256Hash(dbF.Head, dbF.Salt);
            dbF.Body = AesEngine.Encrypt(ObjectToByteArray(db.Body), key, db.Head.BodyIv);
            dbF.BodyHash = Sha256Engine.ComputeSha256Hash(dbF.Body, dbF.Salt);


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
        public static byte[] ObjectToByteArray(object obj)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                formatter.Serialize(ms, obj);
                return ms.ToArray();
            }
        }
        public static string ComputeDatabaseHeadHash(DatabaseHead dbH, byte[] salt)
        {
            string headFields = dbH.HashFunction + dbH.AccessHash + dbH.CipherAlgorithm + dbH.BodyIv;
            string headHash = Sha256Engine.ComputeSha256Hash(headFields, salt);
            return headHash;
        }
    }
}
