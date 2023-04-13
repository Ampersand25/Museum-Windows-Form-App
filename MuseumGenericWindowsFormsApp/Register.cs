using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text.RegularExpressions;

using Microsoft.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Register : Form
    {
        string connectionString = @"Server=LEGIONOFCRISTI\SQLEXPRESS;
                                    Database=MuzeuAuthenticationDB;
                                    Integrated Security=true;
                                    TrustServerCertificate=true;";

        readonly private string emailPlaceholder = "Enter email...";
        readonly private string usernamePlaceholder = "Enter username...";
        readonly private string passwordPlaceholder = "Enter password...";
        readonly private string confirmPasswordPlaceholder = "Reenter password...";

        private bool isShowPasswordOn = false;

        readonly private int weakPasswordMaxLen = 7;
        readonly private int decentPasswordMaxLen = 12;
        readonly private int strongPasswordMaxLen = 17;

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            this.Text = "Registration Page";
            this.Icon = new Icon("../../Images/MuseumLogo.ico");

            // Set the placeholder text
            emailTxt.Text = emailPlaceholder;
            emailTxt.ForeColor = System.Drawing.Color.Gray;

            // Set the placeholder text
            usernameTxt.Text = usernamePlaceholder;
            usernameTxt.ForeColor = System.Drawing.Color.Gray;

            // Set the placeholder text
            passwordTxt.Text = passwordPlaceholder;
            passwordTxt.ForeColor = System.Drawing.Color.Gray;

            // Set the placeholder text
            confirmPasswordTxt.Text = confirmPasswordPlaceholder;
            confirmPasswordTxt.ForeColor = System.Drawing.Color.Gray;
        }

        static bool isValidEmail(string email)
        {
            // Regular expression pattern to validate email addresses
            string pattern = @"/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/";

            // Use Regex.IsMatch method to check if the email address matches the pattern
            return Regex.IsMatch(email, pattern);
        }

        private string validateEmail(string emailStr)
        {
            if (emailStr.Length == 0)
            {
                return "Invalid email: email must be non empty!\n";
            }
            else if (isValidEmail(emailStr))
            {
                return "Invalid email: the given email address is not correct!\n";
            }
            return "";
        }

        private string validateUsername(string usernameStr)
        {
            if (usernameStr.Length == 0)
            {
                return "Invalid username: username must be non empty!\n";
            }
            else if (usernameStr.Length < 5)
            {
                return "Invalid username: username is too short (username must be at least 5 characters long)!\n";
            }
            return "";
        }

        private string validatePassword(string passwordStr)
        {
            if (passwordStr.Length == 0)
            {
                return "Invalid password: password must be non empty!\n";
            }
            else if (passwordStr.Length < 5)
            {
                return "Invalid password: password is too short (passwords must be at least 5 characters long)!\n";
            }
            else if (!passwordStr.Any(char.IsLower))
            {
                return "Invalid password: password must contains at least one lower letter!\n";
            }
            else if (!passwordStr.Any(char.IsUpper))
            {
                return "Invalid password: password must contains at least one upper letter!\n";
            }
            else if (!passwordStr.Any(char.IsDigit))
            {
                return "Invalid password: password must contains at least one digit!\n";
            }
            else if (!passwordStr.Equals(confirmPasswordTxt.Text))
            {
                return "Invalid password: confiramtion failed (the two password are different)!\n";
            }
            return "";
        }

        private void validateUserData()
        {
            string errors = "";

            errors += validateEmail(emailTxt.Text);
            errors += validateUsername(usernameTxt.Text);
            errors += validatePassword(passwordTxt.Text);

            if (errors.Length != 0)
            {
                throw new Exception(errors);
            }
        }

        private void emailTxt_Enter(object sender, EventArgs e)
        {
            // Clear the placeholder text when the TextBox is clicked
            if (emailTxt.Text.Equals(emailPlaceholder))
            {
                emailTxt.Clear();
                emailTxt.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void emailTxt_Leave(object sender, EventArgs e)
        {
            // Restore the placeholder text if the TextBox is empty when it loses focus
            if (string.IsNullOrWhiteSpace(emailTxt.Text))
            {
                emailTxt.Text = emailPlaceholder;
                emailTxt.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {
            // Hide the placeholder text when the user starts typing
            if (!emailTxt.Text.Equals(emailPlaceholder))
            {
                emailTxt.ForeColor = System.Drawing.Color.Plum;
            }
        }

        private void usernameTxt_Enter(object sender, EventArgs e)
        {
            // Clear the placeholder text when the TextBox is clicked
            if (usernameTxt.Text.Equals(usernamePlaceholder))
            {
                usernameTxt.Clear();
                usernameTxt.ForeColor = System.Drawing.Color.Plum;
            }
        }

        private void usernameTxt_Leave(object sender, EventArgs e)
        {
            // Restore the placeholder text if the TextBox is empty when it loses focus
            if (string.IsNullOrWhiteSpace(usernameTxt.Text))
            {
                usernameTxt.Text = usernamePlaceholder;
                usernameTxt.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            // Hide the placeholder text when the user starts typing
            if (!usernameTxt.Text.Equals(usernamePlaceholder))
            {
                usernameTxt.ForeColor = System.Drawing.Color.Plum;
            }
        }

        private void passwordTxt_Enter(object sender, EventArgs e)
        {
            // Clear the placeholder text when the TextBox is clicked
            if (passwordTxt.Text.Equals(passwordPlaceholder))
            {
                passwordTxt.Clear();
                passwordTxt.ForeColor = System.Drawing.Color.Plum;
                passwordTxt.PasswordChar = isShowPasswordOn ? '\0' : '*';
            }
        }

        private void passwordTxt_Leave(object sender, EventArgs e)
        {
            // Restore the placeholder text if the TextBox is empty when it loses focus
            if (string.IsNullOrWhiteSpace(passwordTxt.Text))
            {
                passwordTxt.Text = passwordPlaceholder;
                passwordTxt.ForeColor = System.Drawing.Color.Gray;
                passwordTxt.PasswordChar = '\0';
            }
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            // Hide the placeholder text when the user starts typing
            if (!passwordTxt.Text.Equals(passwordPlaceholder))
            {
                passwordTxt.ForeColor = System.Drawing.Color.Plum;
            }

            if (passwordTxt.Text.Equals(passwordPlaceholder) || passwordTxt.Text.Length == 0)
            {
                passwordSafeLevelPanel.BackColor = System.Drawing.Color.Gray;

                passwordSafeLevelLbl.Text = "NO PASSWORD ENTERED";
                passwordSafeLevelLbl.ForeColor = System.Drawing.Color.Gray;
            }
            else if (!passwordTxt.Text.Equals(passwordPlaceholder))
            {
                if (passwordTxt.Text.Length <= weakPasswordMaxLen)
                {
                    passwordSafeLevelPanel.BackColor = System.Drawing.Color.Red;

                    passwordSafeLevelLbl.Text = "WEAK PASSWORD";
                    passwordSafeLevelLbl.ForeColor = System.Drawing.Color.Red;
                }
                else if (passwordTxt.Text.Length <= decentPasswordMaxLen)
                {
                    passwordSafeLevelPanel.BackColor = System.Drawing.Color.Orange;

                    passwordSafeLevelLbl.Text = "DECENT PASSWORD";
                    passwordSafeLevelLbl.ForeColor = System.Drawing.Color.Orange;
                }
                else if (passwordTxt.Text.Length <= strongPasswordMaxLen)
                {
                    passwordSafeLevelPanel.BackColor = System.Drawing.Color.Green;

                    passwordSafeLevelLbl.Text = "STRONG PASSWORD";
                    passwordSafeLevelLbl.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    passwordSafeLevelPanel.BackColor = System.Drawing.Color.Aqua;

                    passwordSafeLevelLbl.Text = "VERY STRONG PASSWORD";
                    passwordSafeLevelLbl.ForeColor = System.Drawing.Color.Aqua;
                }
            }

            if (passwordTxt.Text.Equals(confirmPasswordTxt.Text))
            {
                passwordMatchLbl.Text = "MATCH";
                passwordMatchLbl.ForeColor = Color.Green;
            }
            else
            {
                passwordMatchLbl.Text = "NO MATCH";
                passwordMatchLbl.ForeColor = Color.Red;
            }
        }

        private void confirmPasswordTxt_Enter(object sender, EventArgs e)
        {
            // Clear the placeholder text when the TextBox is clicked
            if (confirmPasswordTxt.Text.Equals(confirmPasswordPlaceholder))
            {
                confirmPasswordTxt.Clear();
                confirmPasswordTxt.ForeColor = System.Drawing.Color.Plum;
                confirmPasswordTxt.PasswordChar = isShowPasswordOn ? '\0' : '*';
            }
        }

        private void confirmPasswordTxt_Leave(object sender, EventArgs e)
        {
            // Restore the placeholder text if the TextBox is empty when it loses focus
            if (string.IsNullOrWhiteSpace(confirmPasswordTxt.Text))
            {
                confirmPasswordTxt.Text = confirmPasswordPlaceholder;
                confirmPasswordTxt.ForeColor = System.Drawing.Color.Gray;
                confirmPasswordTxt.PasswordChar = '\0';
            }
        }

        private void confirmPasswordTxt_TextChanged(object sender, EventArgs e)
        {
            // Hide the placeholder text when the user starts typing
            if (!confirmPasswordTxt.Text.Equals(confirmPasswordPlaceholder))
            {
                confirmPasswordTxt.ForeColor = System.Drawing.Color.Plum;
            }

            if (confirmPasswordTxt.Text.Equals(passwordTxt.Text))
            {
                passwordMatchLbl.Text = "MATCH";
                passwordMatchLbl.ForeColor = Color.Green;
            }
            else
            {
                passwordMatchLbl.Text = "NO MATCH";
                passwordMatchLbl.ForeColor = Color.Red;
            }
        }

        private void updateShowPasswordState()
        {
            if (isShowPasswordOn)
            {
                passwordTxt.PasswordChar = '\0';
                confirmPasswordTxt.PasswordChar = '\0';
                showPasswordBtn.BackgroundImage = Image.FromFile("../../Images/HidePasswordRegisterIcon.png");
                showPasswordLbl.Text = "Hide Password";
            }
            else
            {
                if (!passwordTxt.Text.Equals(passwordPlaceholder))
                {
                    passwordTxt.PasswordChar = '*';
                }
                if (!confirmPasswordTxt.Text.Equals(confirmPasswordPlaceholder))
                {
                    confirmPasswordTxt.PasswordChar = '*';
                }
                showPasswordBtn.BackgroundImage = Image.FromFile("../../Images/ShowPasswordRegisterIcon.png");
                showPasswordLbl.Text = "Show Password";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isShowPasswordOn = !isShowPasswordOn;
            updateShowPasswordState();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                validateUserData();

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        SqlCommand insertCommand = new SqlCommand("INSERT INTO [MuzeuAuthenticationDB].[dbo].[UserCredentials] " +
                            "([Email], [Username], [UserPassword]) " +
                            "VALUES (@email, @username, @password);", conn);
                        insertCommand.Parameters.AddWithValue("@email", emailTxt.Text);
                        insertCommand.Parameters.AddWithValue("@username", usernameTxt.Text);
                        insertCommand.Parameters.AddWithValue("@password", passwordTxt.Text);

                        int insertRowCount = insertCommand.ExecuteNonQuery();
                        Console.WriteLine("Insert Row Count: {0}", insertRowCount);

                        if (insertRowCount != 0)
                        {
                            MessageBox.Show("[+]Inregistrare realizata cu succes!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            new GenericMasterDetailWindow().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("[!]Inregistrarea nu s-a putut realiza!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("[X]Eroare!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("[X]Eroare!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearFieldsBtn_Click(object sender, EventArgs e)
        {
            if (!emailTxt.Equals(emailPlaceholder))
            {
                emailTxt.Text = emailPlaceholder;
                emailTxt.ForeColor = System.Drawing.Color.Gray;
            }

            if (!usernameTxt.Equals(usernamePlaceholder))
            {
                usernameTxt.Text = usernamePlaceholder;
                usernameTxt.ForeColor = System.Drawing.Color.Gray;
            }

            if (!passwordTxt.Equals(passwordPlaceholder))
            {
                passwordTxt.Text = passwordPlaceholder;
                passwordTxt.ForeColor = System.Drawing.Color.Gray;
                passwordTxt.PasswordChar = '\0';
            }

            if (!confirmPasswordTxt.Equals(confirmPasswordPlaceholder))
            {
                confirmPasswordTxt.Text = confirmPasswordPlaceholder;
                confirmPasswordTxt.ForeColor = System.Drawing.Color.Gray;
                confirmPasswordTxt.PasswordChar = '\0';
            }
        }

        private void backToLoginLbl_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
