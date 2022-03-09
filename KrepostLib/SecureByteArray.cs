using KrepostLib.Cryptography;

namespace KrepostLib
{
    public sealed class SecureByteArray
    {
        private byte[] data;
        /// <summary>
        /// The key member length must be 32 bytes (256 bits).
        /// </summary>
        private byte[] dataKey;
        /// <summary>
        /// The nonce member length must be 12 bytes (96 bits).
        /// </summary>
        private byte[] dataIv;
        /// <summary>
        /// The tag member length must be 16 bytes (128 bits).
        /// </summary>
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
            // Validate at least one element is present for encryption.
            if (data.Length == 0) return;

            // Validate key has been generated.
            if (dataKey == null)
            {
                // Generate 32 byte (256 bit) byte array.
                dataKey = Argon2Engine.DeriveKey(Generator.GenerateBytes(32), Generator.GenerateBytes(16));
            }

            // Validate nonce has been generated.
            if (dataIv == null)
            {
                // Generate 12 byte (96 bit) byte array.
                dataIv = Generator.GenerateBytes(16);
            }

            byte[] temp = AesEngine.Encrypt(data, dataKey, dataIv);
            
            // Overwrite plaintext data with ciphertext
            data = null;
            data = new byte[temp.Length];
            data = temp;
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
