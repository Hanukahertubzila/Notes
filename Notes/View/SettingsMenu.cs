using Notes.Domain;
using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;

namespace Notes.View
{
    public partial class SettingsMenu : Form
    {
        public SettingsMenu(IServices services, Explorer parent)
        {
            InitializeComponent();
            _services = services;
            _parent = parent;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private IServices _services;
        private Explorer _parent;

        private void SettingsMenu_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(_services.Settings.BackColor);
            SettingsLabel.ForeColor = Color.FromArgb(_services.Settings.ForeColor);
            BackColorLabel.ForeColor = Color.FromArgb(_services.Settings.ForeColor);
            ForeColorLabel.ForeColor = Color.FromArgb(_services.Settings.ForeColor);
            AlternativeColorLabel.ForeColor = Color.FromArgb(_services.Settings.ForeColor);
            VersionLabel.ForeColor = Color.FromArgb(_services.Settings.ForeColor);
            VersionLabel.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            YearLabel.ForeColor = Color.FromArgb(_services.Settings.ForeColor);
            YearLabel.Text = "2024";
            BackColorButton.BackColor = Color.FromArgb(_services.Settings.BackColor);
            BackColorButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.BackColor);
            BackColorButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.BackColor);
            ForeColorButton.BackColor= Color.FromArgb(_services.Settings.ForeColor);
            ForeColorButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.ForeColor);
            ForeColorButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.ForeColor);
            AlternativeColorButton.BackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            AlternativeColorButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            AlternativeColorButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            ExitButton.BackColor = Color.FromArgb(_services.Settings.ForeColor);
            ExitButton.ForeColor = Color.FromArgb(_services.Settings.BackColor);
            ExitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            ExitButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            _parent.Show();
            Close();
        }

        private void SettingsMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void BackColorButton_Click(object sender, EventArgs e)
        {
            using(var colorDlg = new ColorDialog())
            {
                colorDlg.Color = Color.FromArgb(_services.Settings.BackColor);
                if (colorDlg.ShowDialog() == DialogResult.Cancel)
                    return;
                BackColorButton.BackColor = colorDlg.Color;
                _services.Settings.BackColor = BackColorButton.BackColor.ToArgb();
                _parent.UpdateColors();
                _parent.UpdateListView();
                _services.Saver.SaveSettings(_services);
            }
        }

        private void ForeColorButton_Click(object sender, EventArgs e)
        {
            using (var colorDlg = new ColorDialog())
            {
                colorDlg.Color = Color.FromArgb(_services.Settings.ForeColor);
                if (colorDlg.ShowDialog() == DialogResult.Cancel)
                    return;
                ForeColorButton.BackColor = colorDlg.Color;
                _services.Settings.ForeColor = ForeColorButton.BackColor.ToArgb();
                _parent.UpdateColors();
                _parent.UpdateListView();
                _services.Saver.SaveSettings(_services);
            }
        }

        private void AlternativeColorButton_Click(object sender, EventArgs e)
        {
            using (var colorDlg = new ColorDialog())
            {
                colorDlg.Color = Color.FromArgb(_services.Settings.AlternativeColor);
                if (colorDlg.ShowDialog() == DialogResult.Cancel)
                    return;
                AlternativeColorButton.BackColor = colorDlg.Color;
                _services.Settings.AlternativeColor = AlternativeColorButton.BackColor.ToArgb();
                _parent.UpdateColors();
                _parent.UpdateListView();
                _services.Saver.SaveSettings(_services);
            }
        }
    }
}
