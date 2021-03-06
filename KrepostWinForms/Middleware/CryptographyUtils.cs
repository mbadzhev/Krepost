using System.Text;

using KrepostLib.Cryptography;
using KrepostLib.Security;

namespace KrepostWinForms.Middleware
{
    internal class CryptographyUtils
    {
        /// <summary>
        /// Generates a specific number of random bytes.
        /// </summary>
        /// <param name="bytes">The bumber of bytes to be generated.</param>
        /// <returns><see cref="byte"/>[] of generated bytes.</returns>
        public static byte[] GenerateSalt(int bytes)
        {
            return Generator.GenerateBytes(bytes);
        }
        /// <summary>
        /// Gets the plaintext stored in a <see cref="SecureByteArray"/>.
        /// This function exposes the plaintext in memory as immutable <see cref="string"/>.
        /// </summary>
        /// <param name="sba"><see cref="SecureByteArray"/> that contains the data to be exposed.</param>
        /// <returns><see cref="string"/> of the data.</returns>
        public static string GetString(SecureByteArray sba)
        {
            return Encoding.UTF8.GetString(sba.Expose());
        }
    }
}
