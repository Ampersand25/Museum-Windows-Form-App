namespace WindowsFormsApp1
{
    partial class Login
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
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.createAccountLbl = new System.Windows.Forms.Label();
            this.dontHaveAccountLbl = new System.Windows.Forms.Label();
            this.clearFieldsBtn = new System.Windows.Forms.Button();
            this.logInBtn = new System.Windows.Forms.Button();
            this.signInLbl = new System.Windows.Forms.Label();
            this.usernamePanel = new System.Windows.Forms.Panel();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.passwordPic = new System.Windows.Forms.PictureBox();
            this.usernamePic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showPasswordBtn = new System.Windows.Forms.Button();
            this.showPasswordLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.Color.White;
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.passwordTxt.ForeColor = System.Drawing.Color.Plum;
            this.passwordTxt.Location = new System.Drawing.Point(133, 427);
            this.passwordTxt.Multiline = true;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(339, 50);
            this.passwordTxt.TabIndex = 47;
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordTxt_TextChanged);
            this.passwordTxt.Enter += new System.EventHandler(this.passwordTxt_Enter);
            this.passwordTxt.Leave += new System.EventHandler(this.passwordTxt_Leave);
            // 
            // usernameTxt
            // 
            this.usernameTxt.BackColor = System.Drawing.Color.White;
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.usernameTxt.ForeColor = System.Drawing.Color.Plum;
            this.usernameTxt.Location = new System.Drawing.Point(133, 321);
            this.usernameTxt.Multiline = true;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(339, 50);
            this.usernameTxt.TabIndex = 45;
            this.usernameTxt.TextChanged += new System.EventHandler(this.usernameTxt_TextChanged);
            this.usernameTxt.Enter += new System.EventHandler(this.usernameTxt_Enter);
            this.usernameTxt.Leave += new System.EventHandler(this.usernameTxt_Leave);
            // 
            // createAccountLbl
            // 
            this.createAccountLbl.AutoSize = true;
            this.createAccountLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccountLbl.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.createAccountLbl.ForeColor = System.Drawing.Color.Plum;
            this.createAccountLbl.Location = new System.Drawing.Point(184, 854);
            this.createAccountLbl.Name = "createAccountLbl";
            this.createAccountLbl.Size = new System.Drawing.Size(179, 28);
            this.createAccountLbl.TabIndex = 41;
            this.createAccountLbl.Text = "Create Account";
            this.createAccountLbl.Click += new System.EventHandler(this.createAccountLbl_Click);
            // 
            // dontHaveAccountLbl
            // 
            this.dontHaveAccountLbl.AutoSize = true;
            this.dontHaveAccountLbl.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.dontHaveAccountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.dontHaveAccountLbl.Location = new System.Drawing.Point(142, 810);
            this.dontHaveAccountLbl.Name = "dontHaveAccountLbl";
            this.dontHaveAccountLbl.Size = new System.Drawing.Size(253, 28);
            this.dontHaveAccountLbl.TabIndex = 40;
            this.dontHaveAccountLbl.Text = "Don\'t Have an Account";
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
            this.clearFieldsBtn.Location = new System.Drawing.Point(77, 715);
            this.clearFieldsBtn.Name = "clearFieldsBtn";
            this.clearFieldsBtn.Size = new System.Drawing.Size(395, 65);
            this.clearFieldsBtn.TabIndex = 39;
            this.clearFieldsBtn.Text = "CLEAR FIELDS";
            this.clearFieldsBtn.UseVisualStyleBackColor = false;
            this.clearFieldsBtn.Click += new System.EventHandler(this.clearFieldsBtn_Click);
            // 
            // logInBtn
            // 
            this.logInBtn.BackColor = System.Drawing.Color.Plum;
            this.logInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInBtn.FlatAppearance.BorderSize = 0;
            this.logInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInBtn.Font = new System.Drawing.Font("Bauhaus 93", 12F);
            this.logInBtn.ForeColor = System.Drawing.Color.White;
            this.logInBtn.Location = new System.Drawing.Point(77, 619);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(395, 65);
            this.logInBtn.TabIndex = 38;
            this.logInBtn.Text = "LOG IN";
            this.logInBtn.UseVisualStyleBackColor = false;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // signInLbl
            // 
            this.signInLbl.AutoSize = true;
            this.signInLbl.Font = new System.Drawing.Font("Bauhaus 93", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInLbl.ForeColor = System.Drawing.Color.Plum;
            this.signInLbl.Location = new System.Drawing.Point(171, 167);
            this.signInLbl.Name = "signInLbl";
            this.signInLbl.Size = new System.Drawing.Size(198, 63);
            this.signInLbl.TabIndex = 36;
            this.signInLbl.Text = "Sign In";
            // 
            // usernamePanel
            // 
            this.usernamePanel.BackColor = System.Drawing.Color.Plum;
            this.usernamePanel.Location = new System.Drawing.Point(77, 377);
            this.usernamePanel.Name = "usernamePanel";
            this.usernamePanel.Size = new System.Drawing.Size(395, 5);
            this.usernamePanel.TabIndex = 50;
            // 
            // passwordPanel
            // 
            this.passwordPanel.BackColor = System.Drawing.Color.Plum;
            this.passwordPanel.Location = new System.Drawing.Point(77, 483);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(395, 5);
            this.passwordPanel.TabIndex = 52;
            // 
            // passwordPic
            // 
            this.passwordPic.Image = global::WindowsFormsApp1.Properties.Resources.PasswordIcon;
            this.passwordPic.Location = new System.Drawing.Point(77, 427);
            this.passwordPic.Name = "passwordPic";
            this.passwordPic.Size = new System.Drawing.Size(50, 50);
            this.passwordPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passwordPic.TabIndex = 51;
            this.passwordPic.TabStop = false;
            // 
            // usernamePic
            // 
            this.usernamePic.Image = global::WindowsFormsApp1.Properties.Resources.UserIcon;
            this.usernamePic.Location = new System.Drawing.Point(77, 321);
            this.usernamePic.Name = "usernamePic";
            this.usernamePic.Size = new System.Drawing.Size(50, 50);
            this.usernamePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usernamePic.TabIndex = 49;
            this.usernamePic.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.MuseumLogInPicture;
            this.pictureBox1.Location = new System.Drawing.Point(77, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // showPasswordBtn
            // 
            this.showPasswordBtn.BackColor = System.Drawing.Color.Transparent;
            this.showPasswordBtn.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.ShowPasswordIcon;
            this.showPasswordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showPasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPasswordBtn.FlatAppearance.BorderSize = 0;
            this.showPasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPasswordBtn.Location = new System.Drawing.Point(422, 494);
            this.showPasswordBtn.Name = "showPasswordBtn";
            this.showPasswordBtn.Size = new System.Drawing.Size(50, 50);
            this.showPasswordBtn.TabIndex = 53;
            this.showPasswordBtn.UseVisualStyleBackColor = false;
            this.showPasswordBtn.Click += new System.EventHandler(this.showPasswordBtn_Click);
            // 
            // showPasswordLbl
            // 
            this.showPasswordLbl.AutoSize = true;
            this.showPasswordLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPasswordLbl.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPasswordLbl.ForeColor = System.Drawing.Color.Plum;
            this.showPasswordLbl.Location = new System.Drawing.Point(244, 503);
            this.showPasswordLbl.Name = "showPasswordLbl";
            this.showPasswordLbl.Size = new System.Drawing.Size(172, 28);
            this.showPasswordLbl.TabIndex = 54;
            this.showPasswordLbl.Text = "Show Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(538, 914);
            this.Controls.Add(this.showPasswordLbl);
            this.Controls.Add(this.showPasswordBtn);
            this.Controls.Add(this.passwordPanel);
            this.Controls.Add(this.passwordPic);
            this.Controls.Add(this.usernamePanel);
            this.Controls.Add(this.usernamePic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.createAccountLbl);
            this.Controls.Add(this.dontHaveAccountLbl);
            this.Controls.Add(this.clearFieldsBtn);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.signInLbl);
            this.ForeColor = System.Drawing.Color.Plum;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passwordPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label createAccountLbl;
        private System.Windows.Forms.Label dontHaveAccountLbl;
        private System.Windows.Forms.Button clearFieldsBtn;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.Label signInLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox usernamePic;
        private System.Windows.Forms.Panel usernamePanel;
        private System.Windows.Forms.PictureBox passwordPic;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.Button showPasswordBtn;
        private System.Windows.Forms.Label showPasswordLbl;
    }
}