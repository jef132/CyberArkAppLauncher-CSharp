namespace CyberarkAppLauncher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.MFATokenBox = new System.Windows.Forms.TextBox();
            this.UserNamelbl = new System.Windows.Forms.Label();
            this.MFATokenlbl = new System.Windows.Forms.Label();
            this.Datacenterbox = new System.Windows.Forms.ComboBox();
            this.Datacenterlbl = new System.Windows.Forms.Label();
            this.Applicationlbl = new System.Windows.Forms.Label();
            this.ApplicationBox = new System.Windows.Forms.ComboBox();
            this.LaunchAppBtn = new System.Windows.Forms.Button();
            this.Statuslbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(121, 33);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(121, 20);
            this.UsernameBox.TabIndex = 0;
            this.UsernameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MFATokenBox
            // 
            this.MFATokenBox.Location = new System.Drawing.Point(121, 65);
            this.MFATokenBox.Name = "MFATokenBox";
            this.MFATokenBox.Size = new System.Drawing.Size(121, 20);
            this.MFATokenBox.TabIndex = 1;
            this.MFATokenBox.UseSystemPasswordChar = true;
            this.MFATokenBox.TextChanged += new System.EventHandler(this.MFATokenBox_TextChanged);
            // 
            // UserNamelbl
            // 
            this.UserNamelbl.AutoSize = true;
            this.UserNamelbl.Location = new System.Drawing.Point(51, 33);
            this.UserNamelbl.Name = "UserNamelbl";
            this.UserNamelbl.Size = new System.Drawing.Size(57, 13);
            this.UserNamelbl.TabIndex = 2;
            this.UserNamelbl.Text = "UserName";
            this.UserNamelbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // MFATokenlbl
            // 
            this.MFATokenlbl.AutoSize = true;
            this.MFATokenlbl.Location = new System.Drawing.Point(52, 68);
            this.MFATokenlbl.Name = "MFATokenlbl";
            this.MFATokenlbl.Size = new System.Drawing.Size(63, 13);
            this.MFATokenlbl.TabIndex = 3;
            this.MFATokenlbl.Text = "MFA Token";
            this.MFATokenlbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // Datacenterbox
            // 
            this.Datacenterbox.FormattingEnabled = true;
            this.Datacenterbox.Items.AddRange(new object[] {
            "DataCenter1",
            "DataCenter2",
            "DataCenter3",
            "DataCenter4"});
            this.Datacenterbox.Location = new System.Drawing.Point(121, 101);
            this.Datacenterbox.Name = "Datacenterbox";
            this.Datacenterbox.Size = new System.Drawing.Size(121, 21);
            this.Datacenterbox.TabIndex = 4;
            this.Datacenterbox.Text = "Select Data Center";
            // 
            // Datacenterlbl
            // 
            this.Datacenterlbl.AutoSize = true;
            this.Datacenterlbl.Location = new System.Drawing.Point(52, 104);
            this.Datacenterlbl.Name = "Datacenterlbl";
            this.Datacenterlbl.Size = new System.Drawing.Size(64, 13);
            this.Datacenterlbl.TabIndex = 5;
            this.Datacenterlbl.Text = "Data Center";
            // 
            // Applicationlbl
            // 
            this.Applicationlbl.AutoSize = true;
            this.Applicationlbl.Location = new System.Drawing.Point(51, 146);
            this.Applicationlbl.Name = "Applicationlbl";
            this.Applicationlbl.Size = new System.Drawing.Size(59, 13);
            this.Applicationlbl.TabIndex = 7;
            this.Applicationlbl.Text = "Application";
            // 
            // ApplicationBox
            // 
            this.ApplicationBox.FormattingEnabled = true;
            this.ApplicationBox.Items.AddRange(new object[] {
            "Chrome",
            "InternetExplorer",
            "Firefox"});
            this.ApplicationBox.Location = new System.Drawing.Point(121, 143);
            this.ApplicationBox.Name = "ApplicationBox";
            this.ApplicationBox.Size = new System.Drawing.Size(121, 21);
            this.ApplicationBox.TabIndex = 6;
            this.ApplicationBox.Text = "Select Application";
            // 
            // LaunchAppBtn
            // 
            this.LaunchAppBtn.Location = new System.Drawing.Point(121, 179);
            this.LaunchAppBtn.Name = "LaunchAppBtn";
            this.LaunchAppBtn.Size = new System.Drawing.Size(121, 23);
            this.LaunchAppBtn.TabIndex = 8;
            this.LaunchAppBtn.Text = "Launch Application";
            this.LaunchAppBtn.UseVisualStyleBackColor = true;
            this.LaunchAppBtn.Click += new System.EventHandler(this.LaunchAppBtn_Click);
            // 
            // Statuslbl
            // 
            this.Statuslbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Statuslbl.Location = new System.Drawing.Point(12, 226);
            this.Statuslbl.Name = "Statuslbl";
            this.Statuslbl.Size = new System.Drawing.Size(310, 68);
            this.Statuslbl.TabIndex = 9;
            this.Statuslbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 303);
            this.Controls.Add(this.Statuslbl);
            this.Controls.Add(this.LaunchAppBtn);
            this.Controls.Add(this.Applicationlbl);
            this.Controls.Add(this.ApplicationBox);
            this.Controls.Add(this.Datacenterlbl);
            this.Controls.Add(this.Datacenterbox);
            this.Controls.Add(this.MFATokenlbl);
            this.Controls.Add(this.UserNamelbl);
            this.Controls.Add(this.MFATokenBox);
            this.Controls.Add(this.UsernameBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CyberArk App Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox MFATokenBox;
        private System.Windows.Forms.Label UserNamelbl;
        private System.Windows.Forms.Label MFATokenlbl;
        private System.Windows.Forms.ComboBox Datacenterbox;
        private System.Windows.Forms.Label Datacenterlbl;
        private System.Windows.Forms.Label Applicationlbl;
        private System.Windows.Forms.ComboBox ApplicationBox;
        private System.Windows.Forms.Button LaunchAppBtn;
        public System.Windows.Forms.Label Statuslbl;
    }
}

