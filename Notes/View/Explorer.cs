using BrightIdeasSoftware;
using Notes.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Notes.View
{
    public partial class Explorer : Form
    {
        public Explorer(Services services)
        {
            InitializeComponent();
            _keeper = new Keeper(services);
            _currentFolder = _keeper.RootFolder;
            _services = _keeper.Services;
            _previousFolders = new Stack<Folder>();
            _nextFolders = new Stack<Folder>();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private Keeper _keeper;
        private Folder _currentFolder;
        private IServices _services;
        private Stack<Folder> _previousFolders;
        private Stack<Folder> _nextFolders;

        public void UpdateColors()
        {
            BackColor = Color.FromArgb(_services.Settings.BackColor);
            NewNoteButton.BackColor = Color.FromArgb(_services.Settings.ForeColor);
            NewNoteButton.ForeColor = Color.FromArgb(_services.Settings.BackColor);
            NewNoteButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            NewNoteButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            NewFolderButton.BackColor = Color.FromArgb(_services.Settings.ForeColor);
            NewFolderButton.ForeColor = Color.FromArgb(_services.Settings.BackColor);
            NewFolderButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            NewFolderButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            DeleteButton.BackColor = Color.FromArgb(_services.Settings.ForeColor);
            DeleteButton.ForeColor = Color.FromArgb(_services.Settings.BackColor);
            DeleteButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            DeleteButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            ExitButton.BackColor = Color.FromArgb(_services.Settings.ForeColor);
            ExitButton.ForeColor = Color.FromArgb(_services.Settings.BackColor);
            ExitButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            ExitButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            MinimizeButton.BackColor = Color.FromArgb(_services.Settings.ForeColor);
            MinimizeButton.ForeColor = Color.FromArgb(_services.Settings.BackColor);
            MinimizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            MinimizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            SettingsButton.BackColor = Color.FromArgb(_services.Settings.BackColor);
            SettingsButton.ForeColor = Color.FromArgb(_services.Settings.ForeColor);
            SettingsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.BackColor);
            SettingsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.BackColor);
            GoBackButton.BackColor = Color.FromArgb(_services.Settings.BackColor);
            GoBackButton.ForeColor = Color.FromArgb(_services.Settings.ForeColor);
            GoBackButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.BackColor);
            GoBackButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.BackColor);
            GoForwardButton.BackColor = Color.FromArgb(_services.Settings.BackColor);
            GoForwardButton.ForeColor = Color.FromArgb(_services.Settings.ForeColor);
            GoForwardButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(_services.Settings.BackColor);
            GoForwardButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(_services.Settings.BackColor);
            ApplicationNameLabel.ForeColor = Color.FromArgb(_services.Settings.ForeColor);
            ListView.BackColor = Color.FromArgb(_services.Settings.ForeColor);
            ListView.ForeColor = Color.FromArgb(_services.Settings.BackColor);
            ListView.AlternateRowBackColor = Color.FromArgb(_services.Settings.AlternativeColor);
            ListView.SelectedBackColor = Color.FromArgb(_services.Settings.BackColor);
            ListView.SelectedForeColor = Color.FromArgb(_services.Settings.ForeColor);
            ListView.UnfocusedSelectedBackColor = Color.FromArgb(_services.Settings.ForeColor);
            ListView.UnfocusedSelectedForeColor = Color.FromArgb(_services.Settings.BackColor);
        }

        public void UpdateListView()
        {
            ListView.ClearObjects();
            var content = _currentFolder.GetContent().ToList();
            ListView.HeaderStyle = ColumnHeaderStyle.None;
            ListView.Columns[0].Width = 90;
            if (content.Count > 13)
                ListView.Columns[1].Width = 329;
            else
                ListView.Columns[1].Width = 346;
            foreach (var c in content)
            {
                c.ResetImages();
                c.SetDefaultImage();
                ListView.AddObject(c);
            }
        }

        private void Explorer_Load(object sender, EventArgs e)
        {
            UpdateColors();
            UpdateListView();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Explorer_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void NewFolderButton_Click(object sender, EventArgs e)
        {
            string name = null;
            using (GetFolderNameDialog EnterNameDialog = new GetFolderNameDialog(_services))
            {
                if (EnterNameDialog.ShowDialog() == DialogResult.OK)
                    name = EnterNameDialog.FoldersName;
            }
            if (name != null && name.Trim().Length > 0)
            {
                _currentFolder.AddFolder(name);
                UpdateListView();
            }
        }

        private void ItemDoubleClick(object sender, MouseEventArgs e)
        {
            EnterSelectedContent();
        }

        private void EnterSelectedContent()
        {
            if (ListView.SelectedObject is Folder)
            {
                _previousFolders.Push(_currentFolder);
                _nextFolders.Clear();
                _currentFolder = (Folder)ListView.SelectedObject;
            }
            else if (ListView.SelectedObject is Note)
                EnterNoteEditor((Note)ListView.SelectedObject);
            UpdateListView();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ListView.SelectedItem != null)
            {
                using(var sureDelete = new DeleteConfirmation(_services))
                {
                    if (sureDelete.ShowDialog() == DialogResult.OK)
                    {
                        ((IContent)ListView.SelectedObject).Delete();
                        UpdateListView();
                    }
                }
            }
        }

        private void NewNoteButton_Click(object sender, EventArgs e)
        {
            var note = _currentFolder.AddNote("Note");
            EnterNoteEditor(note);
        }

        private void EnterNoteEditor(Note note)
        {
            var editor = new NoteEditor(note, this, _services);
            editor.Show();
            Hide();
        }

        private void Explorer_Shown(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void Item_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && ListView.SelectedObject != null)
            {
                e.SuppressKeyPress = true;
                EnterSelectedContent();
            }
            else if (e.KeyCode == Keys.Delete && ListView.SelectedObject != null)
            {
                e.SuppressKeyPress = true;
                DeleteButton.PerformClick();
            }
        }

        private void SettingsButton_MouseHover(object sender, EventArgs e)
        {
            SettingsButton.ForeColor = Color.FromArgb(_services.Settings.AlternativeColor);
        }

        private void SettingsButton_MouseLeave(object sender, EventArgs e)
        {
            SettingsButton.ForeColor = Color.FromArgb(_services.Settings.ForeColor);
        }

        private void GoForwardButton_MouseHover(object sender, EventArgs e)
        {
            GoForwardButton.ForeColor = Color.FromArgb(_services.Settings.AlternativeColor);
        }

        private void GoForwardButton_MouseLeave(object sender, EventArgs e)
        {
            GoForwardButton.ForeColor = Color.FromArgb(_services.Settings.ForeColor);
        }

        private void GoBackButton_MouseHover(object sender, EventArgs e)
        {
            GoBackButton.ForeColor = Color.FromArgb(_services.Settings.AlternativeColor);
        }

        private void GoBackButton_MouseLeave(object sender, EventArgs e)
        {
            GoBackButton.ForeColor = Color.FromArgb(_services.Settings.ForeColor);
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            if (_previousFolders.Count > 0)
            {
                _nextFolders.Push(_currentFolder);
                _currentFolder = _previousFolders.Pop();
                UpdateListView();
            }
        }

        private void GoForwardButton_Click(object sender, EventArgs e)
        {
            if (_nextFolders.Count > 0)
            {
                _previousFolders.Push(_currentFolder);
                _currentFolder = _nextFolders.Pop();
                UpdateListView();
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            var settingsMenu = new SettingsMenu(_services, this);
            settingsMenu.Show();
            Hide();
        }

        private void ListView_OnMouseDown(object sender, MouseEventArgs e)
        {
            foreach (var c in ListView.Objects)
            {
                if (ListView.OlvHitTest(e.X, e.Y).RowObject == c)
                    ((IContent)c).SetSelectedImage();
                else
                    ((IContent)c).SetDefaultImage();
                ListView.RefreshObject(c);
            }
        }
    }
}