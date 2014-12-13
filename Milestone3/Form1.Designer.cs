namespace Milestone3
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MyGButton = new System.Windows.Forms.Button();
            this.ManageGButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.MyGSearch = new System.Windows.Forms.TextBox();
            this.MyGSearchLabel = new System.Windows.Forms.Label();
            this.Genre1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GenreLabel1 = new System.Windows.Forms.Label();
            this.GenreLabel2 = new System.Windows.Forms.Label();
            this.GenreLabel3 = new System.Windows.Forms.Label();
            this.MyGPanel = new System.Windows.Forms.Panel();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.DisplayPanel = new System.Windows.Forms.Panel();
            this.CSchemePanel = new System.Windows.Forms.Panel();
            this.SoundPanel = new System.Windows.Forms.Panel();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.SoundButton = new System.Windows.Forms.Button();
            this.CSchemeButton = new System.Windows.Forms.Button();
            this.ManageGPanel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Genre1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MyGPanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.DisplayPanel.SuspendLayout();
            this.CSchemePanel.SuspendLayout();
            this.SoundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyGButton
            // 
            this.MyGButton.Location = new System.Drawing.Point(12, 12);
            this.MyGButton.Name = "MyGButton";
            this.MyGButton.Size = new System.Drawing.Size(170, 43);
            this.MyGButton.TabIndex = 0;
            this.MyGButton.Text = "My Games";
            this.MyGButton.UseVisualStyleBackColor = true;
            this.MyGButton.Click += new System.EventHandler(this.MyGButton_Click);
            // 
            // ManageGButton
            // 
            this.ManageGButton.Location = new System.Drawing.Point(242, 12);
            this.ManageGButton.Name = "ManageGButton";
            this.ManageGButton.Size = new System.Drawing.Size(177, 43);
            this.ManageGButton.TabIndex = 1;
            this.ManageGButton.Text = "Manage Games";
            this.ManageGButton.UseVisualStyleBackColor = true;
            this.ManageGButton.Click += new System.EventHandler(this.ManageGButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(489, 12);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(188, 43);
            this.SettingsButton.TabIndex = 2;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // MyGSearch
            // 
            this.MyGSearch.Location = new System.Drawing.Point(71, 645);
            this.MyGSearch.Name = "MyGSearch";
            this.MyGSearch.Size = new System.Drawing.Size(415, 20);
            this.MyGSearch.TabIndex = 0;
            // 
            // MyGSearchLabel
            // 
            this.MyGSearchLabel.AutoSize = true;
            this.MyGSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyGSearchLabel.Location = new System.Drawing.Point(9, 644);
            this.MyGSearchLabel.Name = "MyGSearchLabel";
            this.MyGSearchLabel.Size = new System.Drawing.Size(66, 18);
            this.MyGSearchLabel.TabIndex = 4;
            this.MyGSearchLabel.Text = "Search:";
            // 
            // Genre1
            // 
            this.Genre1.AutoScroll = true;
            this.Genre1.BackColor = System.Drawing.SystemColors.Control;
            this.Genre1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Genre1.Controls.Add(this.pictureBox1);
            this.Genre1.Location = new System.Drawing.Point(18, 45);
            this.Genre1.Name = "Genre1";
            this.Genre1.Size = new System.Drawing.Size(1126, 162);
            this.Genre1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 109);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(18, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 148);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(18, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1126, 148);
            this.panel2.TabIndex = 3;
            // 
            // GenreLabel1
            // 
            this.GenreLabel1.AutoSize = true;
            this.GenreLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreLabel1.Location = new System.Drawing.Point(13, 17);
            this.GenreLabel1.Name = "GenreLabel1";
            this.GenreLabel1.Size = new System.Drawing.Size(77, 25);
            this.GenreLabel1.TabIndex = 4;
            this.GenreLabel1.Text = "Genre1";
            // 
            // GenreLabel2
            // 
            this.GenreLabel2.AutoSize = true;
            this.GenreLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreLabel2.Location = new System.Drawing.Point(13, 220);
            this.GenreLabel2.Name = "GenreLabel2";
            this.GenreLabel2.Size = new System.Drawing.Size(77, 25);
            this.GenreLabel2.TabIndex = 5;
            this.GenreLabel2.Text = "Genre2";
            // 
            // GenreLabel3
            // 
            this.GenreLabel3.AutoSize = true;
            this.GenreLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreLabel3.Location = new System.Drawing.Point(13, 429);
            this.GenreLabel3.Name = "GenreLabel3";
            this.GenreLabel3.Size = new System.Drawing.Size(77, 25);
            this.GenreLabel3.TabIndex = 6;
            this.GenreLabel3.Text = "Genre3";
            // 
            // MyGPanel
            // 
            this.MyGPanel.AutoScroll = true;
            this.MyGPanel.AutoScrollMinSize = new System.Drawing.Size(0, 650);
            this.MyGPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MyGPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MyGPanel.Controls.Add(this.GenreLabel3);
            this.MyGPanel.Controls.Add(this.GenreLabel2);
            this.MyGPanel.Controls.Add(this.GenreLabel1);
            this.MyGPanel.Controls.Add(this.panel2);
            this.MyGPanel.Controls.Add(this.panel1);
            this.MyGPanel.Controls.Add(this.Genre1);
            this.MyGPanel.Location = new System.Drawing.Point(0, 60);
            this.MyGPanel.Name = "MyGPanel";
            this.MyGPanel.Size = new System.Drawing.Size(1180, 578);
            this.MyGPanel.TabIndex = 3;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.SettingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SettingsPanel.Controls.Add(this.SoundPanel);
            this.SettingsPanel.Controls.Add(this.DisplayButton);
            this.SettingsPanel.Controls.Add(this.SoundButton);
            this.SettingsPanel.Controls.Add(this.CSchemeButton);
            this.SettingsPanel.Controls.Add(this.DisplayPanel);
            this.SettingsPanel.Controls.Add(this.CSchemePanel);
            this.SettingsPanel.Location = new System.Drawing.Point(0, 60);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(1180, 620);
            this.SettingsPanel.TabIndex = 5;
            this.SettingsPanel.VisibleChanged += new System.EventHandler(this.SettingsPanel_VisibleChanged);
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayPanel.Controls.Add(this.button1);
            this.DisplayPanel.Location = new System.Drawing.Point(350, 60);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(780, 450);
            this.DisplayPanel.TabIndex = 5;
            // 
            // CSchemePanel
            // 
            this.CSchemePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CSchemePanel.Controls.Add(this.button2);
            this.CSchemePanel.Location = new System.Drawing.Point(350, 60);
            this.CSchemePanel.Name = "CSchemePanel";
            this.CSchemePanel.Size = new System.Drawing.Size(780, 450);
            this.CSchemePanel.TabIndex = 3;
            // 
            // SoundPanel
            // 
            this.SoundPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SoundPanel.Controls.Add(this.button3);
            this.SoundPanel.Location = new System.Drawing.Point(350, 60);
            this.SoundPanel.Name = "SoundPanel";
            this.SoundPanel.Size = new System.Drawing.Size(780, 450);
            this.SoundPanel.TabIndex = 4;
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(41, 239);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(264, 51);
            this.DisplayButton.TabIndex = 2;
            this.DisplayButton.Text = "Display Size";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // SoundButton
            // 
            this.SoundButton.Location = new System.Drawing.Point(41, 153);
            this.SoundButton.Name = "SoundButton";
            this.SoundButton.Size = new System.Drawing.Size(264, 51);
            this.SoundButton.TabIndex = 1;
            this.SoundButton.Text = "Sound Options";
            this.SoundButton.UseVisualStyleBackColor = true;
            this.SoundButton.Click += new System.EventHandler(this.SoundButton_Click);
            // 
            // CSchemeButton
            // 
            this.CSchemeButton.Location = new System.Drawing.Point(40, 60);
            this.CSchemeButton.Name = "CSchemeButton";
            this.CSchemeButton.Size = new System.Drawing.Size(264, 51);
            this.CSchemeButton.TabIndex = 0;
            this.CSchemeButton.Text = "Colour Scheme";
            this.CSchemeButton.UseVisualStyleBackColor = true;
            this.CSchemeButton.Click += new System.EventHandler(this.CSchemeButton_Click);
            // 
            // ManageGPanel
            // 
            this.ManageGPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ManageGPanel.Location = new System.Drawing.Point(0, 60);
            this.ManageGPanel.Name = "ManageGPanel";
            this.ManageGPanel.Size = new System.Drawing.Size(1180, 620);
            this.ManageGPanel.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1177, 671);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.ManageGButton);
            this.Controls.Add(this.MyGButton);
            this.Controls.Add(this.MyGSearchLabel);
            this.Controls.Add(this.MyGSearch);
            this.Controls.Add(this.MyGPanel);
            this.Controls.Add(this.ManageGPanel);
            this.Name = "MainWindow";
            this.Text = "Ice";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Genre1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MyGPanel.ResumeLayout(false);
            this.MyGPanel.PerformLayout();
            this.SettingsPanel.ResumeLayout(false);
            this.DisplayPanel.ResumeLayout(false);
            this.CSchemePanel.ResumeLayout(false);
            this.SoundPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MyGButton;
        private System.Windows.Forms.Button ManageGButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.TextBox MyGSearch;
        private System.Windows.Forms.Label MyGSearchLabel;
        private System.Windows.Forms.Panel Genre1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label GenreLabel1;
        private System.Windows.Forms.Label GenreLabel2;
        private System.Windows.Forms.Label GenreLabel3;
        private System.Windows.Forms.Panel MyGPanel;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Panel ManageGPanel;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Button SoundButton;
        private System.Windows.Forms.Button CSchemeButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel DisplayPanel;
        private System.Windows.Forms.Panel CSchemePanel;
        private System.Windows.Forms.Panel SoundPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

