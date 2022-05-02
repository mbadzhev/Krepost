using KrepostLib.Cryptography;

namespace KrepostLib.Security
{
    [Serializable]
    public sealed class SecureByteArray
    {
        /// <summary>
        /// Holds data in plaintext or ciphertext form.
        /// </summary>
        private byte[] data;

        /// <summary>
        /// Holds the key used for encryption and decryption.
        /// The key length must be 32 bytes (256 bits).
        /// </summary>
        private byte[] dataKey;

        /// <summary>
        /// Holds the initialization vector used for encryption and decryption.
        /// The iv member length must be 16 bytes (128 bits).
        /// </summary>
        private byte[] dataIv;

        /// <summary>
        /// Holds the number of bytes of the plaintext.
        /// </summary>
        private int plainTextLength;

        /// <summary>
        /// Holds the number of bytes of the ciphertext.
        /// </summary>
        private int cipherTextLength;

        /// <summary>
        /// Used to prevent access from multiple threads at the same time.
        /// </summary>
        private readonly object lockObject = new object();

        /// <summary>
        /// Indicates if the data stored is encrypted or not.
        /// </summary>
        private bool encryptedStatus;

        /// <summary>
        /// Gets the total number of plaintext elements in the <see cref="SecureByteArray"/>.
        /// </summary>
        /// <returns>
        /// The total number of elements of the plaintext byte array.
        /// </returns>
		public int Length
        {
            get
            {
                return plainTextLength;
            }
        }
        public byte[] Data
        {
            get
            {
                if (encryptedStatus)
                {
                    return data;
                }
                else
                {
                    throw new InvalidOperationException();
                    return null;
                }
            }
        }

        /// <summary>
        /// Construct a secure byte array object.
        /// </summary>
        /// <param name="inputData">Data stored in the <see cref="SecureByteArray"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public SecureByteArray(ref byte[] inputData)
        {
            encryptedStatus = false;

            // Validate byte array contains some data.
            if (inputData == null)
            {
                throw new ArgumentNullException("inputData");
            }

            // Validate input data contains at least one element.
            if (inputData.Length <= 0)
            {
                throw new ArgumentOutOfRangeException("inputData.Length");
            }

            // Validate key has been generated.
            if (dataKey == null)
            {
                // Generate 32 byte (256 bit) byte array.
                dataKey = Argon2Engine.DeriveKey(Generator.GenerateBytes(32), Generator.GenerateBytes(16));
            }

            // Validate iv has been generated.
            if (dataIv == null)
            {
                // Generate 12 byte (96 bit) byte array.
                dataIv = Generator.GenerateBytes(16);
            }

            plainTextLength = inputData.Length;
            // Declare byte array of size.
            data = new byte[plainTextLength];

            // Copy argument array into field array.
            Array.Copy(inputData, 0, data, 0, plainTextLength);

            // Encrypt the byte array.
            Encrypt();
        }
        private void Encrypt()
        {
            ValidateCryptographicElements();

            byte[] temp = AesEngine.Encrypt(data, dataKey, dataIv);
            cipherTextLength = temp.Length;

            // Overwrite plaintext data with ciphertext
            data = new byte[cipherTextLength];
            Array.Copy(temp, 0, data, 0, cipherTextLength);

            encryptedStatus = true;
        }
        private void Decrypt()
        {
            ValidateCryptographicElements();

            byte[] temp = AesEngine.Decrypt(data, dataKey, dataIv);

            if (plainTextLength != temp.Length)
            {
                throw new ArgumentOutOfRangeException("plainTextLength");
            }

            // Overwrite ciphertext data with plaintext
            data = new byte[temp.Length];
            Array.Copy(temp, 0, data, 0, temp.Length);

            // Minimize plaintext exposure time in memory.
            Array.Clear(temp, 0, temp.Length);

            encryptedStatus = false;
        }

        /// <summary>
        /// Gets a copy of the stored data.
        /// The plaintext is exposed in memory and is at risk.
        /// </summary>
        /// <returns>Plaintext byte array.</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public byte[] Expose()
        {
            if (cipherTextLength == 0)
            {
                throw new ArgumentOutOfRangeException("cipherTextLength");
            }

            byte[] plainText = new byte[plainTextLength];

            lock (lockObject)
            {
                Decrypt();
                Array.Copy(data, 0, plainText, 0, plainTextLength);
                Encrypt();
            }

            return plainText;
        }
        private void ValidateCryptographicElements()
        {
            // Validate there is data to manipulate.
            if (data.Length <= 0)
            {
                throw new ArgumentOutOfRangeException("data.Length");
            }

            // Validate a key has been generated.
            if (dataKey == null)
            {
                throw new ArgumentNullException("dataKey");
            }

            // Validate nonce has been generated.
            if (dataIv == null)
            {
                throw new ArgumentNullException("dataIv");
            }
        }
    }
}
