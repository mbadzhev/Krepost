namespace KrepostLib.Storage
{
    [Serializable]
    public sealed class DatabaseFile
    {
        public byte[]? Head { get; set; }
        public byte[]? Body { get; set; }
    }
}
