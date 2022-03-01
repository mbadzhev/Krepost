using System.Diagnostics;
using System.Security.Cryptography;

namespace KrepostLib.Cryptography
{
    public static class Generator
    {
        public static byte[] GenerateBytes(int size)
        {
            if (size <= 0)
            {
                // Can't have less than one byte
                Debug.Assert(false); 
                throw new ArgumentOutOfRangeException("size");
            }
            int arraySize = size;
            byte[] byteArray = new byte[arraySize];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(byteArray);
            }
            return byteArray;
        }
    }
}
