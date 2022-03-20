// Code taken largely from: http://www.blackwasp.co.uk/SecureStringTextBox.aspx

using System.Security;

using KrepostLib.Security;
using KrepostLib.Cryptography;

namespace KrepostWinForms.UI
{
    public partial class SecureStringTextBox : UserControl
    {
        private SecureString data = new SecureString();
        private string dataHash;
        private byte[] dataSalt;
        private bool emptyStatus;

        public SecureString Data
        {
            get
            {
                return data;
            }
        }
        public string DataHash
        {
            get { return dataHash; }
            set { dataHash = value; }
        }
        public byte[] DataSalt
        {
            get { return dataSalt; }
            set { dataSalt = value; }
        }

        public SecureStringTextBox()
        {
            InitializeComponent();
            
            emptyStatus = true;
        }
        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ProcessDelete();
                e.Handled = true;
            }
        }
        private void InputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            emptyStatus = false;

            if (e.KeyChar == (char)Keys.Back)
            {
                ProcessBackspace();
            }
            else if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Escape)
            {
                return;
            }
            else
            {
                ProcessNewCharacter(e.KeyChar);
            }

            e.Handled = true;

            if (emptyStatus)
            {
                return;
            }
            else
            {
                HashData();
            }
        }
        private void ProcessBackspace()
        {
            if (InputBox.SelectionLength > 0)
            {
                RemoveSelectedCharacters();
                ResetDisplayCharacters(InputBox.SelectionStart);
            }
            else if (InputBox.SelectionStart > 0)
            {
                data.RemoveAt(InputBox.SelectionStart - 1);
                ResetDisplayCharacters(InputBox.SelectionStart - 1);
            }
            if (data.Length <= 0)
            {
                emptyStatus = true;
            }
        }
        private void ProcessNewCharacter(char character)
        {
            if (InputBox.SelectionLength > 0)
            {
                RemoveSelectedCharacters();
            }

            data.InsertAt(InputBox.SelectionStart, character);
            ResetDisplayCharacters(InputBox.SelectionStart + 1);
        }
        private void RemoveSelectedCharacters()
        {
            for (int i = 0; i < InputBox.SelectionLength; i++)
            {
                data.RemoveAt(InputBox.SelectionStart);
            }
        }
        private void ResetDisplayCharacters(int caretPosition)
        {
            InputBox.Text = new string(InputBox.PasswordChar, data.Length);
            InputBox.SelectionStart = caretPosition;
        }
        private void ProcessDelete()
        {
            if (InputBox.SelectionLength > 0)
            {
                RemoveSelectedCharacters();
            }
            else if (InputBox.SelectionStart < InputBox.Text.Length)
            {
                data.RemoveAt(InputBox.SelectionStart);
            }

            ResetDisplayCharacters(InputBox.SelectionStart);

            if (data.Length <= 0)
            {
                emptyStatus = true;
            }
        }
        private void HashData()
        {
            if (dataSalt == null || dataSalt.Length <= 0)
            {
                dataSalt = Generator.GenerateBytes(16);
            }
            using (SecureStringUtil wrapper = new SecureStringUtil(data))
            {
                byte[] plaintext = wrapper.SecureStringToByteArray();
                dataHash = Sha256Engine.ComputeSha256Hash(plaintext, dataSalt);
                Array.Clear(plaintext, 0, plaintext.Length);
            }
        }
        public SecureByteArray ToSecureByteArray()
        {
            using (SecureStringUtil util = new SecureStringUtil(Data))
            {
                byte[] bytes = util.SecureStringToByteArray();
                SecureByteArray secureBytes = new SecureByteArray(ref bytes);
                Array.Clear(bytes, 0, bytes.Length);
                return secureBytes;
            }
        }
    }
}