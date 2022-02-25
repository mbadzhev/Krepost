using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace KrepostLib
{
    public static class DatabaseWriter
    {
        public static Database CreateDatabase(string masterPassword)
        {
            // TODO: Complete implementation
            Database db = new Database();
            DatabaseHead dbHead = new DatabaseHead();
            dbHead.hashId = "SHA256";
            dbHead.accessHash = Cryptography.Sha256Engine.ComputeSha256Hash(masterPassword);
            dbHead.cipherId = "AES256";
            dbHead.databaseIv = "myIv";
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
            string headerFields = db.Head.hashId + db.Head.accessHash + db.Head.cipherId + db.Head.databaseIv;
            db.Head.integrityHash = Cryptography.Sha256Engine.ComputeSha256Hash(headerFields);
        }
    }
}
