using Notes.Domain;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Notes.View
{
    public partial class NoteEditor : Form
    {
        public NoteEditor(Note current, Explorer explorer, IServices services)
        {
            InitializeComponent();
            _currentNote = current;
            _explorer = explorer;
            _services = services;
            NoteNameTextBox.Text = _currentNote.Name;
            NoteTextTextBox.Rtf = _currentNote.Text;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private Note _currentNote;
        private Explorer _explorer;
        private IServices _services;

        private void NoteEditor_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(_services.Settings.BackColor);
            BackgroundPanel.BackColor = Color.FromArgb(_services.Settings.ForeColor);
            ExitButton.BackColor = Color.FromArgb(_services.Settings.ForeColor);
            ExitButton.ForeColor = Color.FromArgb(_services.Settings.BackColor);
            ExitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            ExitButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            MinimizeButton.BackColor = Color.FromArgb(_services.Settings.ForeColor);
            MinimizeButton.ForeColor = Color.FromArgb(_services.Settings.BackColor);
            MinimizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            MinimizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            NoteNameTextBox.BackColor = Color.FromArgb(_services.Settings.BackColor);
            NoteNameTextBox.ForeColor = Color.FromArgb(_services.Settings.ForeColor);
            NoteTextTextBox.BackColor = Color.FromArgb(_services.Settings.BackColor);
            NoteTextTextBox.ForeColor = Color.FromArgb(_services.Settings.ForeColor);
            FontSizeLabel.ForeColor = Color.FromArgb(_services.Settings.ForeColor);
            FontSizeLabel.Text = Math.Round(NoteTextTextBox.Font.Size).ToString() + " pt";
            MakeFontBiggerButton.BackColor = Color.FromArgb(_services.Settings.ForeColor);
            MakeFontBiggerButton.ForeColor = Color.FromArgb(_services.Settings.BackColor);
            MakeFontBiggerButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            MakeFontBiggerButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            MakeFontSmallerButton.BackColor = Color.FromArgb(_services.Settings.ForeColor);
            MakeFontSmallerButton.ForeColor = Color.FromArgb(_services.Settings.BackColor);
            MakeFontSmallerButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            MakeFontSmallerButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            ApplicationNameLabel.ForeColor = Color.FromArgb(_services.Settings.ForeColor);
            MakeBoldButton.BackColor = Color.FromArgb(_services.Settings.ForeColor);
            MakeBoldButton.ForeColor = Color.FromArgb(_services.Settings.BackColor);
            MakeBoldButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            MakeBoldButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            MakeItalicButton.BackColor = Color.FromArgb(_services.Settings.ForeColor);
            MakeItalicButton.ForeColor = Color.FromArgb(_services.Settings.BackColor);
            MakeItalicButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            MakeItalicButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            MakeUnderlinedButton.BackColor = Color.FromArgb(_services.Settings.ForeColor);
            MakeUnderlinedButton.ForeColor = Color.FromArgb(_services.Settings.BackColor);
            MakeUnderlinedButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            MakeUnderlinedButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            MakeStrikedOutButton.BackColor = Color.FromArgb(_services.Settings.ForeColor);
            MakeStrikedOutButton.ForeColor = Color.FromArgb(_services.Settings.BackColor);
            MakeStrikedOutButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            MakeStrikedOutButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            LeftAlignButton.BackColor = Color.FromArgb(_services.Settings.ForeColor);
            LeftAlignButton.ForeColor = Color.FromArgb(_services.Settings.BackColor);
            LeftAlignButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            LeftAlignButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            CenterAlignButton.BackColor = Color.FromArgb(_services.Settings.ForeColor);
            CenterAlignButton.ForeColor = Color.FromArgb(_services.Settings.BackColor);
            CenterAlignButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            CenterAlignButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            RightAlignButton.BackColor = Color.FromArgb(_services.Settings.ForeColor);
            RightAlignButton.ForeColor = Color.FromArgb(_services.Settings.BackColor);
            RightAlignButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            RightAlignButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            _currentNote.Save();
            _explorer.UpdateListView();
            _explorer.Show();
            Close();
        }

        private void Editor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void NoteNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentNote.Rename(NoteNameTextBox.Text, false);
        }

        private void NoteNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                _currentNote.Rename(NoteNameTextBox.Text, false);
                SelectNextControl(Controls.Owner, true, true, true, true);
            }
        }

        private void NoteTextTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentNote.EditText(NoteTextTextBox.Rtf, false);
        }

        private void MakeBoldButton_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Bold);
        }

        private void MakeItalicButton_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Italic);
        }

        private void MakeStrikedOutButton_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Strikeout);
        }

        private void MakeUnderlinedButton_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Underline);
        }

        private void RightAlignButton_Click(object sender, EventArgs e)
        {
            NoteTextTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void CenterAlignButton_Click(object sender, EventArgs e)
        {
            NoteTextTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void LeftAlignButton_Click(object sender, EventArgs e)
        {
            NoteTextTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void MakeFontBiggerButton_Click(object sender, EventArgs e)
        {
            ChangeFontSize(1);
        }

        private void MakeFontSmallerButton_Click(object sender, EventArgs e)
        {
            ChangeFontSize(-1);
        }

        private void ChangeFontStyle(FontStyle style)
        {
            if (NoteTextTextBox.SelectionFont == null)
                NoteTextTextBox.SelectionStart = NoteTextTextBox.Rtf.Length;
            NoteTextTextBox.SelectionFont =
                new Font(NoteTextTextBox.Font.FontFamily, 14, NoteTextTextBox.SelectionFont.Style ^ style);
            NoteTextTextBox.Focus();
        }

        private void ChangeFontSize(int change)
        {
            if (NoteTextTextBox.SelectionFont == null)
                NoteTextTextBox.SelectionStart = NoteTextTextBox.Rtf.Length;
            NoteTextTextBox.SelectionFont =
                new Font(NoteTextTextBox.Font.FontFamily, NoteTextTextBox.SelectionFont.Size + change,
                NoteTextTextBox.SelectionFont.Style);
            NoteTextTextBox.Focus();
            ChangeFontSizeLabelText();
        }

        private void NoteTextTextBox_OnSelectionChanged(object sender, EventArgs e)
        {
            ChangeFontSizeLabelText();
        }

        private void ChangeFontSizeLabelText()
        {
            FontSizeLabel.Text = NoteTextTextBox.SelectedRtf == null ?
                Math.Round(NoteTextTextBox.Font.Size) + " pt" :
                Math.Round(NoteTextTextBox.SelectionFont.Size) + " pt";
        }
    }
}
