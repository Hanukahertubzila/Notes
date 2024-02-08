using Notes.Domain;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Notes.View
{
    public partial class GetFolderNameDialog : Form
    {
        public GetFolderNameDialog(IServices services)
        {
            InitializeComponent();
            _services = services;
        }

        public string FoldersName = "";
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private IServices _services;

        private void GetFolderNameDialog_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(_services.Settings.BackColor);
            EnterFoldersNameLabel.ForeColor = Color.FromArgb(_services.Settings.ForeColor);
            ExitButton.ForeColor = Color.FromArgb(_services.Settings.BackColor);
            ExitButton.BackColor = Color.FromArgb(_services.Settings.ForeColor);
            ExitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            ExitButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            OkButton.ForeColor = Color.FromArgb(_services.Settings.BackColor);
            OkButton.BackColor = Color.FromArgb(_services.Settings.ForeColor);
            OkButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            OkButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            FoldersNameTextBox.ForeColor = Color.FromArgb(_services.Settings.ForeColor);
            FoldersNameTextBox.BackColor = Color.FromArgb(_services.Settings.BackColor);
        }

        private void FoldersNameTextBox_TextChanged(object sender, EventArgs e)
        {
            FoldersName = FoldersNameTextBox.Text;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void GetFolderNameDialog_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EnterKeyToSubmitText(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && FoldersName.Length > 0)
            {
                e.Handled = true;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
