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

        static bool isValidEmail(string email)
        {
            // Regular expression pattern to validate email addresses
            string pattern = @"/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/";

            // Use Regex.IsMatch method to check if the email address matches the pattern
            return Regex.IsMatch(email, pattern);
        }

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            this.Text = "Registration Page";
            this.Icon = new Icon("../../Images/MuseumLogo.ico");

            passwordTxt.PasswordChar = '*';
            confirmPasswordTxt.PasswordChar = '*';
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Display a confirmation prompt to the user
            DialogResult result = MessageBox.Show("Sunteti sigur ca doriti sa inchideti aplicatia?", "Exit Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                e.Cancel = true; // Cancel the form closing event
            }
        }

        private void validateUserData()
        {
            string errors = "";

            string emailStr = emailTxt.Text;
            if (emailStr.Length == 0)
            {
                errors += "Invalid email: email must be non empty!\n";
            }
            else if (isValidEmail(emailStr))
            {
                errors += "Invalid email: the given email address is not correct!\n";
            }

            string usernameStr = usernameTxt.Text;
            if (usernameStr.Length == 0)
            {
                errors += "Invalid username: username must be non empty!\n";
            }
            else if (usernameStr.Length < 5)
            {
                errors += "Invalid username: username is too short (username must be at least 5 characters long)!\n";
            }

            string passwordStr = passwordTxt.Text;
            if (passwordStr.Length == 0)
            {
                errors += "Invalid password: password must be non empty!\n";
            }
            else if (passwordStr.Length < 5)
            {
                errors += "Invalid password: password is too short (passwords must be at least 5 characters long)!\n";
            }
            else if (!passwordStr.Any(char.IsLower))
            {
                errors += "Invalid password: password must contains at least one lower letter!\n";
            }
            else if (!passwordStr.Any(char.IsUpper))
            {
                errors += "Invalid password: password must contains at least one upper letter!\n";
            }
            else if (!passwordStr.Any(char.IsDigit))
            {
                errors += "Invalid password: password must contains at least one digit!\n";
            }
            else if (!passwordStr.Equals(confirmPasswordTxt.Text))
            {
                errors += "Invalid password: confiramtion failed (the two password are different)!\n";
            }

            if (errors.Length != 0)
            {
                throw new Exception(errors);
            }
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                passwordTxt.PasswordChar = '\0';
                confirmPasswordTxt.PasswordChar = '\0';
            }
            else
            {
                passwordTxt.PasswordChar = '*';
                confirmPasswordTxt.PasswordChar = '*';
            }
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
            emailTxt.Clear();
            usernameTxt.Clear();
            passwordTxt.Clear();
            confirmPasswordTxt.Clear();
        }

        private void backToLoginLbl_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
