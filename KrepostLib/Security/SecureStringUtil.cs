// Code taken almost in full from https://codereview.stackexchange.com/questions/107860/converting-a-securestring-to-a-byte-array

using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace KrepostLib.Security
{
    public sealed class SecureStringUtil : IDisposable
    {
        private SecureString data;
        private Encoding encoding;
        private byte[] dataByteArray;
        private bool disposedStatus;

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