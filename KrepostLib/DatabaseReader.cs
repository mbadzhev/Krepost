using System.Xml;
using System.Xml.Serialization;

namespace KrepostLib
{
    public static class DatabaseReader
    {
        public static Database ReadDatabase(string path)
        {
            // Create a new file stream for reading the XML file
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            Database obj;

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.Async = true;

            using (XmlReader xmlReader = XmlReader.Create(fs, settings))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(Database));
                obj = deserializer.Deserialize(xmlReader) as Database;
            }

            // Cleanup
            fs.Close();

            return obj;
        }

        public static bool ValidateDatabaseHeader(Database db)
        {
            // TODO: Allow for different values in header fields

            // Concatenate all fields of database header
            string headerString = db.Head.hashId + db.Head.accessHash + db.Head.cipherId + db.Head.databaseIv;
            // Hash concatenated string and compare result with stored hash
            if (db.Head.integrityHash != Cryptography.Sha256Engine.ComputeSha256Hash(headerString))
            {
                return false;
            }
            return true;
        }
    }
}
