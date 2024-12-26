namespace basicLoginRegister
{
    partial class ChangeProfileForm
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
            this.emaillable = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.EditEmail = new System.Windows.Forms.TextBox();
            this.EditSurname = new System.Windows.Forms.TextBox();
            this.EditName = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emaillable
            // 
            this.emaillable.AutoSize = true;
            this.emaillable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillable.Location = new System.Drawing.Point(235, 274);
            this.emaillable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emaillable.Name = "emaillable";
            this.emaillable.Size = new System.Drawing.Size(65, 25);
            this.emaillable.TabIndex = 17;
            this.emaillable.Text = "Email";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surname.Location = new System.Drawing.Point(202, 214);
            this.Surname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(99, 25);
            this.Surname.TabIndex = 16;
            this.Surname.Text = "Surname";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(232, 157);
            this.FirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(68, 25);
            this.FirstName.TabIndex = 15;
            this.FirstName.Text = "Name";
            // 
            // EditEmail
            // 
            this.EditEmail.Location = new System.Drawing.Point(327, 268);
            this.EditEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditEmail.Name = "EditEmail";
            this.EditEmail.Size = new System.Drawing.Size(271, 26);
            this.EditEmail.TabIndex = 14;
            // 
            // EditSurname
            // 
            this.EditSurname.Location = new System.Drawing.Point(327, 208);
            this.EditSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditSurname.Name = "EditSurname";
            this.EditSurname.Size = new System.Drawing.Size(271, 26);
            this.EditSurname.TabIndex = 13;
            // 
            // EditName
            // 
            this.EditName.AcceptsReturn = true;
            this.EditName.Location = new System.Drawing.Point(327, 151);
            this.EditName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditName.Name = "EditName";
            this.EditName.Size = new System.Drawing.Size(271, 26);
            this.EditName.TabIndex = 12;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(483, 325);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(114, 32);
            this.save.TabIndex = 18;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // ChangeProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save);
            this.Controls.Add(this.emaillable);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.EditEmail);
            this.Controls.Add(this.EditSurname);
            this.Controls.Add(this.EditName);
            this.Name = "ChangeProfileForm";
            this.Text = "ChangeProfileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emaillable;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Button save;
        public System.Windows.Forms.TextBox EditEmail;
        public System.Windows.Forms.TextBox EditSurname;
        public System.Windows.Forms.TextBox EditName;
    }
}