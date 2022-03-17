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
    }
}
