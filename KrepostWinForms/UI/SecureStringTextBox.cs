// Code taken largely from: http://www.blackwasp.co.uk/SecureStringTextBox.aspx

using System.Security;

namespace SecureStringTextBox
{
    public partial class SecureStringTextBox : UserControl
    {
        private SecureString data = new SecureString();

        public SecureString Data
        {
            get
            {
                return data;
            }
        }
        
        public SecureStringTextBox()
        {
            InitializeComponent();
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
            if (e.KeyChar == (char)Keys.Back)
            {
                ProcessBackspace();
            }
            else if (e.KeyChar == (char)Keys.Return || e.KeyChar== (char)Keys.Escape)
            {
                return;
            }
            else
            {
                ProcessNewCharacter(e.KeyChar);
            }

            e.Handled = true;
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
        }
    }
}