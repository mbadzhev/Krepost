using System.Text;

using System.Security.Cryptography;
using KrepostLib.Security;

namespace KrepostLib.Cryptography
{
    public sealed class HmacEngine
    {
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
