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
        public static object CreateDatabase()
        {
            // TODO: Complete implementation
            Database db = new Database();
            DatabaseHead dbHead = new DatabaseHead();
            dbHead.hashId = "SHA256";
            dbHead.accessHash = "passwordhash";
            dbHead.cipherId = "AES256";
            dbHead.databaseIv = "myIv";
            dbHead.integrityHash = "jhfguuhtrkjk";
            db.Items = dbHead;
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
    }
}
