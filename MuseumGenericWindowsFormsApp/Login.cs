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

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Text = "Authentication Page";
            this.Icon = new Icon("../../Images/MuseumLogo.ico");

            passwordTxt.PasswordChar = '*';
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

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                passwordTxt.PasswordChar = '\0';
            }
            else
            {
                passwordTxt.PasswordChar = '*';
            }
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
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
            usernameTxt.Clear();
            passwordTxt.Clear();
        }

        private void createAccountLbl_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }
    }
}
