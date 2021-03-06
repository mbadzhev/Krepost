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
            //dbBody.HeadSalt = Generator.GenerateBytes(16);
            dbBody.EntryList = new List<DatabaseEntry>();

            dbHead.IntegrityHash = ComputeDatabaseHeadHash(dbHead, dbHead.BodyIv);

            Database db = new Database(dbHead, dbBody);
            return db;
        }
        public static void SerializeDatabase(Database db, SecureByteArray key, string path)
        {
            // TODO: Validate arguments

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
