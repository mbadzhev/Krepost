namespace KrepostLib
{
    public sealed class SecureByteArray
    {
        private byte[] data;
        private uint dataLenght;

        /// <summary>
        /// Length of byte array is the number of elements present in the array.
        /// </summary>
		public uint Length
        {
            get
            {
                return dataLenght;
            }
        }
        public SecureByteArray()
        {
            // create byte[]
            throw new NotImplementedException();
        }
        public void Encrypt()
        {
            // encrypt byte[]
            throw new NotImplementedException();
        }
        public void Decrypt()
        {
            // decrypt byte[]
            throw new NotImplementedException();
        }
        public byte[] Read()
        {
            // decrypt byte[], return unsecure byte[] and encrypt byte[] again
            throw new NotImplementedException();
        }
    }
}
