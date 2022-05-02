using System.Text;

using Konscious.Security.Cryptography;

using KrepostLib.Security;

namespace KrepostLib.Cryptography
{
    public static class Argon2Engine
    {
        /// <summary>
        /// Derive cryptographic key using Argon2id.
        /// </summary>
        /// <param name="password">The password from which to derive a key.</param>
        /// <param name="salt">The salt used to randomize the output.</param>
        /// <returns>The derived key.</returns>
        public static Stream DeriveKey(string password, byte[] salt)
        {
            // Argon2id is a good compromise between Argon2i & Argon2d.
            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password));
            argon2.Salt = salt; // Salt is recommended to be 16 bytes
            argon2.DegreeOfParallelism = 8; // four cores
            argon2.Iterations = 4;
            argon2.MemorySize = 256 * 256; // 256 MB

            // GetBytes takes in an argument for the number of bytes to generate.
            // AES256 requires a 256 bit key so 32 bytes (256 bits) are called for.
            return new MemoryStream(argon2.GetBytes(32));
        }
        /// <summary>
        /// Derive cryptographic key using Argon2id.
        /// </summary>
        /// <param name="input">The password from which to derive a key.</param>
        /// <param name="salt">The salt used to randomize the output.</param>
        /// <returns>The derived key.</returns>
        public static byte[] DeriveKey(byte[] input, byte[] salt)
        {
            var argon2 = new Argon2id(input);
            argon2.Salt = salt;
            argon2.DegreeOfParallelism = 8;
            argon2.Iterations = 4;
            argon2.MemorySize = 256 * 256;

            return argon2.GetBytes(32);
        }
        /// <summary>
        /// Derive cryptographic key using Argon2id.
        /// </summary>
        /// <param name="input">The password from which to derive a key.</param>
        /// <param name="salt">The salt used to randomize the output.</param>
        /// <returns>The derived key.</returns>
        public static byte[] DeriveKey(SecureByteArray input, byte[] salt)
        {
            byte[] bytes = input.Expose();
            byte[] key = DeriveKey(bytes, salt);
            Array.Clear(bytes, 0, bytes.Length);
            return key;
        }
    }
}
