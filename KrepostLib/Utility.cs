using System.Text;

namespace KrepostLib
{
    public static class Utility
    {
        public static bool CompareStrings(string str1, string str2)
        {
            if (str1 == null || str2 == null)
                return false;
            if (str1.Length <= 0 || str2.Length <= 0)
                return false;
            if (str1 != str2)
                return false;
            return true;
        }
        public static string GetTimestamp()
        {
            DateTime time = DateTime.Now;
            return time.ToString("yyyyMMddHHmmssffff");
        }
        public static byte[] ToByteArray(string value)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(value);
            return bytes;
        }
        public static void DisplayBytes(byte[] bytes)
        {
            for (int i = 0; i < bytes.Length; ++i)
            {
                Console.Write(bytes[i].ToString("x2") + " ");
                if (i > 0 && i % 16 == 0) Console.Write("\n");
            }
            Console.WriteLine("");
        }
    }
}
