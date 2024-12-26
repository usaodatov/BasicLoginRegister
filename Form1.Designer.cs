namespace basicLoginRegister
{
    partial class Access
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
            this.newRegister = new System.Windows.Forms.Button();
            this.logIn = new System.Windows.Forms.Button();
            this.labelpassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.labeluser = new System.Windows.Forms.Label();
            this.PlzLogIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newRegister
            // 
            this.newRegister.AutoSize = true;
            this.newRegister.Location = new System.Drawing.Point(461, 387);
            this.newRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newRegister.Name = "newRegister";
            this.newRegister.Size = new System.Drawing.Size(160, 47);
            this.newRegister.TabIndex = 11;
            this.newRegister.Text = "Register";
            this.newRegister.UseVisualStyleBackColor = true;
            this.newRegister.Click += new System.EventHandler(this.NewRegister_Click);
            // 
            // logIn
            // 
            this.logIn.AutoSize = true;
            this.logIn.Location = new System.Drawing.Point(648, 387);
            this.logIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(160, 47);
            this.logIn.TabIndex = 10;
            this.logIn.Text = "Log in";
            this.logIn.UseVisualStyleBackColor = true;
            this.logIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // labelpassword
            // 
            this.labelpassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassword.Location = new System.Drawing.Point(320, 319);
            this.labelpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(120, 29);
            this.labelpassword.TabIndex = 9;
            this.labelpassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(447, 322);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(376, 26);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.TextChanged += new System.EventHandler(this.passWord_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsername.Location = new System.Drawing.Point(447, 247);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(376, 26);
            this.txtUsername.TabIndex = 7;
            this.txtUsername.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // labeluser
            // 
            this.labeluser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labeluser.AutoSize = true;
            this.labeluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeluser.Location = new System.Drawing.Point(305, 244);
            this.labeluser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(135, 29);
            this.labeluser.TabIndex = 6;
            this.labeluser.Text = "User Name";
            // 
            // PlzLogIn
            // 
            this.PlzLogIn.AutoSize = true;
            this.PlzLogIn.Font = new System.Drawing.Font("Bell MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlzLogIn.Location = new System.Drawing.Point(549, 138);
            this.PlzLogIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlzLogIn.Name = "PlzLogIn";
            this.PlzLogIn.Size = new System.Drawing.Size(164, 56);
            this.PlzLogIn.TabIndex = 13;
            this.PlzLogIn.Text = "Log In";
            // 
            // Access
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 611);
            this.Controls.Add(this.PlzLogIn);
            this.Controls.Add(this.newRegister);
            this.Controls.Add(this.logIn);
            this.Controls.Add(this.labelpassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.labeluser);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Access";
            this.Text = "Access";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newRegister;
        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label labeluser;
        private System.Windows.Forms.Label PlzLogIn;
    }
}

