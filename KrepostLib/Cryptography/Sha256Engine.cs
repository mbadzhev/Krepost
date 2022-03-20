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

            // TODO: Securely transport the plain text.
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
