using System.Security.Cryptography;

namespace KrepostLib.Cryptography
{
    public sealed class AesEngine
    {
        public static byte[] Encrypt(byte[] plainBytes, byte[] key, byte[] iv)
        {
            using (Aes cipher = Aes.Create())
            {
                cipher.Mode = CipherMode.CBC;
                cipher.Padding = PaddingMode.PKCS7;
                cipher.KeySize = 256;
                cipher.BlockSize = 128;

                cipher.Key = key;
                cipher.IV = iv;

                ICryptoTransform ct = cipher.CreateEncryptor();
                using (MemoryStream ms = new MemoryStream(plainBytes))
                {
                    using (CryptoStream cs = new CryptoStream(ms, ct, CryptoStreamMode.Read))
                    {
                        return ReadFully(cs);
                    }
                }
            }
        }
        //https://bytes.com/topic/java/answers/700499-cant-decrypt-my-aes-128-c-encrypted-byte-array-java really helped
        private static byte[] ReadFully(Stream stream)
        {
            // TODO: Introduce validation for byte array size
            byte[] buffer = new byte[32768];
            using (MemoryStream ms = new MemoryStream())
            {
                while (true)
                {
                    int read = stream.Read(buffer, 0, buffer.Length);
                    if (read <= 0)
                        return ms.ToArray();
                    ms.Write(buffer, 0, read);
                }
            }
        }
    }
}