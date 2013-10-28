namespace aksztofa
{
    partial class HangMan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangMan));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGame = new System.Windows.Forms.ToolStripMenuItem();
            this.quit = new System.Windows.Forms.ToolStripMenuItem();
            this.infóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.chooseCateory = new System.Windows.Forms.Label();
            this.selectBtn = new System.Windows.Forms.Button();
            this.guessLetter = new System.Windows.Forms.TextBox();
            this.guessLabel = new System.Windows.Forms.Label();
            this.sendBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wrongLt = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Aqua;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.infóToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGame,
            this.quit});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeyDisplayString = "_";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.helpToolStripMenuItem.Text = "File";
            // 
            // newGame
            // 
            this.newGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.newGame.Image = global::aksztofa.Properties.Resources.tux;
            this.newGame.Name = "newGame";
            this.newGame.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U)));
            this.newGame.Size = new System.Drawing.Size(152, 22);
            this.newGame.Text = "Új játék";
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // quit
            // 
            this.quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.quit.Image = global::aksztofa.Properties.Resources.cross;
            this.quit.Name = "quit";
            this.quit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.K)));
            this.quit.Size = new System.Drawing.Size(152, 22);
            this.quit.Text = "Kilépés";
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // infóToolStripMenuItem
            // 
            this.infóToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.infóToolStripMenuItem.Name = "infóToolStripMenuItem";
            this.infóToolStripMenuItem.ShortcutKeyDisplayString = "_";
            this.infóToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.infóToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infóToolStripMenuItem.Text = "Info";
            this.infóToolStripMenuItem.Click += new System.EventHandler(this.infóToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.ShortcutKeyDisplayString = "_";
            this.helpToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // categoryBox
            // 
            this.categoryBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(12, 54);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(157, 21);
            this.categoryBox.TabIndex = 2;
            // 
            // chooseCateory
            // 
            this.chooseCateory.AutoSize = true;
            this.chooseCateory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chooseCateory.Location = new System.Drawing.Point(12, 28);
            this.chooseCateory.Name = "chooseCateory";
            this.chooseCateory.Size = new System.Drawing.Size(128, 17);
            this.chooseCateory.TabIndex = 3;
            this.chooseCateory.Text = "Válassz kategóriát:";
            // 
            // selectBtn
            // 
            this.selectBtn.BackColor = System.Drawing.Color.Silver;
            this.selectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectBtn.ForeColor = System.Drawing.Color.Green;
            this.selectBtn.Location = new System.Drawing.Point(12, 90);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(75, 23);
            this.selectBtn.TabIndex = 4;
            this.selectBtn.Text = "Kiválaszt";
            this.selectBtn.UseVisualStyleBackColor = false;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // guessLetter
            // 
            this.guessLetter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guessLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guessLetter.ForeColor = System.Drawing.Color.Green;
            this.guessLetter.Location = new System.Drawing.Point(275, 94);
            this.guessLetter.MaxLength = 1;
            this.guessLetter.Name = "guessLetter";
            this.guessLetter.Size = new System.Drawing.Size(37, 20);
            this.guessLetter.TabIndex = 5;
            this.toolTip1.SetToolTip(this.guessLetter, "Csak a magyar ábécé betűi írhatók be, egyszerre csak 1 karakter.\r\n(a,á,b,c,d,e,é," +
                    "f,g,h,i,í,stb...)\r\n");
            // 
            // guessLabel
            // 
            this.guessLabel.AutoSize = true;
            this.guessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guessLabel.Location = new System.Drawing.Point(184, 100);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(80, 13);
            this.guessLabel.TabIndex = 6;
            this.guessLabel.Text = "Írj be egy betűt:";
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.Silver;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.ForeColor = System.Drawing.Color.Green;
            this.sendBtn.Location = new System.Drawing.Point(327, 91);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 7;
            this.sendBtn.Text = "Elküld";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::aksztofa.Properties.Resources.akasztofadefault;
            this.pictureBox1.Location = new System.Drawing.Point(126, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 282);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // wrongLt
            // 
            this.wrongLt.AutoSize = true;
            this.wrongLt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wrongLt.Location = new System.Drawing.Point(368, 91);
            this.wrongLt.Name = "wrongLt";
            this.wrongLt.Size = new System.Drawing.Size(81, 13);
            this.wrongLt.TabIndex = 8;
            this.wrongLt.Text = "Rossz betűk:";
            this.wrongLt.Visible = false;
            // 
            // HangMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(584, 436);
            this.Controls.Add(this.wrongLt);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.guessLabel);
            this.Controls.Add(this.guessLetter);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.chooseCateory);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "HangMan";
            this.Text = "Akasztófa© v1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infóToolStripMenuItem;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Label chooseCateory;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.TextBox guessLetter;
        private System.Windows.Forms.Label guessLabel;
        private System.Windows.Forms.ToolStripMenuItem newGame;
        private System.Windows.Forms.ToolStripMenuItem quit;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label wrongLt;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

