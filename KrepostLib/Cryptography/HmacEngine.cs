using System.Text;

using System.Security.Cryptography;
using KrepostLib.Security;

namespace KrepostLib.Cryptography
{
    public sealed class HmacEngine
    {
        /// <summary>
        /// Computes the HMAC of the specified data using SHA-256.
        /// </summary>
        /// <param name="data">The data for which to cumpute HMAC.</param>
        /// <param name="key">The cryptographic key used to compute the HMAC.</param>
        /// <param name="salt">The salt used to randomize the output.</param>
        /// <returns>The HMAC value for the specificed data.</returns>
        public static byte[] ComputeHmac(byte[] data, byte[] key, byte[] salt)
        {
            byte[] authenticationKey = Argon2Engine.DeriveKey(key, salt);

            using (HMACSHA256 hmac = new HMACSHA256(authenticationKey))
            {
                Array.Clear(key, 0, key.Length);
                Array.Clear(authenticationKey, 0, authenticationKey.Length);
                return hmac.ComputeHash(data);
            }
        }
        /// <summary>
        /// Computes the HMAC of the specified data using SHA-256.
        /// </summary>
        /// <param name="data">The data for which to cumpute HMAC.</param>
        /// <param name="key">The cryptographic key used to compute the HMAC.</param>
        /// <param name="salt">The salt used to randomize the output.</param>
        /// <returns>The HMAC value for the specificed data.</returns>
        public static string ComputeHmac(byte[] data, SecureByteArray key, byte[] salt)
        {
            byte[] bytes = key.Expose();
            byte[] signiture = ComputeHmac(data, bytes, salt);

            Array.Clear(bytes, 0, bytes.Length);

            // Convert byte array to string.
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < signiture.Length; i++)
            {
                builder.Append(signiture[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }
}
