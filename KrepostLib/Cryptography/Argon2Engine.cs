using System.Text;

using Konscious.Security.Cryptography;

namespace KrepostLib.Cryptography
{
    public static class Argon2Engine
    {
        public static byte[] DeriveKey(string password, byte[] salt)
        {
            // Argon2id is a good compromise between Argon2i & Argon2d.
            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password));

            // TODO: Develop a way to change the parameters for kdf to match PC hardware
            argon2.Salt = salt;
            argon2.DegreeOfParallelism = 8; // four cores
            argon2.Iterations = 4;
            argon2.MemorySize = 256 * 256; // 256 MB

            // GetBytes takes in an argument for the number of bytes to generate.
            // AES256 requires a 256 bit key so 32 bytes (256 bits) are called for.
            return argon2.GetBytes(32);
        }
    }
}
