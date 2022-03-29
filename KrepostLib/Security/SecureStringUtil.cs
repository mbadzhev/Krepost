// Code taken almost in full from https://codereview.stackexchange.com/questions/107860/converting-a-securestring-to-a-byte-array

using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace KrepostLib.Security
{
    public sealed class SecureStringUtil : IDisposable
    {
        /// <summary>
        /// Holds the input data in <see cref="SecureString"/>.
        /// </summary>
        private SecureString data;

        /// <summary>
        /// Holds the character encoding to use throughout the <see cref="SecureStringUtil"/> instance.
        /// </summary>
        private Encoding encoding;

        /// <summary>
        /// Holds the data from <see cref="SecureString"/> in byte array form.
        /// </summary>
        private byte[] dataByteArray;

        /// <summary>
        /// Keeps track if the object is disposed.
        /// </summary>
        private bool disposedStatus;

        /// <summary>
        /// Constructs a <see cref="SecureStringUtil"/> object.
        /// </summary>
        /// <param name="inputData">A <see cref="SecureString"/> object to be manipulated.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public SecureStringUtil(SecureString inputData)
        {
            if (inputData == null)
            {
                throw new ArgumentNullException("inputData");
            }

            if (inputData.Length <= 0)
            {
                throw new ArgumentOutOfRangeException("inputData");
            }

            data = inputData;

            if (encoding == null)
            {
                encoding = Encoding.UTF8;
            }

            disposedStatus = false;
        }
        /// <summary>
        /// Constructs a <see cref="SecureStringUtil"/> object.
        /// </summary>
        /// <param name="bytes">A byte array used as input data to be manipulated.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public SecureStringUtil(byte[] bytes)
        {
            if (bytes == null)
                throw new ArgumentNullException("bytes");
            if (bytes.Length <= 0)
                throw new ArgumentOutOfRangeException("bytes");

            dataByteArray = bytes;
            data = new SecureString();

            if (encoding == null)
                encoding = Encoding.UTF8;

            disposedStatus = false;
        }
        /// <summary>
        /// Converts a <see cref="SecureString"/> to a byte array.
        /// </summary>
        /// <returns>Plaintext byte array of data stored in a <see cref="SecureString"/>.</returns>
        public unsafe byte[] SecureStringToByteArray()
        {
            int maxLength = encoding.GetMaxByteCount(data.Length);

            IntPtr bytes = IntPtr.Zero;
            IntPtr str = IntPtr.Zero;

            try
            {
                bytes = Marshal.AllocHGlobal(maxLength);
                str = Marshal.SecureStringToBSTR(data);

                char* chars = (char*)str.ToPointer();
                byte* bptr = (byte*)bytes.ToPointer();
                int len = encoding.GetBytes(chars, data.Length, bptr, maxLength);

                dataByteArray = new byte[len];
                for (int i = 0; i < len; ++i)
                {
                    dataByteArray[i] = *bptr;
                    bptr++;
                }

                return dataByteArray;
            }
            finally
            {
                if (bytes != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(bytes);
                }
                if (str != IntPtr.Zero)
                {
                    Marshal.ZeroFreeBSTR(str);
                }
            }
        }
        /// <summary>
        /// Converts a byte array to a <see cref="SecureString"/> object.
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public SecureString ByteArrayToSecureString(byte[] bytes)
        {
            if (bytes == null)
                throw new ArgumentNullException("bytes");
            if (bytes.Length <= 0)
                throw new ArgumentOutOfRangeException("bytes");

            char[] tempChars = encoding.GetChars(bytes);

            // Zero out the data in the byte array
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = 0;
            }

            // Append all data from the char array to the secure string
            for (int i = 0; i < tempChars.Length; i++)
            {
                data.AppendChar(tempChars[i]);
                // Zero out the data in the char array
                tempChars[i] = (char)0;
            }
            return data;
        }
        public void Dispose()
        {
            if (!disposedStatus)
            {
                if (dataByteArray == null)
                {
                    return;
                }

                Array.Clear(dataByteArray, 0, dataByteArray.Length);

                disposedStatus = true;
            }
            GC.SuppressFinalize(this);
        }

        ~SecureStringUtil()
        {
            Dispose();
        }
    }
}