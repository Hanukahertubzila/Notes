namespace Notes.View
{
    partial class Explorer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Explorer));
            this.ExitButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.ApplicationNameLabel = new System.Windows.Forms.Label();
            this.NewFolderButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NewNoteButton = new System.Windows.Forms.Button();
            this.ListViewParentPanel = new System.Windows.Forms.Panel();
            this.ListView = new BrightIdeasSoftware.ObjectListView();
            this.image = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Title = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.SettingsButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.GoForwardButton = new System.Windows.Forms.Button();
            this.ListViewParentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListView)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(206)))), ((int)(((byte)(163)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.ExitButton.Location = new System.Drawing.Point(423, -1);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(41, 23);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.TabStop = false;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(206)))), ((int)(((byte)(163)))));
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.MinimizeButton.Location = new System.Drawing.Point(385, -1);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(41, 23);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Text = "—";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ApplicationNameLabel
            // 
            this.ApplicationNameLabel.AutoSize = true;
            this.ApplicationNameLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.ApplicationNameLabel.Location = new System.Drawing.Point(200, 8);
            this.ApplicationNameLabel.Name = "ApplicationNameLabel";
            this.ApplicationNameLabel.Size = new System.Drawing.Size(50, 22);
            this.ApplicationNameLabel.TabIndex = 2;
            this.ApplicationNameLabel.Text = "Notes";
            // 
            // NewFolderButton
            // 
            this.NewFolderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(206)))), ((int)(((byte)(163)))));
            this.NewFolderButton.FlatAppearance.BorderSize = 0;
            this.NewFolderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.NewFolderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.NewFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewFolderButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewFolderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.NewFolderButton.Location = new System.Drawing.Point(211, 624);
            this.NewFolderButton.Name = "NewFolderButton";
            this.NewFolderButton.Size = new System.Drawing.Size(180, 36);
            this.NewFolderButton.TabIndex = 5;
            this.NewFolderButton.TabStop = false;
            this.NewFolderButton.Text = "New Folder";
            this.NewFolderButton.UseVisualStyleBackColor = false;
            this.NewFolderButton.Click += new System.EventHandler(this.NewFolderButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(206)))), ((int)(((byte)(163)))));
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(406, 624);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(46, 36);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.TabStop = false;
            this.DeleteButton.Text = "X";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NewNoteButton
            // 
            this.NewNoteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(206)))), ((int)(((byte)(163)))));
            this.NewNoteButton.FlatAppearance.BorderSize = 0;
            this.NewNoteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.NewNoteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.NewNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewNoteButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewNoteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.NewNoteButton.Location = new System.Drawing.Point(16, 624);
            this.NewNoteButton.Name = "NewNoteButton";
            this.NewNoteButton.Size = new System.Drawing.Size(180, 36);
            this.NewNoteButton.TabIndex = 7;
            this.NewNoteButton.TabStop = false;
            this.NewNoteButton.Text = "New Note";
            this.NewNoteButton.UseVisualStyleBackColor = false;
            this.NewNoteButton.Click += new System.EventHandler(this.NewNoteButton_Click);
            // 
            // ListViewParentPanel
            // 
            this.ListViewParentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(33)))));
            this.ListViewParentPanel.Controls.Add(this.ListView);
            this.ListViewParentPanel.Location = new System.Drawing.Point(16, 40);
            this.ListViewParentPanel.Name = "ListViewParentPanel";
            this.ListViewParentPanel.Size = new System.Drawing.Size(436, 569);
            this.ListViewParentPanel.TabIndex = 3;
            // 
            // ListView
            // 
            this.ListView.AllColumns.Add(this.image);
            this.ListView.AllColumns.Add(this.Title);
            this.ListView.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.ListView.AutoArrange = false;
            this.ListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(206)))), ((int)(((byte)(163)))));
            this.ListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListView.CellEditUseWholeCell = false;
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.image,
            this.Title});
            this.ListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.ListView.FullRowSelect = true;
            this.ListView.HasCollapsibleGroups = false;
            this.ListView.HideSelection = false;
            this.ListView.IsSearchOnSortColumn = false;
            this.ListView.LabelWrap = false;
            this.ListView.Location = new System.Drawing.Point(0, 0);
            this.ListView.MultiSelect = false;
            this.ListView.Name = "ListView";
            this.ListView.PersistentCheckBoxes = false;
            this.ListView.RowHeight = 40;
            this.ListView.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.ListView.SelectedColumnTint = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.ListView.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.ListView.ShowFilterMenuOnRightClick = false;
            this.ListView.ShowGroups = false;
            this.ListView.ShowHeaderInAllViews = false;
            this.ListView.ShowSortIndicators = false;
            this.ListView.Size = new System.Drawing.Size(436, 569);
            this.ListView.SortGroupItemsByPrimaryColumn = false;
            this.ListView.TabIndex = 0;
            this.ListView.TabStop = false;
            this.ListView.UnfocusedSelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.ListView.UnfocusedSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ListView.UseAlternatingBackColors = true;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Item_KeyDown);
            this.ListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ItemDoubleClick);
            this.ListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListView_OnMouseDown);
            // 
            // image
            // 
            this.image.AspectName = "";
            this.image.Hideable = false;
            this.image.ImageAspectName = "Image";
            this.image.IsEditable = false;
            this.image.Searchable = false;
            this.image.ShowTextInHeader = false;
            this.image.Sortable = false;
            this.image.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.image.UseFiltering = false;
            this.image.Width = 104;
            // 
            // Title
            // 
            this.Title.AspectName = "Name";
            this.Title.AutoCompleteEditor = false;
            this.Title.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Title.Groupable = false;
            this.Title.HeaderCheckBoxUpdatesRowCheckBoxes = false;
            this.Title.IsEditable = false;
            this.Title.Searchable = false;
            this.Title.ShowTextInHeader = false;
            this.Title.Sortable = false;
            this.Title.UseFiltering = false;
            this.Title.Width = 382;
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SettingsButton.Location = new System.Drawing.Point(4, 4);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SettingsButton.Size = new System.Drawing.Size(30, 33);
            this.SettingsButton.TabIndex = 8;
            this.SettingsButton.Text = "⚙";
            this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            this.SettingsButton.MouseLeave += new System.EventHandler(this.SettingsButton_MouseLeave);
            this.SettingsButton.MouseHover += new System.EventHandler(this.SettingsButton_MouseHover);
            // 
            // GoBackButton
            // 
            this.GoBackButton.FlatAppearance.BorderSize = 0;
            this.GoBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoBackButton.ForeColor = System.Drawing.SystemColors.Control;
            this.GoBackButton.Location = new System.Drawing.Point(31, -5);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GoBackButton.Size = new System.Drawing.Size(30, 33);
            this.GoBackButton.TabIndex = 9;
            this.GoBackButton.Text = "⮪";
            this.GoBackButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            this.GoBackButton.MouseLeave += new System.EventHandler(this.GoBackButton_MouseLeave);
            this.GoBackButton.MouseHover += new System.EventHandler(this.GoBackButton_MouseHover);
            // 
            // GoForwardButton
            // 
            this.GoForwardButton.FlatAppearance.BorderSize = 0;
            this.GoForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoForwardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoForwardButton.ForeColor = System.Drawing.SystemColors.Control;
            this.GoForwardButton.Location = new System.Drawing.Point(56, -5);
            this.GoForwardButton.Name = "GoForwardButton";
            this.GoForwardButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GoForwardButton.Size = new System.Drawing.Size(30, 33);
            this.GoForwardButton.TabIndex = 10;
            this.GoForwardButton.Text = "⮫";
            this.GoForwardButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GoForwardButton.UseVisualStyleBackColor = true;
            this.GoForwardButton.Click += new System.EventHandler(this.GoForwardButton_Click);
            this.GoForwardButton.MouseLeave += new System.EventHandler(this.GoForwardButton_MouseLeave);
            this.GoForwardButton.MouseHover += new System.EventHandler(this.GoForwardButton_MouseHover);
            // 
            // Explorer
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(464, 681);
            this.Controls.Add(this.GoForwardButton);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.NewNoteButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.NewFolderButton);
            this.Controls.Add(this.ListViewParentPanel);
            this.Controls.Add(this.ApplicationNameLabel);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Explorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explorer";
            this.Load += new System.EventHandler(this.Explorer_Load);
            this.Shown += new System.EventHandler(this.Explorer_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Explorer_MouseDown);
            this.ListViewParentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Label ApplicationNameLabel;
        private System.Windows.Forms.Button NewFolderButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button NewNoteButton;
        private System.Windows.Forms.Panel ListViewParentPanel;
        private BrightIdeasSoftware.ObjectListView ListView;
        private BrightIdeasSoftware.OLVColumn image;
        private BrightIdeasSoftware.OLVColumn Title;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button GoForwardButton;
    }
}