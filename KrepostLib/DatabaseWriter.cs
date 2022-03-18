using System.Xml;
using System.Xml.Serialization;

using KrepostLib.Storage;

namespace KrepostLib
{
    public static class DatabaseWriter
    {
        public static Database CreateDatabase(string masterHash, byte[] iv)
        {
            // TODO: Complete implementation
            DatabaseHead dbHead = new DatabaseHead();
            DatabaseBody dbBody = new DatabaseBody();
            Database db = new Database(dbHead, dbBody);
            dbHead.HashFunction = HashId.SHA256;
            dbHead.AccessHash = masterHash;
            dbHead.CipherAlgorithm = CipherId.AES256;
            // Generate 128 bit (16 bytes) IV used by both KDF and AES
            dbHead.BodyIv = iv;
            db.Head = dbHead;
            HashDatabaseHeader(db);

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
        public static void HashDatabaseHeader(Database db)
        {
            string headerFields = db.Head.HashFunction + db.Head.AccessHash + db.Head.CipherAlgorithm + db.Head.BodyIv;
            db.Head.IntegrityHash = Cryptography.Sha256Engine.ComputeSha256Hash(headerFields);
        }
    }
}
