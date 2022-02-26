namespace KrepostWinForms.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuStripFileNew_Click(object sender, EventArgs e)
        {
            Form newDbForm = new NewDatabaseForm();
            newDbForm.ShowDialog();
        }

        private void menuStripFileOpen_Click(object sender, EventArgs e)
        {
            if (UI.Utility.OpenDatabase())
            {
                Form openDbForm = new OpenDatabaseForm();
                openDbForm.ShowDialog();
            }
        }
    }
}
