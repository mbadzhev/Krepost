using System.Text;

using Konscious.Security.Cryptography;

using KrepostLib.Security;

namespace KrepostLib.Cryptography
{
    public static class Argon2Engine
    {
        public static Stream DeriveKey(string password, byte[] salt)
        {
            // Argon2id is a good compromise between Argon2i & Argon2d.
            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password));

            // TODO: Develop a way to change the parameters for kdf to match PC hardware
            argon2.Salt = salt; // Salt is recommended to be 16 bytes
            argon2.DegreeOfParallelism = 8; // four cores
            argon2.Iterations = 4;
            argon2.MemorySize = 256 * 256; // 256 MB

            // GetBytes takes in an argument for the number of bytes to generate.
            // AES256 requires a 256 bit key so 32 bytes (256 bits) are called for.
            return new MemoryStream(argon2.GetBytes(32));
        }
        public static byte[] DeriveKey(byte[] input, byte[] salt)
        {
            var argon2 = new Argon2id(input);

            // TODO: Develop a way to change the parameters for kdf to match PC hardware
            argon2.Salt = salt; // Salt is recommended to be 16 bytes
            argon2.DegreeOfParallelism = 8; // four cores
            argon2.Iterations = 4;
            argon2.MemorySize = 256 * 256; // 256 MB

            return argon2.GetBytes(32);
        }
        public static byte[] DeriveKey(SecureByteArray input, byte[] salt)
        {
            byte[] bytes = input.Expose();
            byte[] key = DeriveKey(bytes, salt);
            Array.Clear(bytes, 0, bytes.Length);
            return key;
        }
    }
}
