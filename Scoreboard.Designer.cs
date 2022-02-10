namespace BracketEdit
{
    partial class Scoreboard
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
            this.P1Name = new System.Windows.Forms.TextBox();
            this.P1Score = new System.Windows.Forms.TextBox();
            this.P2Score = new System.Windows.Forms.TextBox();
            this.P2Name = new System.Windows.Forms.TextBox();
            this.BracketLocation = new System.Windows.Forms.TextBox();
            this.P1ScoreMinus = new System.Windows.Forms.Button();
            this.P1ScoreAdd = new System.Windows.Forms.Button();
            this.SwitchButton = new System.Windows.Forms.Button();
            this.P1GroupBox = new System.Windows.Forms.GroupBox();
            this.P2GroupBox = new System.Windows.Forms.GroupBox();
            this.P2ScoreMinus = new System.Windows.Forms.Button();
            this.P2ScoreAdd = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FolderLocation = new System.Windows.Forms.TextBox();
            this.GetFolderLocation = new System.Windows.Forms.Button();
            this.SaveAll = new System.Windows.Forms.Button();
            this.P1GroupBox.SuspendLayout();
            this.P2GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // P1Name
            // 
            this.P1Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.P1Name.Location = new System.Drawing.Point(26, 26);
            this.P1Name.Name = "P1Name";
            this.P1Name.Size = new System.Drawing.Size(150, 25);
            this.P1Name.TabIndex = 0;
            this.P1Name.Text = "P1 Name";
            // 
            // P1Score
            // 
            this.P1Score.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.P1Score.Font = new System.Drawing.Font("Noto Sans SemCond SemBd", 48F, System.Drawing.FontStyle.Bold);
            this.P1Score.ForeColor = System.Drawing.SystemColors.WindowText;
            this.P1Score.Location = new System.Drawing.Point(51, 57);
            this.P1Score.MaxLength = 1;
            this.P1Score.Name = "P1Score";
            this.P1Score.Size = new System.Drawing.Size(100, 95);
            this.P1Score.TabIndex = 1;
            this.P1Score.Text = "0";
            this.P1Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.P1Score.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.P1Score_KeyPress);
            // 
            // P2Score
            // 
            this.P2Score.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.P2Score.Font = new System.Drawing.Font("Noto Sans SemCond SemBd", 48F, System.Drawing.FontStyle.Bold);
            this.P2Score.Location = new System.Drawing.Point(54, 57);
            this.P2Score.MaxLength = 1;
            this.P2Score.Name = "P2Score";
            this.P2Score.Size = new System.Drawing.Size(100, 95);
            this.P2Score.TabIndex = 2;
            this.P2Score.Text = "0";
            this.P2Score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.P2Score.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.P2Score_KeyPress);
            // 
            // P2Name
            // 
            this.P2Name.Location = new System.Drawing.Point(30, 26);
            this.P2Name.Name = "P2Name";
            this.P2Name.Size = new System.Drawing.Size(150, 25);
            this.P2Name.TabIndex = 3;
            this.P2Name.Text = "P2 Name";
            // 
            // BracketLocation
            // 
            this.BracketLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BracketLocation.Location = new System.Drawing.Point(144, 12);
            this.BracketLocation.Name = "BracketLocation";
            this.BracketLocation.Size = new System.Drawing.Size(156, 25);
            this.BracketLocation.TabIndex = 4;
            this.BracketLocation.Text = "Bracket Location";
            this.BracketLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BracketLocation.TextChanged += new System.EventHandler(this.BracketLocation_TextChanged);
            // 
            // P1ScoreMinus
            // 
            this.P1ScoreMinus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.P1ScoreMinus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.P1ScoreMinus.Location = new System.Drawing.Point(20, 90);
            this.P1ScoreMinus.Name = "P1ScoreMinus";
            this.P1ScoreMinus.Size = new System.Drawing.Size(25, 23);
            this.P1ScoreMinus.TabIndex = 5;
            this.P1ScoreMinus.Text = "-";
            this.P1ScoreMinus.UseVisualStyleBackColor = true;
            this.P1ScoreMinus.Click += new System.EventHandler(this.P1ScoreMinus_Click);
            // 
            // P1ScoreAdd
            // 
            this.P1ScoreAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.P1ScoreAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.P1ScoreAdd.Location = new System.Drawing.Point(157, 90);
            this.P1ScoreAdd.Name = "P1ScoreAdd";
            this.P1ScoreAdd.Size = new System.Drawing.Size(25, 23);
            this.P1ScoreAdd.TabIndex = 6;
            this.P1ScoreAdd.Text = "+";
            this.P1ScoreAdd.UseVisualStyleBackColor = true;
            this.P1ScoreAdd.Click += new System.EventHandler(this.P1ScoreAdd_Click);
            // 
            // SwitchButton
            // 
            this.SwitchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SwitchButton.Location = new System.Drawing.Point(103, 228);
            this.SwitchButton.Name = "SwitchButton";
            this.SwitchButton.Size = new System.Drawing.Size(75, 23);
            this.SwitchButton.TabIndex = 9;
            this.SwitchButton.Text = "Switch";
            this.SwitchButton.UseVisualStyleBackColor = true;
            this.SwitchButton.Click += new System.EventHandler(this.SwitchButton_Click);
            // 
            // P1GroupBox
            // 
            this.P1GroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.P1GroupBox.Controls.Add(this.P1Name);
            this.P1GroupBox.Controls.Add(this.P1Score);
            this.P1GroupBox.Controls.Add(this.P1ScoreMinus);
            this.P1GroupBox.Controls.Add(this.P1ScoreAdd);
            this.P1GroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.P1GroupBox.Location = new System.Drawing.Point(16, 43);
            this.P1GroupBox.Name = "P1GroupBox";
            this.P1GroupBox.Size = new System.Drawing.Size(203, 179);
            this.P1GroupBox.TabIndex = 10;
            this.P1GroupBox.TabStop = false;
            this.P1GroupBox.Text = "Player 1";
            // 
            // P2GroupBox
            // 
            this.P2GroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.P2GroupBox.Controls.Add(this.P2ScoreMinus);
            this.P2GroupBox.Controls.Add(this.P2Name);
            this.P2GroupBox.Controls.Add(this.P2Score);
            this.P2GroupBox.Controls.Add(this.P2ScoreAdd);
            this.P2GroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.P2GroupBox.Location = new System.Drawing.Point(225, 43);
            this.P2GroupBox.Name = "P2GroupBox";
            this.P2GroupBox.Size = new System.Drawing.Size(203, 179);
            this.P2GroupBox.TabIndex = 11;
            this.P2GroupBox.TabStop = false;
            this.P2GroupBox.Text = "Player 2";
            // 
            // P2ScoreMinus
            // 
            this.P2ScoreMinus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.P2ScoreMinus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.P2ScoreMinus.Location = new System.Drawing.Point(20, 93);
            this.P2ScoreMinus.Name = "P2ScoreMinus";
            this.P2ScoreMinus.Size = new System.Drawing.Size(25, 23);
            this.P2ScoreMinus.TabIndex = 7;
            this.P2ScoreMinus.Text = "-";
            this.P2ScoreMinus.UseVisualStyleBackColor = true;
            this.P2ScoreMinus.Click += new System.EventHandler(this.P2ScoreMinus_Click);
            // 
            // P2ScoreAdd
            // 
            this.P2ScoreAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.P2ScoreAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.P2ScoreAdd.Location = new System.Drawing.Point(157, 93);
            this.P2ScoreAdd.Name = "P2ScoreAdd";
            this.P2ScoreAdd.Size = new System.Drawing.Size(25, 23);
            this.P2ScoreAdd.TabIndex = 8;
            this.P2ScoreAdd.Text = "+";
            this.P2ScoreAdd.UseVisualStyleBackColor = true;
            this.P2ScoreAdd.Click += new System.EventHandler(this.P2ScoreAdd_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearButton.Location = new System.Drawing.Point(185, 228);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.label1.Location = new System.Drawing.Point(7, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Folder Location:";
            // 
            // FolderLocation
            // 
            this.FolderLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FolderLocation.Location = new System.Drawing.Point(138, 267);
            this.FolderLocation.Name = "FolderLocation";
            this.FolderLocation.ReadOnly = true;
            this.FolderLocation.Size = new System.Drawing.Size(300, 25);
            this.FolderLocation.TabIndex = 14;
            // 
            // GetFolderLocation
            // 
            this.GetFolderLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GetFolderLocation.Location = new System.Drawing.Point(109, 267);
            this.GetFolderLocation.Name = "GetFolderLocation";
            this.GetFolderLocation.Size = new System.Drawing.Size(26, 25);
            this.GetFolderLocation.TabIndex = 95;
            this.GetFolderLocation.Text = "...";
            this.GetFolderLocation.UseVisualStyleBackColor = true;
            this.GetFolderLocation.Click += new System.EventHandler(this.GetFolderLocation_Click);
            // 
            // SaveAll
            // 
            this.SaveAll.Location = new System.Drawing.Point(266, 228);
            this.SaveAll.Name = "SaveAll";
            this.SaveAll.Size = new System.Drawing.Size(75, 23);
            this.SaveAll.TabIndex = 96;
            this.SaveAll.Text = "Save All";
            this.SaveAll.UseVisualStyleBackColor = true;
            this.SaveAll.Click += new System.EventHandler(this.SaveAll_Click);
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(444, 304);
            this.Controls.Add(this.SaveAll);
            this.Controls.Add(this.GetFolderLocation);
            this.Controls.Add(this.FolderLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.P2GroupBox);
            this.Controls.Add(this.P1GroupBox);
            this.Controls.Add(this.SwitchButton);
            this.Controls.Add(this.BracketLocation);
            this.Font = new System.Drawing.Font("Noto Sans SemCond", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Scoreboard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Scoreboard";
            this.Load += new System.EventHandler(this.Scoreboard_Load);
            this.P1GroupBox.ResumeLayout(false);
            this.P1GroupBox.PerformLayout();
            this.P2GroupBox.ResumeLayout(false);
            this.P2GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox P1Name;
        private System.Windows.Forms.TextBox P1Score;
        private System.Windows.Forms.TextBox P2Score;
        private System.Windows.Forms.TextBox P2Name;
        private System.Windows.Forms.TextBox BracketLocation;
        private System.Windows.Forms.Button P1ScoreMinus;
        private System.Windows.Forms.Button P1ScoreAdd;
        private System.Windows.Forms.Button SwitchButton;
        private System.Windows.Forms.GroupBox P1GroupBox;
        private System.Windows.Forms.GroupBox P2GroupBox;
        private System.Windows.Forms.Button P2ScoreMinus;
        private System.Windows.Forms.Button P2ScoreAdd;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FolderLocation;
        private System.Windows.Forms.Button GetFolderLocation;
        private System.Windows.Forms.Button SaveAll;
    }
}