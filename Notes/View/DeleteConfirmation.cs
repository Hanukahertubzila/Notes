using Notes.Domain;
using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Notes.View
{
    public partial class DeleteConfirmation : Form
    {
        public DeleteConfirmation(IServices services)
        {
            InitializeComponent();
            _services = services;  
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private IServices _services;

        private void DeleteConfirmation_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(_services.Settings.BackColor);
            SureDeleteLabel.ForeColor = Color.FromArgb(_services.Settings.ForeColor);
            ExitButton.ForeColor = Color.FromArgb(_services.Settings.BackColor);
            ExitButton.BackColor = Color.FromArgb(_services.Settings.ForeColor);
            ExitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            ExitButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            YesButton.ForeColor = Color.FromArgb(_services.Settings.BackColor);
            YesButton.BackColor = Color.FromArgb(_services.Settings.ForeColor);
            YesButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            YesButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            NoButton.ForeColor = Color.FromArgb(_services.Settings.BackColor);
            NoButton.BackColor = Color.FromArgb(_services.Settings.ForeColor);
            NoButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            NoButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void YesButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void NoButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ExitButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void DeleteConfirmation_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
