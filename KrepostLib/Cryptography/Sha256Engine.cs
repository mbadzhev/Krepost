using System.Text;
using System.Security.Cryptography;

namespace KrepostLib.Cryptography
{
    public static class Sha256Engine
    {
        public static string ComputeSha256Hash(string plainText)
        {
            // TODO: Securely transport the plain text.
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
    }
}
