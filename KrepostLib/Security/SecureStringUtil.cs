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

        public byte[] ToByteArray()
        {
            throw new NotImplementedException();
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