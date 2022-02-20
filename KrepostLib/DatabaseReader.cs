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
    }
}
