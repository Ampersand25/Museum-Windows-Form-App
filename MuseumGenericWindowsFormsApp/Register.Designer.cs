namespace WindowsFormsApp1
{
    partial class Register
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
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.backToLoginLbl = new System.Windows.Forms.Label();
            this.haveAccountLbl = new System.Windows.Forms.Label();
            this.clearFieldsBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.signUpLbl = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.confirmPasswordTxt = new System.Windows.Forms.TextBox();
            this.confirmPasswordLbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // emailTxt
            // 
            this.emailTxt.BackColor = System.Drawing.Color.White;
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emailTxt.Location = new System.Drawing.Point(71, 178);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(395, 35);
            this.emailTxt.TabIndex = 27;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(70, 147);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(71, 28);
            this.emailLbl.TabIndex = 26;
            this.emailLbl.Text = "Email";
            // 
            // backToLoginLbl
            // 
            this.backToLoginLbl.AutoSize = true;
            this.backToLoginLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToLoginLbl.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.backToLoginLbl.ForeColor = System.Drawing.Color.Plum;
            this.backToLoginLbl.Location = new System.Drawing.Point(178, 855);
            this.backToLoginLbl.Name = "backToLoginLbl";
            this.backToLoginLbl.Size = new System.Drawing.Size(154, 28);
            this.backToLoginLbl.TabIndex = 25;
            this.backToLoginLbl.Text = "Back to Login";
            this.backToLoginLbl.Click += new System.EventHandler(this.backToLoginLbl_Click);
            // 
            // haveAccountLbl
            // 
            this.haveAccountLbl.AutoSize = true;
            this.haveAccountLbl.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.haveAccountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.haveAccountLbl.Location = new System.Drawing.Point(124, 810);
            this.haveAccountLbl.Name = "haveAccountLbl";
            this.haveAccountLbl.Size = new System.Drawing.Size(278, 28);
            this.haveAccountLbl.TabIndex = 24;
            this.haveAccountLbl.Text = "Already Have an Account";
            // 
            // clearFieldsBtn
            // 
            this.clearFieldsBtn.BackColor = System.Drawing.Color.White;
            this.clearFieldsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearFieldsBtn.FlatAppearance.BorderColor = System.Drawing.Color.Plum;
            this.clearFieldsBtn.FlatAppearance.BorderSize = 3;
            this.clearFieldsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearFieldsBtn.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.clearFieldsBtn.ForeColor = System.Drawing.Color.Plum;
            this.clearFieldsBtn.Location = new System.Drawing.Point(71, 716);
            this.clearFieldsBtn.Name = "clearFieldsBtn";
            this.clearFieldsBtn.Size = new System.Drawing.Size(395, 65);
            this.clearFieldsBtn.TabIndex = 23;
            this.clearFieldsBtn.Text = "CLEAR FIELDS";
            this.clearFieldsBtn.UseVisualStyleBackColor = false;
            this.clearFieldsBtn.Click += new System.EventHandler(this.clearFieldsBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.Plum;
            this.registerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerBtn.FlatAppearance.BorderSize = 0;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(71, 620);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(395, 65);
            this.registerBtn.TabIndex = 22;
            this.registerBtn.Text = "REGISTER";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // showPasswordCheckBox
            // 
            this.showPasswordCheckBox.AutoSize = true;
            this.showPasswordCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPasswordCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPasswordCheckBox.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.showPasswordCheckBox.Location = new System.Drawing.Point(273, 538);
            this.showPasswordCheckBox.Name = "showPasswordCheckBox";
            this.showPasswordCheckBox.Size = new System.Drawing.Size(193, 32);
            this.showPasswordCheckBox.TabIndex = 21;
            this.showPasswordCheckBox.Text = "Show Password";
            this.showPasswordCheckBox.UseVisualStyleBackColor = true;
            this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.showPasswordCheckBox_CheckedChanged);
            // 
            // signUpLbl
            // 
            this.signUpLbl.AutoSize = true;
            this.signUpLbl.Font = new System.Drawing.Font("Bauhaus 93", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLbl.ForeColor = System.Drawing.Color.Plum;
            this.signUpLbl.Location = new System.Drawing.Point(60, 34);
            this.signUpLbl.Name = "signUpLbl";
            this.signUpLbl.Size = new System.Drawing.Size(214, 63);
            this.signUpLbl.TabIndex = 14;
            this.signUpLbl.Text = "Sign Up";
            // 
            // usernameTxt
            // 
            this.usernameTxt.BackColor = System.Drawing.Color.White;
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usernameTxt.Location = new System.Drawing.Point(71, 281);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(395, 35);
            this.usernameTxt.TabIndex = 29;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.usernameLbl.Location = new System.Drawing.Point(70, 250);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(115, 28);
            this.usernameLbl.TabIndex = 28;
            this.usernameLbl.Text = "Username";
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.Color.White;
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordTxt.Location = new System.Drawing.Point(71, 388);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(395, 35);
            this.passwordTxt.TabIndex = 31;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.passwordLbl.Location = new System.Drawing.Point(70, 357);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(111, 28);
            this.passwordLbl.TabIndex = 30;
            this.passwordLbl.Text = "Password";
            // 
            // confirmPasswordTxt
            // 
            this.confirmPasswordTxt.BackColor = System.Drawing.Color.White;
            this.confirmPasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.confirmPasswordTxt.Location = new System.Drawing.Point(71, 497);
            this.confirmPasswordTxt.Name = "confirmPasswordTxt";
            this.confirmPasswordTxt.Size = new System.Drawing.Size(395, 35);
            this.confirmPasswordTxt.TabIndex = 33;
            // 
            // confirmPasswordLbl
            // 
            this.confirmPasswordLbl.AutoSize = true;
            this.confirmPasswordLbl.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.confirmPasswordLbl.Location = new System.Drawing.Point(70, 466);
            this.confirmPasswordLbl.Name = "confirmPasswordLbl";
            this.confirmPasswordLbl.Size = new System.Drawing.Size(203, 28);
            this.confirmPasswordLbl.TabIndex = 32;
            this.confirmPasswordLbl.Text = "Confirm Password";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.MuseumEmoji;
            this.pictureBox2.Location = new System.Drawing.Point(396, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.WaveEmoji;
            this.pictureBox1.Location = new System.Drawing.Point(311, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(538, 914);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.confirmPasswordTxt);
            this.Controls.Add(this.confirmPasswordLbl);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.backToLoginLbl);
            this.Controls.Add(this.haveAccountLbl);
            this.Controls.Add(this.clearFieldsBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.showPasswordCheckBox);
            this.Controls.Add(this.signUpLbl);
            this.ForeColor = System.Drawing.Color.Plum;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label backToLoginLbl;
        private System.Windows.Forms.Label haveAccountLbl;
        private System.Windows.Forms.Button clearFieldsBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.CheckBox showPasswordCheckBox;
        private System.Windows.Forms.Label signUpLbl;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox confirmPasswordTxt;
        private System.Windows.Forms.Label confirmPasswordLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}