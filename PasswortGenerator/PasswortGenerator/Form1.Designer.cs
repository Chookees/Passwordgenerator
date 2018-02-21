namespace PasswortGenerator
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numlength = new System.Windows.Forms.NumericUpDown();
            this.numrandom = new System.Windows.Forms.NumericUpDown();
            this.btngenerate = new System.Windows.Forms.Button();
            this.cBsave = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cBhash = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLogFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showVersionlogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openReadmetxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softwareInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.cBboth = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numlength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numrandom)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length of Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Strength of Password:";
            this.label6.DoubleClick += new System.EventHandler(this.label6_DoubleClick);
            // 
            // numlength
            // 
            this.numlength.Location = new System.Drawing.Point(158, 35);
            this.numlength.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numlength.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numlength.Name = "numlength";
            this.numlength.Size = new System.Drawing.Size(49, 20);
            this.numlength.TabIndex = 6;
            this.numlength.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // numrandom
            // 
            this.numrandom.Location = new System.Drawing.Point(158, 61);
            this.numrandom.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numrandom.Name = "numrandom";
            this.numrandom.Size = new System.Drawing.Size(49, 20);
            this.numrandom.TabIndex = 7;
            this.numrandom.ValueChanged += new System.EventHandler(this.numrandom_ValueChanged);
            // 
            // btngenerate
            // 
            this.btngenerate.Location = new System.Drawing.Point(95, 156);
            this.btngenerate.Name = "btngenerate";
            this.btngenerate.Size = new System.Drawing.Size(75, 23);
            this.btngenerate.TabIndex = 11;
            this.btngenerate.Text = "Generate";
            this.btngenerate.UseVisualStyleBackColor = true;
            this.btngenerate.Click += new System.EventHandler(this.btngenerate_Click);
            // 
            // cBsave
            // 
            this.cBsave.AutoSize = true;
            this.cBsave.Location = new System.Drawing.Point(157, 87);
            this.cBsave.Name = "cBsave";
            this.cBsave.Size = new System.Drawing.Size(15, 14);
            this.cBsave.TabIndex = 12;
            this.cBsave.UseVisualStyleBackColor = true;
            this.cBsave.CheckedChanged += new System.EventHandler(this.cBsave_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Save Password to txt:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Deface Password in txt:";
            // 
            // cBhash
            // 
            this.cBhash.AutoSize = true;
            this.cBhash.Enabled = false;
            this.cBhash.Location = new System.Drawing.Point(157, 110);
            this.cBhash.Name = "cBhash";
            this.cBhash.Size = new System.Drawing.Size(15, 14);
            this.cBhash.TabIndex = 15;
            this.cBhash.UseVisualStyleBackColor = true;
            this.cBhash.CheckedChanged += new System.EventHandler(this.cBhash_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLogFileToolStripMenuItem,
            this.showVersionlogToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // showLogFileToolStripMenuItem
            // 
            this.showLogFileToolStripMenuItem.Name = "showLogFileToolStripMenuItem";
            this.showLogFileToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.showLogFileToolStripMenuItem.Text = "Show log file";
            this.showLogFileToolStripMenuItem.Click += new System.EventHandler(this.showLogFileToolStripMenuItem_Click);
            // 
            // showVersionlogToolStripMenuItem
            // 
            this.showVersionlogToolStripMenuItem.Name = "showVersionlogToolStripMenuItem";
            this.showVersionlogToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.showVersionlogToolStripMenuItem.Text = "Show versionlog";
            this.showVersionlogToolStripMenuItem.Click += new System.EventHandler(this.showVersionlogToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openReadmetxtToolStripMenuItem,
            this.softwareInfoToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // openReadmetxtToolStripMenuItem
            // 
            this.openReadmetxtToolStripMenuItem.Name = "openReadmetxtToolStripMenuItem";
            this.openReadmetxtToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.openReadmetxtToolStripMenuItem.Text = "Open Readme.txt";
            this.openReadmetxtToolStripMenuItem.Click += new System.EventHandler(this.openReadmetxtToolStripMenuItem_Click);
            // 
            // softwareInfoToolStripMenuItem
            // 
            this.softwareInfoToolStripMenuItem.Name = "softwareInfoToolStripMenuItem";
            this.softwareInfoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.softwareInfoToolStripMenuItem.Text = "Software Info";
            this.softwareInfoToolStripMenuItem.Click += new System.EventHandler(this.softwareInfoToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Save both:";
            this.label8.DoubleClick += new System.EventHandler(this.label8_DoubleClick);
            // 
            // cBboth
            // 
            this.cBboth.AutoSize = true;
            this.cBboth.Location = new System.Drawing.Point(157, 133);
            this.cBboth.Name = "cBboth";
            this.cBboth.Size = new System.Drawing.Size(15, 14);
            this.cBboth.TabIndex = 18;
            this.cBboth.UseVisualStyleBackColor = true;
            this.cBboth.CheckedChanged += new System.EventHandler(this.cBboth_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cBboth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cBhash);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBsave);
            this.Controls.Add(this.btngenerate);
            this.Controls.Add(this.numrandom);
            this.Controls.Add(this.numlength);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Passwort generator";
            ((System.ComponentModel.ISupportInitialize)(this.numlength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numrandom)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numlength;
        private System.Windows.Forms.NumericUpDown numrandom;
        private System.Windows.Forms.Button btngenerate;
        private System.Windows.Forms.CheckBox cBsave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cBhash;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openReadmetxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softwareInfoToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cBboth;
        private System.Windows.Forms.ToolStripMenuItem showLogFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showVersionlogToolStripMenuItem;
    }
}

