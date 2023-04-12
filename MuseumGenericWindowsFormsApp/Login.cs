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

        private bool isShowPasswordOn = false;

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
        }

        private void updateShowPasswordState()
        {
            if (isShowPasswordOn)
            {
                passwordTxt.PasswordChar = '\0';
                showPasswordBtn.BackgroundImage = Image.FromFile("../../Images/HidePasswordIcon.png");
                showPasswordLbl.Text = "Hide Password";
            }
            else
            {
                if (passwordTxt.Text != passwordPlaceholder)
                {
                    passwordTxt.PasswordChar = '*';
                }
                showPasswordBtn.BackgroundImage = Image.FromFile("../../Images/ShowPasswordIcon.png");
                showPasswordLbl.Text = "Show Password";
            }
        }

        private void showPasswordBtn_Click(object sender, EventArgs e)
        {
            isShowPasswordOn = !isShowPasswordOn;
            updateShowPasswordState();
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
                                new SplashScreen().Show();
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
                        MessageBox.Show("[X]User inexistent!\n", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void infoBtn_Click(object sender, EventArgs e)
        {
            string creditsStr = "• Museum icons created by Freepik - Flaticon:\nhttps://www.flaticon.com/free-icons/museum\n" +
                                "• Info icons created by Freepik - Flaticon:\nhttps://www.flaticon.com/free-icons/info\n" +
                                "• User icons created by Phoenix Group - Flaticon:\nhttps://www.flaticon.com/free-icons/user\n" +
                                "• Password icons created by Prosymbols Premium - Flaticon:\nhttps://www.flaticon.com/free-icons/password\n" +
                                "• Eye icons created by Kiranshastry - Flaticon:\nhttps://www.flaticon.com/free-icons/eye\n" +
                                "• Password icons created by th studio - Flaticon:\nhttps://www.flaticon.com/free-icons/password\n" +
                                "• Museum icons created by Freepik - Flaticon:\nhttps://www.flaticon.com/free-icons/museum\n" +
                                "• Register icons created by Freepik - Flaticon:\nhttps://www.flaticon.com/free-icons/register\n" +
                                "• Eye icons created by Freepik - Flaticon:\nhttps://www.flaticon.com/free-icons/eye\n" +
                                "• Show password icons created by Stasy - Flaticon:\nhttps://www.flaticon.com/free-icons/show-password\n" +
                                "• Dinosaur icons created by Smashicons - Flaticon:\nhttps://www.flaticon.com/free-icons/dinosaur\n" +
                                "• Logout icons created by Pixel perfect - Flaticon:\nhttps://www.flaticon.com/free-icons/logout";
            MessageBox.Show("Special thanks to:\n" + creditsStr, "©Credits", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
