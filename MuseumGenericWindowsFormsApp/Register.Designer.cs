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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.backToLoginLbl = new System.Windows.Forms.Label();
            this.haveAccountLbl = new System.Windows.Forms.Label();
            this.clearFieldsBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.signUpLbl = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.confirmPasswordTxt = new System.Windows.Forms.TextBox();
            this.confirmPasswordLbl = new System.Windows.Forms.Label();
            this.showPasswordLbl = new System.Windows.Forms.Label();
            this.passwordSafeLevelPanel = new System.Windows.Forms.Panel();
            this.passwordSafeLevelLbl = new System.Windows.Forms.Label();
            this.passwordMatchLbl = new System.Windows.Forms.Label();
            this.matchPic = new System.Windows.Forms.PictureBox();
            this.showPasswordBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.matchPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // emailTxt
            // 
            this.emailTxt.BackColor = System.Drawing.Color.White;
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.emailTxt.Location = new System.Drawing.Point(71, 162);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(395, 35);
            this.emailTxt.TabIndex = 27;
            this.emailTxt.TextChanged += new System.EventHandler(this.emailTxt_TextChanged);
            this.emailTxt.Enter += new System.EventHandler(this.emailTxt_Enter);
            this.emailTxt.Leave += new System.EventHandler(this.emailTxt_Leave);
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(70, 131);
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
            // signUpLbl
            // 
            this.signUpLbl.AutoSize = true;
            this.signUpLbl.Font = new System.Drawing.Font("Bauhaus 93", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLbl.ForeColor = System.Drawing.Color.Plum;
            this.signUpLbl.Location = new System.Drawing.Point(140, 34);
            this.signUpLbl.Name = "signUpLbl";
            this.signUpLbl.Size = new System.Drawing.Size(214, 63);
            this.signUpLbl.TabIndex = 14;
            this.signUpLbl.Text = "Sign Up";
            // 
            // usernameTxt
            // 
            this.usernameTxt.BackColor = System.Drawing.Color.White;
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usernameTxt.Location = new System.Drawing.Point(71, 265);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(395, 35);
            this.usernameTxt.TabIndex = 29;
            this.usernameTxt.TextChanged += new System.EventHandler(this.usernameTxt_TextChanged);
            this.usernameTxt.Enter += new System.EventHandler(this.usernameTxt_Enter);
            this.usernameTxt.Leave += new System.EventHandler(this.usernameTxt_Leave);
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.usernameLbl.Location = new System.Drawing.Point(70, 234);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(115, 28);
            this.usernameLbl.TabIndex = 28;
            this.usernameLbl.Text = "Username";
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.Color.White;
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordTxt.Location = new System.Drawing.Point(71, 372);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(395, 35);
            this.passwordTxt.TabIndex = 31;
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordTxt_TextChanged);
            this.passwordTxt.Enter += new System.EventHandler(this.passwordTxt_Enter);
            this.passwordTxt.Leave += new System.EventHandler(this.passwordTxt_Leave);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.passwordLbl.Location = new System.Drawing.Point(70, 341);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(111, 28);
            this.passwordLbl.TabIndex = 30;
            this.passwordLbl.Text = "Password";
            // 
            // confirmPasswordTxt
            // 
            this.confirmPasswordTxt.BackColor = System.Drawing.Color.White;
            this.confirmPasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.confirmPasswordTxt.Location = new System.Drawing.Point(71, 505);
            this.confirmPasswordTxt.Name = "confirmPasswordTxt";
            this.confirmPasswordTxt.Size = new System.Drawing.Size(395, 35);
            this.confirmPasswordTxt.TabIndex = 33;
            this.confirmPasswordTxt.TextChanged += new System.EventHandler(this.confirmPasswordTxt_TextChanged);
            this.confirmPasswordTxt.Enter += new System.EventHandler(this.confirmPasswordTxt_Enter);
            this.confirmPasswordTxt.Leave += new System.EventHandler(this.confirmPasswordTxt_Leave);
            // 
            // confirmPasswordLbl
            // 
            this.confirmPasswordLbl.AutoSize = true;
            this.confirmPasswordLbl.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.confirmPasswordLbl.Location = new System.Drawing.Point(70, 474);
            this.confirmPasswordLbl.Name = "confirmPasswordLbl";
            this.confirmPasswordLbl.Size = new System.Drawing.Size(203, 28);
            this.confirmPasswordLbl.TabIndex = 32;
            this.confirmPasswordLbl.Text = "Confirm Password";
            // 
            // showPasswordLbl
            // 
            this.showPasswordLbl.AutoSize = true;
            this.showPasswordLbl.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.showPasswordLbl.Location = new System.Drawing.Point(238, 555);
            this.showPasswordLbl.Name = "showPasswordLbl";
            this.showPasswordLbl.Size = new System.Drawing.Size(172, 28);
            this.showPasswordLbl.TabIndex = 37;
            this.showPasswordLbl.Text = "Show Password";
            // 
            // passwordSafeLevelPanel
            // 
            this.passwordSafeLevelPanel.BackColor = System.Drawing.Color.Red;
            this.passwordSafeLevelPanel.Location = new System.Drawing.Point(71, 413);
            this.passwordSafeLevelPanel.Name = "passwordSafeLevelPanel";
            this.passwordSafeLevelPanel.Size = new System.Drawing.Size(395, 8);
            this.passwordSafeLevelPanel.TabIndex = 38;
            // 
            // passwordSafeLevelLbl
            // 
            this.passwordSafeLevelLbl.AutoSize = true;
            this.passwordSafeLevelLbl.Font = new System.Drawing.Font("Bauhaus 93", 8F);
            this.passwordSafeLevelLbl.ForeColor = System.Drawing.Color.Red;
            this.passwordSafeLevelLbl.Location = new System.Drawing.Point(72, 424);
            this.passwordSafeLevelLbl.Name = "passwordSafeLevelLbl";
            this.passwordSafeLevelLbl.Size = new System.Drawing.Size(131, 18);
            this.passwordSafeLevelLbl.TabIndex = 39;
            this.passwordSafeLevelLbl.Text = "WEAK PASSWORD";
            // 
            // passwordMatchLbl
            // 
            this.passwordMatchLbl.AutoSize = true;
            this.passwordMatchLbl.Font = new System.Drawing.Font("Bauhaus 93", 8F);
            this.passwordMatchLbl.ForeColor = System.Drawing.Color.Red;
            this.passwordMatchLbl.Location = new System.Drawing.Point(102, 550);
            this.passwordMatchLbl.Name = "passwordMatchLbl";
            this.passwordMatchLbl.Size = new System.Drawing.Size(85, 18);
            this.passwordMatchLbl.TabIndex = 40;
            this.passwordMatchLbl.Text = "NO MATCH";
            // 
            // matchPic
            // 
            this.matchPic.Image = global::WindowsFormsApp1.Properties.Resources.NoMatchIcon;
            this.matchPic.Location = new System.Drawing.Point(71, 546);
            this.matchPic.Name = "matchPic";
            this.matchPic.Size = new System.Drawing.Size(25, 25);
            this.matchPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.matchPic.TabIndex = 41;
            this.matchPic.TabStop = false;
            // 
            // showPasswordBtn
            // 
            this.showPasswordBtn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.ShowPasswordRegisterIcon;
            this.showPasswordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showPasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPasswordBtn.FlatAppearance.BorderSize = 0;
            this.showPasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPasswordBtn.Location = new System.Drawing.Point(416, 546);
            this.showPasswordBtn.Name = "showPasswordBtn";
            this.showPasswordBtn.Size = new System.Drawing.Size(50, 50);
            this.showPasswordBtn.TabIndex = 36;
            this.showPasswordBtn.UseVisualStyleBackColor = true;
            this.showPasswordBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
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
            this.Controls.Add(this.matchPic);
            this.Controls.Add(this.passwordMatchLbl);
            this.Controls.Add(this.passwordSafeLevelLbl);
            this.Controls.Add(this.passwordSafeLevelPanel);
            this.Controls.Add(this.showPasswordLbl);
            this.Controls.Add(this.showPasswordBtn);
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
            this.Controls.Add(this.signUpLbl);
            this.ForeColor = System.Drawing.Color.Plum;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matchPic)).EndInit();
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
        private System.Windows.Forms.Label signUpLbl;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox confirmPasswordTxt;
        private System.Windows.Forms.Label confirmPasswordLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button showPasswordBtn;
        private System.Windows.Forms.Label showPasswordLbl;
        private System.Windows.Forms.Panel passwordSafeLevelPanel;
        private System.Windows.Forms.Label passwordSafeLevelLbl;
        private System.Windows.Forms.Label passwordMatchLbl;
        private System.Windows.Forms.PictureBox matchPic;
    }
}