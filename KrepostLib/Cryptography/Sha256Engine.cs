using System.Text;
using System.Security.Cryptography;

namespace KrepostLib.Cryptography
{
    public static class Sha256Engine
    {
        /// <summary>
        /// Computes the hash value of the specified data using SHA-256.
        /// </summary>
        /// <param name="plainText">The data for which to calculate the hash.</param>
        /// <returns>The hash of the specified data.</returns>
        public static string ComputeSha256Hash(string plainText)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(plainText));

                // Convert byte array to a string.
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        /// <summary>
        /// Computes the hash value of the specified data using SHA-256.
        /// </summary>
        /// <param name="plainText">The data for which to calculate the hash.</param>
        /// <param name="salt">The salt used to randomize the output.</param>
        /// <returns>The hash of the specified data.</returns>
        public static string ComputeSha256Hash(string plainText, byte[] salt)
        {
            byte[] bytesInput = Encoding.UTF8.GetBytes(plainText);

            return ComputeSha256Hash(bytesInput, salt);
        }
        public static string ComputeSha256Hash(byte[] plainText, byte[] salt)
        {
            byte[] completeInput = new byte[plainText.Length + salt.Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                completeInput[i] = plainText[i];
            }

            for (int i = 0; i < salt.Length; i++)
            {
                completeInput[plainText.Length + i] = salt[i];
            }

            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(completeInput);

                // Convert byte array to a string.
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
