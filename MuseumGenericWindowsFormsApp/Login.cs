using System;
using System.Drawing;
using System.Windows.Forms;

using Microsoft.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        string connectionString = @"Server=LEGIONOFCRISTI\SQLEXPRESS;
                                    Database=MuzeuAuthenticationDB;
                                    Integrated Security=true;
                                    TrustServerCertificate=true;";

        readonly private string usernamePlaceholder = "Enter username...";
        readonly private string passwordPlaceholder = "Enter password...";

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Text = "Authentication Page";
            this.Icon = new Icon("../../Images/MuseumLogo.ico");

            // Set the placeholder text
            usernameTxt.Text = usernamePlaceholder;
            usernameTxt.ForeColor = System.Drawing.Color.Gray;

            // Set the placeholder text
            passwordTxt.Text = passwordPlaceholder;
            passwordTxt.ForeColor = System.Drawing.Color.Gray;
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Display a confirmation prompt to the user
            DialogResult result = MessageBox.Show("Sunteti sigur ca doriti sa inchideti aplicatia?", "Exit Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                e.Cancel = true; // Cancel the form closing event
            }
        }

        private void usernameTxt_Enter(object sender, EventArgs e)
        {
            // Clear the placeholder text when the TextBox is clicked
            if (usernameTxt.Text.Equals(usernamePlaceholder))
            {
                usernameTxt.Text = "";
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
            if (usernameTxt.Text != usernamePlaceholder)
            {
                usernameTxt.ForeColor = System.Drawing.Color.Plum;
            }
        }

        private void passwordTxt_Enter(object sender, EventArgs e)
        {
            // Clear the placeholder text when the TextBox is clicked
            if (passwordTxt.Text.Equals(passwordPlaceholder))
            {
                passwordTxt.Text = "";
                passwordTxt.ForeColor = System.Drawing.Color.Plum;
                if (showPasswordCheckBox.Checked)
                {
                    passwordTxt.PasswordChar = '\0';
                }
                else
                {
                    passwordTxt.PasswordChar = '*';
                }
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
            if (passwordTxt.Text != passwordPlaceholder)
            {
                passwordTxt.ForeColor = System.Drawing.Color.Plum;
            }
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                passwordTxt.PasswordChar = '\0';
            }
            else
            {
                if (passwordTxt.Text != passwordPlaceholder)
                {
                    passwordTxt.PasswordChar = '*';
                }
            }
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text.Length == 0 || usernameTxt.Text.Equals(usernamePlaceholder))
            {
                MessageBox.Show("[X]Nume de utilizator invalid!\n", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (passwordTxt.Text.Length == 0 || passwordTxt.Text.Equals(passwordPlaceholder))
            {
                MessageBox.Show("[X]Parola invalida!\n", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand selectUserPassword = new SqlCommand("SELECT [UserPassword] FROM [MuzeuAuthenticationDB].[dbo].[UserCredentials] WHERE [Username]=@username;", conn);
                    selectUserPassword.Parameters.AddWithValue("@username", usernameTxt.Text);
                    SqlDataReader reader = selectUserPassword.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string password = passwordTxt.Text;
                            if (password.Equals(reader.GetString(0)))
                            {
                                new GenericMasterDetailWindow().Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("[X]Parola incorecta!\n", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("[X]User inexistent (nume de utilizator invalid)!\n", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("[X]Eroare!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearFieldsBtn_Click(object sender, EventArgs e)
        {
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
        }

        private void createAccountLbl_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }
    }
}
