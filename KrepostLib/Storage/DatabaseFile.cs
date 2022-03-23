using KrepostLib.Cryptography;

namespace KrepostLib.Storage
{
    [Serializable]
    public sealed class DatabaseFile
    {
        /// <summary>
        /// Gets or sets the database head as a byte array.
        /// </summary>
        public byte[]? Head { get; set; }
        /// <summary>
        /// Gets or sets the hash used for validating the integrity of the head.
        /// </summary>
        public string? HeadHash { get; set; }
        /// <summary>
        /// Gets or sets the encrypted database body as a byte array.
        /// </summary>
        public byte[]? Body { get; set; }
        /// <summary>
        /// Gets or sets the hash used for validating the integrity of the body.
        /// </summary>
        public string? BodyHash { get; set; }
        /// <summary>
        /// Gets or sets the hash function used to compute the hashes of the head and body.
        /// </summary>
        public HashId HashFunction { get; set; }
        /// <summary>
        /// Gets or sets the salt used to compute the hashes of the head and body.
        /// </summary>
        public byte[]? Salt { get; set; }

        public bool ValidateHead()
        {
            if (Head == null)
            {
                throw new InvalidOperationException("Head is null");
            }
            if (Head.Length <= 0)
            {
                throw new InvalidOperationException("Head cannot be <= 0");
            }
            if (HeadHash == Sha256Engine.ComputeSha256Hash(Head, Salt))
            {
                return true;
            }
            return false;
        }
        public bool ValidateBody()
        {
            if (Body == null)
            {
                throw new InvalidOperationException("Head is null");
            }
            if (Body.Length <= 0)
            {
                throw new InvalidOperationException("Head cannot be <= 0");
            }
            if (BodyHash == Sha256Engine.ComputeSha256Hash(Body, Salt))
            {
                return true;
            }
            return false;
        }
    }
}
