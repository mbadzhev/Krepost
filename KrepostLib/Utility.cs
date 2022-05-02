using System.Text;

namespace KrepostLib
{
    public static class Utility
    {
        /// <summary>
        /// Compares two instances of <see cref="string"/> datatype.
        /// </summary>
        /// <param name="str1">The first string to be compared.</param>
        /// <param name="str2">The second string to be compared.</param>
        /// <returns>True if the instances match, false if they do not match.</returns>
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
        /// <summary>
        /// Creates a stamp of the current time and date.
        /// </summary>
        /// <returns>The date and time stamp.</returns>
        public static string GetTimestamp()
        {
            DateTime time = DateTime.Now;
            return time.ToString("yyyyMMddHHmmssffff");
        }
        /// <summary>
        /// Converts a <see cref="string"/> to a byte array.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static byte[] ToByteArray(string value)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(value);
            return bytes;
        }
        /// <summary>
        /// Displays the contents of a byte array in hex to the console.
        /// </summary>
        /// <param name="bytes"></param>
        public static void DisplayBytes(byte[] bytes)
        {
            // Debugging only.
            for (int i = 0; i < bytes.Length; ++i)
            {
                Console.Write(bytes[i].ToString("x2") + " ");
                if (i > 0 && i % 16 == 0) Console.Write("\n");
            }
            Console.WriteLine("");
        }
    }
}
