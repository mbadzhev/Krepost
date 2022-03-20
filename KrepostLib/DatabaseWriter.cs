using System.Xml;
using System.Xml.Serialization;

using KrepostLib.Cryptography;
using KrepostLib.Security;
using KrepostLib.Storage;

namespace KrepostLib
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

            HashDatabaseHead(dbHead, dbBody.HeadSalt);

            Database db = new Database(dbHead, dbBody);
            return db;
        }

        public static void WriteDatabase(object obj, string path)
        {
            // TODO: Chech for errors in the process

            // Use new line and indentadion in xml output.
            XmlWriterSettings xmlWriterSettings = new()
            {
                Indent = true
            };
            XmlSerializer serializer = new(typeof(Database));
            using XmlWriter xmlWriter = XmlWriter.Create(path, xmlWriterSettings);
            serializer.Serialize(xmlWriter, obj);
            xmlWriter.Close();
        }
        public static void HashDatabaseHead(DatabaseHead dbH, byte[] salt)
        {
            string headFields = dbH.HashFunction + dbH.AccessHash + dbH.CipherAlgorithm + dbH.BodyIv;
            dbH.IntegrityHash = Sha256Engine.ComputeSha256Hash(headFields, salt);
        }
    }
}
