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
        public SecureByteArray(byte[] array)
        {
            // Validate byte array contains some data.
            if (array == null)
            {
                throw new ArgumentNullException("data");
            }

            // Get number of elements in array.
            int arrayLength = array.Length;

            // Validate byte array contains at least one element.
            if (arrayLength < 0)
            {
                throw new ArgumentOutOfRangeException("arrayLength");
            }

            dataLenght = (uint)arrayLength;
            // Declare byte array of size.
            data = new byte[dataLenght];

            // Copy argument array into field array.
            Array.Copy(array, 0, data, 0, dataLenght);

            // Encrypt the byte array.
            Encrypt();
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
