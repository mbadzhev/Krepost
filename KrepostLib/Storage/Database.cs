using System.Runtime.Serialization;
using System.Text;

using KrepostLib.Cryptography;
using KrepostLib.Security;

namespace KrepostLib.Storage
{
    public class Database
    {
        /// <summary>
        /// Gets or sets the head object of the database.
        /// </summary>
        public DatabaseHead Head { get; set; }
        /// <summary>
        /// Gets or sets the body object of the database.
        /// </summary>
        public DatabaseBody Body { get; set; }

        public Database(DatabaseHead head, DatabaseBody body)
        {
            Head = head;
            Body = body;
        }
    }

    [Serializable]
    public partial class DatabaseHead : ISerializable
    {
        /// <summary>
        /// Gets or sets the hash function used to compute the integrity hash of the head.
        /// </summary>
        public HashId HashFunction { get; set; }
        /// <summary>
        /// Gets or sets the algorithm used to encrypt the database body.
        /// </summary>
        public CipherId CipherAlgorithm { get; set; }
        /// <summary>
        /// Gets or sets the hash used to allow access to the database.
        /// </summary>
        public string AccessHash { get; set; }
        /// <summary>
        /// Gets or sets the hash used for validating the integrity of the database head.
        /// </summary>
        public string IntegrityHash { get; set; }
        /// <summary>
        /// Gets or sets the initialization vector used to encrypt the database body.
        /// </summary>
        public byte[] BodyIv { get; set; }

        public DatabaseHead()
        {
            // Empty constructor needed for serialization
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("HashFunction", HashFunction);
            info.AddValue("CipherAlgorithm", CipherAlgorithm);
            info.AddValue("AccessHash", AccessHash);
            info.AddValue("IntegrityHash", IntegrityHash);
            info.AddValue("BodyIv", BodyIv);
        }
        public DatabaseHead(SerializationInfo info, StreamingContext context)
        {
            HashFunction = (HashId)info.GetValue("HashFunction", typeof(HashId));
            CipherAlgorithm = (CipherId)info.GetValue("CipherAlgorithm", typeof(CipherId));
            AccessHash = (string)info.GetValue("AccessHash", typeof(string));
            IntegrityHash = (string)info.GetValue("IntegrityHash", typeof(string));
            BodyIv = (byte[])info.GetValue("BodyIv", typeof(byte[]));
        }
    }

    [Serializable]
    public partial class DatabaseBody : ISerializable
    {
        /// <summary>
        /// Gets or sets the list of all entries, stored in the database.
        /// </summary>
        /// <returns>The entries in a list.</returns>
        public List<DatabaseEntry> EntryList { get; set; }

        public DatabaseBody()
        {
            // Empty constructor needed for serialization
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("EntryList", EntryList);
        }
        public DatabaseBody(SerializationInfo info, StreamingContext context)
        {
            EntryList = (List<DatabaseEntry>)info.GetValue("EntryList", typeof(List<DatabaseEntry>));
        }
    }

    [Serializable]
    public sealed class DatabaseEntry : ISerializable
    {
        private static byte[] DefaultUsername = Encoding.UTF8.GetBytes("myUsername");
        private static readonly SecureByteArray DefaultUsernameBytes = new SecureByteArray(ref DefaultUsername);
        private static byte[] DefaultEmail = Encoding.UTF8.GetBytes("email@service.com");
        private static readonly SecureByteArray DefaultEmailBytes = new SecureByteArray(ref DefaultEmail);
        private static byte[] DefaultNote = Encoding.UTF8.GetBytes("mySecretNote");
        private static readonly SecureByteArray DefaultNoteBytes = new SecureByteArray(ref DefaultNote);
        private static readonly string DefaultUrl = "https://";
        const string DefaultDateModified = "000000000000000000";

        /// <summary>
        /// Gets or sets the entry title.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Gets or sets the encrypted entry username.
        /// </summary>
        public SecureByteArray Username { get; set; }
        /// <summary>
        /// Gets or sets the encrypted entry email.
        /// </summary>
        public SecureByteArray Email { get; set; }
        /// <summary>
        /// Gets or sets the encrypted entry password.
        /// </summary>
        public SecureByteArray Password { get; set; }
        /// <summary>
        /// Gets or sets the entry url.
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Gets or sets the encrypted entry notes.
        /// </summary>
        public SecureByteArray Note { get; set; }
        /// <summary>
        /// Gets or sets the entry creation date.
        /// </summary>
        public string DateCreated { get; set; }
        /// <summary>
        /// Gets or sets the last entry modification date.
        /// </summary>
        public string DateModified { get; set; }
        public string Uid { get; set; }
        /// <summary>
        /// Gets or sets the entry iv used for encrypting other entry components.
        /// </summary>
        public byte[] Iv { get; set; }
        /// <summary>
        /// Gets or sets the hash used for validating the integrity of the entry.
        /// </summary>
        public string IntegrityHash { get; set; }

        public DatabaseEntry()
        {
            // Empty constructor needed for serialization
        }
        public DatabaseEntry(string title, SecureByteArray username,
            SecureByteArray email, SecureByteArray password,
            string url, SecureByteArray note, string uid, byte[] iv, string doM = DefaultDateModified)
        {
            Title = title;
            Username = username;
            Email = email;
            Password = password;
            Url = url;
            Note = note;
            DateCreated = Utility.GetTimestamp();
            DateModified = doM;
            Uid = uid;
            Iv = iv;
            ComputeIntegrityHash();
        }

        private void ComputeIntegrityHash()
        {
            string entryFields = Title + Encoding.UTF8.GetString(Username.Data) +
                Encoding.UTF8.GetString(Email.Data) + Encoding.UTF8.GetString(Password.Data) +
                Url + Encoding.UTF8.GetString(Note.Data) + DateCreated + DateModified + Uid;

            IntegrityHash = Sha256Engine.ComputeSha256Hash(entryFields);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Title", Title);
            info.AddValue("Username", Username);
            info.AddValue("Email", Email);
            info.AddValue("Password", Password);
            info.AddValue("Url", Url);
            info.AddValue("Note", Note);
            info.AddValue("DateCreated", DateCreated);
            info.AddValue("DateModified", DateModified);
            info.AddValue("Uid", Uid);
            info.AddValue("EntryIv", Iv);
            info.AddValue("IntegrityHash", IntegrityHash);
        }

        public DatabaseEntry(SerializationInfo info, StreamingContext context)
        {
            Title = (string)info.GetValue("Title", typeof(string));
            Username = (SecureByteArray)info.GetValue("Username", typeof(SecureByteArray));
            Email = (SecureByteArray)info.GetValue("Email", typeof(SecureByteArray));
            Password = (SecureByteArray)info.GetValue("Password", typeof(SecureByteArray));
            Url = (string)info.GetValue("Url", typeof(string));
            Note = (SecureByteArray)info.GetValue("Note", typeof(SecureByteArray));
            DateCreated = (string)info.GetValue("DateCreated", typeof(string));
            DateModified = (string)info.GetValue("DateModified", typeof(string));
            Uid = (string)info.GetValue("Uid", typeof(string));
            Iv = (byte[])info.GetValue("EntryIv", typeof(byte[]));
            IntegrityHash = (string)info.GetValue("IntegrityHash", typeof(string));
        }
    }
}