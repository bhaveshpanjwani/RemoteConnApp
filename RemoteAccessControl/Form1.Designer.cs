namespace RemoteAccessControl
{
    partial class RemoteDesktopApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteDesktopApp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textYourIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.txtClientIP = new System.Windows.Forms.TextBox();
            this.ClientAddress = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdp = new AxMSTSCLib.AxMsRdpClient9NotSafeForScripting();
            this.ConnectNow = new MetroFramework.Controls.MetroButton();
            this.DisconnectNow = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.textYourIP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(23, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 102);
            this.panel1.TabIndex = 0;
            // 
            // textYourIP
            // 
            this.textYourIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textYourIP.Location = new System.Drawing.Point(30, 55);
            this.textYourIP.Name = "textYourIP";
            this.textYourIP.Size = new System.Drawing.Size(200, 26);
            this.textYourIP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your IP Address";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(21, 102);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Controls.Add(this.Password);
            this.panel3.Controls.Add(this.txtUserName);
            this.panel3.Controls.Add(this.UserName);
            this.panel3.Controls.Add(this.txtClientIP);
            this.panel3.Controls.Add(this.ClientAddress);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(356, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(674, 102);
            this.panel3.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(451, 55);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 26);
            this.txtPassword.TabIndex = 6;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(448, 20);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(67, 16);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(236, 55);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 26);
            this.txtUserName.TabIndex = 4;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(233, 20);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(73, 16);
            this.UserName.TabIndex = 3;
            this.UserName.Text = "UserName";
            // 
            // txtClientIP
            // 
            this.txtClientIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientIP.Location = new System.Drawing.Point(30, 55);
            this.txtClientIP.Name = "txtClientIP";
            this.txtClientIP.Size = new System.Drawing.Size(200, 26);
            this.txtClientIP.TabIndex = 2;
            // 
            // ClientAddress
            // 
            this.ClientAddress.AutoSize = true;
            this.ClientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientAddress.Location = new System.Drawing.Point(27, 20);
            this.ClientAddress.Name = "ClientAddress";
            this.ClientAddress.Size = new System.Drawing.Size(109, 16);
            this.ClientAddress.TabIndex = 1;
            this.ClientAddress.Text = "Client IP Address";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(21, 102);
            this.panel4.TabIndex = 0;
            // 
            // rdp
            // 
            this.rdp.Enabled = true;
            this.rdp.Location = new System.Drawing.Point(21, 178);
            this.rdp.Name = "rdp";
            this.rdp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("rdp.OcxState")));
            this.rdp.Size = new System.Drawing.Size(1256, 549);
            this.rdp.TabIndex = 2;
            // 
            // ConnectNow
            // 
            this.ConnectNow.Location = new System.Drawing.Point(1054, 63);
            this.ConnectNow.Name = "ConnectNow";
            this.ConnectNow.Size = new System.Drawing.Size(110, 102);
            this.ConnectNow.TabIndex = 3;
            this.ConnectNow.Text = "ConnectNow";
            this.ConnectNow.UseSelectable = true;
            this.ConnectNow.Click += new System.EventHandler(this.ConnectNow_Click);
            // 
            // DisconnectNow
            // 
            this.DisconnectNow.Location = new System.Drawing.Point(1170, 63);
            this.DisconnectNow.Name = "DisconnectNow";
            this.DisconnectNow.Size = new System.Drawing.Size(110, 102);
            this.DisconnectNow.TabIndex = 4;
            this.DisconnectNow.Text = "DisconnectNow";
            this.DisconnectNow.UseSelectable = true;
            this.DisconnectNow.Click += new System.EventHandler(this.DisconnectNow_Click);
            // 
            // RemoteDesktopApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 750);
            this.Controls.Add(this.DisconnectNow);
            this.Controls.Add(this.ConnectNow);
            this.Controls.Add(this.rdp);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "RemoteDesktopApp";
            this.Text = "Remote Desktop Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textYourIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtClientIP;
        private System.Windows.Forms.Label ClientAddress;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label UserName;
        private AxMSTSCLib.AxMsRdpClient9NotSafeForScripting rdp;
        private MetroFramework.Controls.MetroButton ConnectNow;
        private MetroFramework.Controls.MetroButton DisconnectNow;
    }
}

