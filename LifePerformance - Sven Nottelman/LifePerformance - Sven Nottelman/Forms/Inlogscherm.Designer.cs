namespace LifePerformance___Sven_Nottelman
{
    partial class FormInloggen
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
            this.gbInloggen = new System.Windows.Forms.GroupBox();
            this.btnInloggen = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblSucces = new System.Windows.Forms.Label();
            this.gbInloggen.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInloggen
            // 
            this.gbInloggen.Controls.Add(this.btnInloggen);
            this.gbInloggen.Controls.Add(this.lblPassword);
            this.gbInloggen.Controls.Add(this.lblUser);
            this.gbInloggen.Controls.Add(this.tbPassword);
            this.gbInloggen.Controls.Add(this.tbUsername);
            this.gbInloggen.Location = new System.Drawing.Point(12, 12);
            this.gbInloggen.Name = "gbInloggen";
            this.gbInloggen.Size = new System.Drawing.Size(260, 101);
            this.gbInloggen.TabIndex = 0;
            this.gbInloggen.TabStop = false;
            this.gbInloggen.Text = "Inloggen";
            // 
            // btnInloggen
            // 
            this.btnInloggen.Location = new System.Drawing.Point(9, 65);
            this.btnInloggen.Name = "btnInloggen";
            this.btnInloggen.Size = new System.Drawing.Size(245, 30);
            this.btnInloggen.TabIndex = 4;
            this.btnInloggen.Text = "Inloggen!";
            this.btnInloggen.UseVisualStyleBackColor = true;
            this.btnInloggen.Click += new System.EventHandler(this.btnInloggen_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 42);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(68, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Wachtwoord";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(6, 16);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(84, 13);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Gebruikersnaam";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(96, 39);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.Size = new System.Drawing.Size(158, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(96, 13);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(158, 20);
            this.tbUsername.TabIndex = 0;
            // 
            // lblSucces
            // 
            this.lblSucces.AutoSize = true;
            this.lblSucces.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucces.Location = new System.Drawing.Point(31, 116);
            this.lblSucces.Name = "lblSucces";
            this.lblSucces.Size = new System.Drawing.Size(224, 25);
            this.lblSucces.TabIndex = 1;
            this.lblSucces.Text = "Succesvol ingelogd!";
            // 
            // FormInloggen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 156);
            this.Controls.Add(this.lblSucces);
            this.Controls.Add(this.gbInloggen);
            this.Name = "FormInloggen";
            this.Text = "Inlogscherm";
            this.gbInloggen.ResumeLayout(false);
            this.gbInloggen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInloggen;
        private System.Windows.Forms.Button btnInloggen;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblSucces;
    }
}

