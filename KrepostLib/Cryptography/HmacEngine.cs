using System.Security.Cryptography;

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
    }
}
