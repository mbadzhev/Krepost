using System.Diagnostics;
using System.Security.Cryptography;

namespace KrepostLib.Cryptography
{
    public static class Generator
    {
        /// <summary>
        /// Generates cryptographically strong set of bytes.
        /// </summary>
        /// <param name="byteNumber">Number of bytes to be generated.</param>
        /// <returns>A new byte array.</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static byte[] GenerateBytes(int byteNumber)
        {
            if (byteNumber <= 0)
            {
                // Can't have less than one byte
                Debug.Assert(false); 
                throw new ArgumentOutOfRangeException("size");
            }
            int arraySize = byteNumber;
            byte[] byteArray = new byte[arraySize];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(byteArray);
            }
            return byteArray;
        }
    }
}
