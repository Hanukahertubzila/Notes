namespace Notes.View
{
    partial class NoteEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteEditor));
            this.NoteTextTextBox = new System.Windows.Forms.RichTextBox();
            this.NoteNameTextBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.MakeBoldButton = new System.Windows.Forms.Button();
            this.MakeItalicButton = new System.Windows.Forms.Button();
            this.MakeStrikedOutButton = new System.Windows.Forms.Button();
            this.MakeUnderlinedButton = new System.Windows.Forms.Button();
            this.LeftAlignButton = new System.Windows.Forms.Button();
            this.RightAlignButton = new System.Windows.Forms.Button();
            this.CenterAlignButton = new System.Windows.Forms.Button();
            this.ApplicationNameLabel = new System.Windows.Forms.Label();
            this.FontSizeLabel = new System.Windows.Forms.Label();
            this.MakeFontBiggerButton = new System.Windows.Forms.Button();
            this.MakeFontSmallerButton = new System.Windows.Forms.Button();
            this.BackgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NoteTextTextBox
            // 
            this.NoteTextTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.NoteTextTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NoteTextTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteTextTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(206)))), ((int)(((byte)(163)))));
            this.NoteTextTextBox.HideSelection = false;
            this.NoteTextTextBox.Location = new System.Drawing.Point(11, 45);
            this.NoteTextTextBox.Name = "NoteTextTextBox";
            this.NoteTextTextBox.RightMargin = 647;
            this.NoteTextTextBox.Size = new System.Drawing.Size(675, 470);
            this.NoteTextTextBox.TabIndex = 0;
            this.NoteTextTextBox.Text = "";
            this.NoteTextTextBox.SelectionChanged += new System.EventHandler(this.NoteTextTextBox_OnSelectionChanged);
            this.NoteTextTextBox.TextChanged += new System.EventHandler(this.NoteTextTextBox_TextChanged);
            // 
            // NoteNameTextBox
            // 
            this.NoteNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(11)))));
            this.NoteNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NoteNameTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(206)))), ((int)(((byte)(163)))));
            this.NoteNameTextBox.Location = new System.Drawing.Point(12, 11);
            this.NoteNameTextBox.Name = "NoteNameTextBox";
            this.NoteNameTextBox.Size = new System.Drawing.Size(261, 27);
            this.NoteNameTextBox.TabIndex = 1;
            this.NoteNameTextBox.TextChanged += new System.EventHandler(this.NoteNameTextBox_TextChanged);
            this.NoteNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NoteNameTextBox_KeyDown);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(206)))), ((int)(((byte)(163)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(203)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(651, -1);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(41, 23);
            this.ExitButton.TabIndex = 2;
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
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimizeButton.Location = new System.Drawing.Point(611, -1);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(41, 23);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.Text = "—";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(206)))), ((int)(((byte)(163)))));
            this.BackgroundPanel.Controls.Add(this.NoteNameTextBox);
            this.BackgroundPanel.Controls.Add(this.NoteTextTextBox);
            this.BackgroundPanel.Location = new System.Drawing.Point(-3, 74);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(695, 531);
            this.BackgroundPanel.TabIndex = 4;
            // 
            // MakeBoldButton
            // 
            this.MakeBoldButton.BackColor = System.Drawing.Color.White;
            this.MakeBoldButton.FlatAppearance.BorderSize = 0;
            this.MakeBoldButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeBoldButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MakeBoldButton.Location = new System.Drawing.Point(12, 38);
            this.MakeBoldButton.Name = "MakeBoldButton";
            this.MakeBoldButton.Size = new System.Drawing.Size(28, 22);
            this.MakeBoldButton.TabIndex = 5;
            this.MakeBoldButton.Text = "B";
            this.MakeBoldButton.UseVisualStyleBackColor = false;
            this.MakeBoldButton.Click += new System.EventHandler(this.MakeBoldButton_Click);
            // 
            // MakeItalicButton
            // 
            this.MakeItalicButton.BackColor = System.Drawing.Color.White;
            this.MakeItalicButton.FlatAppearance.BorderSize = 0;
            this.MakeItalicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeItalicButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MakeItalicButton.Location = new System.Drawing.Point(55, 38);
            this.MakeItalicButton.Name = "MakeItalicButton";
            this.MakeItalicButton.Size = new System.Drawing.Size(28, 22);
            this.MakeItalicButton.TabIndex = 6;
            this.MakeItalicButton.Text = "I";
            this.MakeItalicButton.UseVisualStyleBackColor = false;
            this.MakeItalicButton.Click += new System.EventHandler(this.MakeItalicButton_Click);
            // 
            // MakeStrikedOutButton
            // 
            this.MakeStrikedOutButton.BackColor = System.Drawing.Color.White;
            this.MakeStrikedOutButton.FlatAppearance.BorderSize = 0;
            this.MakeStrikedOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeStrikedOutButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MakeStrikedOutButton.Location = new System.Drawing.Point(143, 38);
            this.MakeStrikedOutButton.Name = "MakeStrikedOutButton";
            this.MakeStrikedOutButton.Size = new System.Drawing.Size(28, 22);
            this.MakeStrikedOutButton.TabIndex = 7;
            this.MakeStrikedOutButton.Text = "S";
            this.MakeStrikedOutButton.UseVisualStyleBackColor = false;
            this.MakeStrikedOutButton.Click += new System.EventHandler(this.MakeStrikedOutButton_Click);
            // 
            // MakeUnderlinedButton
            // 
            this.MakeUnderlinedButton.BackColor = System.Drawing.Color.White;
            this.MakeUnderlinedButton.FlatAppearance.BorderSize = 0;
            this.MakeUnderlinedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeUnderlinedButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MakeUnderlinedButton.Location = new System.Drawing.Point(100, 38);
            this.MakeUnderlinedButton.Name = "MakeUnderlinedButton";
            this.MakeUnderlinedButton.Size = new System.Drawing.Size(28, 22);
            this.MakeUnderlinedButton.TabIndex = 8;
            this.MakeUnderlinedButton.Text = "U";
            this.MakeUnderlinedButton.UseVisualStyleBackColor = false;
            this.MakeUnderlinedButton.Click += new System.EventHandler(this.MakeUnderlinedButton_Click);
            // 
            // LeftAlignButton
            // 
            this.LeftAlignButton.BackColor = System.Drawing.Color.White;
            this.LeftAlignButton.FlatAppearance.BorderSize = 0;
            this.LeftAlignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftAlignButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftAlignButton.Location = new System.Drawing.Point(219, 38);
            this.LeftAlignButton.Name = "LeftAlignButton";
            this.LeftAlignButton.Size = new System.Drawing.Size(28, 22);
            this.LeftAlignButton.TabIndex = 9;
            this.LeftAlignButton.Text = "\t—";
            this.LeftAlignButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LeftAlignButton.UseVisualStyleBackColor = false;
            this.LeftAlignButton.Click += new System.EventHandler(this.LeftAlignButton_Click);
            // 
            // RightAlignButton
            // 
            this.RightAlignButton.BackColor = System.Drawing.Color.White;
            this.RightAlignButton.FlatAppearance.BorderSize = 0;
            this.RightAlignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightAlignButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightAlignButton.Location = new System.Drawing.Point(305, 38);
            this.RightAlignButton.Name = "RightAlignButton";
            this.RightAlignButton.Size = new System.Drawing.Size(28, 22);
            this.RightAlignButton.TabIndex = 10;
            this.RightAlignButton.Text = "\t—";
            this.RightAlignButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RightAlignButton.UseVisualStyleBackColor = false;
            this.RightAlignButton.Click += new System.EventHandler(this.RightAlignButton_Click);
            // 
            // CenterAlignButton
            // 
            this.CenterAlignButton.BackColor = System.Drawing.Color.White;
            this.CenterAlignButton.FlatAppearance.BorderSize = 0;
            this.CenterAlignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CenterAlignButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CenterAlignButton.Location = new System.Drawing.Point(262, 38);
            this.CenterAlignButton.Name = "CenterAlignButton";
            this.CenterAlignButton.Size = new System.Drawing.Size(28, 22);
            this.CenterAlignButton.TabIndex = 11;
            this.CenterAlignButton.Text = "\t—";
            this.CenterAlignButton.UseVisualStyleBackColor = false;
            this.CenterAlignButton.Click += new System.EventHandler(this.CenterAlignButton_Click);
            // 
            // ApplicationNameLabel
            // 
            this.ApplicationNameLabel.AutoSize = true;
            this.ApplicationNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.ApplicationNameLabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApplicationNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ApplicationNameLabel.Location = new System.Drawing.Point(7, 1);
            this.ApplicationNameLabel.Name = "ApplicationNameLabel";
            this.ApplicationNameLabel.Size = new System.Drawing.Size(56, 25);
            this.ApplicationNameLabel.TabIndex = 12;
            this.ApplicationNameLabel.Text = "Notes";
            // 
            // FontSizeLabel
            // 
            this.FontSizeLabel.AutoSize = true;
            this.FontSizeLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FontSizeLabel.ForeColor = System.Drawing.Color.Coral;
            this.FontSizeLabel.Location = new System.Drawing.Point(389, 38);
            this.FontSizeLabel.Name = "FontSizeLabel";
            this.FontSizeLabel.Size = new System.Drawing.Size(49, 19);
            this.FontSizeLabel.TabIndex = 13;
            this.FontSizeLabel.Text = "20 pt";
            // 
            // MakeFontBiggerButton
            // 
            this.MakeFontBiggerButton.BackColor = System.Drawing.Color.White;
            this.MakeFontBiggerButton.FlatAppearance.BorderSize = 0;
            this.MakeFontBiggerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeFontBiggerButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MakeFontBiggerButton.Location = new System.Drawing.Point(444, 36);
            this.MakeFontBiggerButton.Name = "MakeFontBiggerButton";
            this.MakeFontBiggerButton.Size = new System.Drawing.Size(28, 22);
            this.MakeFontBiggerButton.TabIndex = 14;
            this.MakeFontBiggerButton.Text = "▲";
            this.MakeFontBiggerButton.UseVisualStyleBackColor = false;
            this.MakeFontBiggerButton.Click += new System.EventHandler(this.MakeFontBiggerButton_Click);
            // 
            // MakeFontSmallerButton
            // 
            this.MakeFontSmallerButton.BackColor = System.Drawing.Color.White;
            this.MakeFontSmallerButton.FlatAppearance.BorderSize = 0;
            this.MakeFontSmallerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeFontSmallerButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MakeFontSmallerButton.Location = new System.Drawing.Point(487, 36);
            this.MakeFontSmallerButton.Name = "MakeFontSmallerButton";
            this.MakeFontSmallerButton.Size = new System.Drawing.Size(28, 22);
            this.MakeFontSmallerButton.TabIndex = 15;
            this.MakeFontSmallerButton.Text = "▼";
            this.MakeFontSmallerButton.UseVisualStyleBackColor = false;
            this.MakeFontSmallerButton.Click += new System.EventHandler(this.MakeFontSmallerButton_Click);
            // 
            // NoteEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(691, 600);
            this.Controls.Add(this.MakeFontSmallerButton);
            this.Controls.Add(this.MakeFontBiggerButton);
            this.Controls.Add(this.FontSizeLabel);
            this.Controls.Add(this.ApplicationNameLabel);
            this.Controls.Add(this.RightAlignButton);
            this.Controls.Add(this.MakeUnderlinedButton);
            this.Controls.Add(this.CenterAlignButton);
            this.Controls.Add(this.MakeStrikedOutButton);
            this.Controls.Add(this.LeftAlignButton);
            this.Controls.Add(this.MakeItalicButton);
            this.Controls.Add(this.MakeBoldButton);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.BackgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NoteEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Note Editor";
            this.Load += new System.EventHandler(this.NoteEditor_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Editor_MouseDown);
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox NoteTextTextBox;
        private System.Windows.Forms.TextBox NoteNameTextBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.Button MakeBoldButton;
        private System.Windows.Forms.Button MakeItalicButton;
        private System.Windows.Forms.Button MakeStrikedOutButton;
        private System.Windows.Forms.Button MakeUnderlinedButton;
        private System.Windows.Forms.Button LeftAlignButton;
        private System.Windows.Forms.Button RightAlignButton;
        private System.Windows.Forms.Button CenterAlignButton;
        private System.Windows.Forms.Label ApplicationNameLabel;
        private System.Windows.Forms.Label FontSizeLabel;
        private System.Windows.Forms.Button MakeFontBiggerButton;
        private System.Windows.Forms.Button MakeFontSmallerButton;
    }
}