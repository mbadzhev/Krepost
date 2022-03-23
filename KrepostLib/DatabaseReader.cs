using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;

using KrepostLib.Storage;

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

        public static DatabaseFile DeserializeDatabase(string path)
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
