using System.Security;
using System.Text;

namespace KrepostLib.Security
{
    public sealed class SecureStringUtil : IDisposable
    {
        private SecureString data;
        private Encoding encoding;

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

        }

        public byte[] ToByteArray()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        ~SecureStringUtil()
        {
            Dispose();
        }
    }
}