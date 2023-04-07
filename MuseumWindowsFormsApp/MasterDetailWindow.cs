using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using Microsoft.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class MasterDetailWindow : Form
    {
        string connectionString = @"Server=LEGIONOFCRISTI\SQLEXPRESS;
                                    Database=MuzeuDB;
                                    Integrated Security=true;
                                    TrustServerCertificate=true;";
        DataSet ds = new DataSet();
        
        SqlDataAdapter parentAdapter = new SqlDataAdapter();
        SqlDataAdapter childAdapter = new SqlDataAdapter();
        
        BindingSource parentBS = new BindingSource();
        BindingSource childBS = new BindingSource();

        readonly int FosilaDinozaurIDDefaultValue = 0;
        readonly string TipDinozaurDefaultValue = "Tyrannosaurus";
        readonly string FamilieDinozaurDefaultValue = "Tyrannosauridae";
        readonly string EpocaDefaultValue = "Cretacicului superior";
        readonly int NrOaseDefaultValue = 120;

        readonly string appTitle = "Dino Land";
        readonly string imageFolderPath = "../../Images/";
        readonly string iconName = "DinoWorldLogo.ico";
        readonly string[] backgrounds = { "FormBackgroundImage.png", "FormBackgroundImageAlt1.png", "FormBackgroundImageAlt2.png", "FormBackgroundImageAlt3.png", "FormBackgroundImageAlt4.png" };
        int currentBackgroundIndex = 0;

        private void setDefaultValuesForControls(bool resetComboBox)
        {
            fosilaDinozaurIDNumericUpDown.Value = FosilaDinozaurIDDefaultValue;
            tipDinozaurTextBox.Text = TipDinozaurDefaultValue;
            familieDinozaurTextBox.Text = FamilieDinozaurDefaultValue;
            epocaTextBox.Text = EpocaDefaultValue;
            nrOaseNumericUpDown.Value = NrOaseDefaultValue;
            if (resetComboBox)
            {
                CNPGhidComboBox.SelectedIndex = 0;
            }
        }

        public MasterDetailWindow()
        {
            InitializeComponent();

            dataGridViewParent.MultiSelect = false;
            dataGridViewChild.MultiSelect = false;

            dataGridViewParent.EnableHeadersVisualStyles = false;
            dataGridViewParent.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridViewParent.Font, FontStyle.Bold);

            dataGridViewChild.EnableHeadersVisualStyles = false;
            dataGridViewChild.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridViewChild.Font, FontStyle.Bold);

            dataGridViewParent.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewParent.AlternatingRowsDefaultCellStyle.BackColor = dataGridViewParent.DefaultCellStyle.BackColor;

            dataGridViewChild.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridViewChild.RowsDefaultCellStyle.BackColor = dataGridViewChild.DefaultCellStyle.BackColor;

            nrTotalGhiziNumericUpDown.ReadOnly = true;
            nrTotalGhiziNumericUpDown.Increment = 0;

            nrTotalFosileNumericUpDown.ReadOnly = true;
            nrTotalFosileNumericUpDown.Increment = 0;

            setDefaultValuesForControls(false);

            this.Text = appTitle;
            this.Icon = new Icon(imageFolderPath + iconName);
            this.BackgroundImage = Image.FromFile(imageFolderPath + backgrounds[currentBackgroundIndex]);
        }

        private void loadNumberOfGhizi(SqlConnection conn)
        {
            SqlCommand selectCommandGhizi = new SqlCommand("SELECT COUNT(*) FROM [MuzeuDB].[dbo].[Ghizi]", conn);
            SqlDataReader readerGhizi = selectCommandGhizi.ExecuteReader();
            if (readerGhizi.HasRows)
            {
                while (readerGhizi.Read())
                {

                    nrTotalGhiziNumericUpDown.Value = readerGhizi.GetInt32(0);
                }
            }
            readerGhizi.Close();
        }

        private void loadNumberOfFosileDinozauri(SqlConnection conn)
        {
            SqlCommand selectCommandFosileDinozauri = new SqlCommand("SELECT COUNT(*) FROM [MuzeuDB].[dbo].[FosileDinozauri]", conn);
            SqlDataReader readerFosileDinozauri = selectCommandFosileDinozauri.ExecuteReader();
            if (readerFosileDinozauri.HasRows)
            {
                while (readerFosileDinozauri.Read())
                {
                    nrTotalFosileNumericUpDown.Value = readerFosileDinozauri.GetInt32(0);
                }
            }
            readerFosileDinozauri.Close();
        }

        private void loadNumberOfGhiziAndFosileDinozauri(SqlConnection conn)
        {
            loadNumberOfGhizi(conn);
            loadNumberOfFosileDinozauri(conn);
        }

        private void MasterDetailWindow_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    
                    parentAdapter.SelectCommand = new SqlCommand("SELECT * FROM [MuzeuDB].[dbo].[Ghizi];", conn);
                    childAdapter.SelectCommand = new SqlCommand("SELECT * FROM [MuzeuDB].[dbo].[FosileDinozauri];", conn);
                    
                    parentAdapter.Fill(ds, "Ghizi");
                    childAdapter.Fill(ds, "FosileDinozauri");
                    
                    DataColumn parentColumn = ds.Tables["Ghizi"].Columns["CNPGhid"];
                    DataColumn childColumn = ds.Tables["FosileDinozauri"].Columns["CNPGhid"];
                    
                    DataRelation relation = new DataRelation("fk_FosileDinozauri_CNPGhid", parentColumn, childColumn);
                    ds.Relations.Add(relation);
                    
                    parentBS.DataSource = ds.Tables["Ghizi"];
                    dataGridViewParent.DataSource = parentBS;
                    childBS.DataSource = parentBS;
                    childBS.DataMember = "fk_FosileDinozauri_CNPGhid";
                    dataGridViewChild.DataSource = childBS;

                    CNPGhidComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

                    SqlCommand selectCNPGhiziCommand = new SqlCommand("SELECT [CNPGhid] FROM [MuzeuDB].[dbo].[Ghizi];", conn);
                    SqlDataReader reader = selectCNPGhiziCommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CNPGhidComboBox.Items.Add(reader.GetString(0));
                        }
                    }
                    reader.Close();

                    loadNumberOfGhiziAndFosileDinozauri(conn);

                    CNPGhidComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("[X]Eroare!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            // Define a new pen with a black color and a width of 2 pixels
            Pen pen = new Pen(Color.Black, 2);

            // Draw a rectangle around the panel with the specified pen
            e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, mainPanel.Width - 1, mainPanel.Height - 1));
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand insertCommand = new SqlCommand("INSERT INTO [MuzeuDB].[dbo].[FosileDinozauri] " + 
                        "([FosilaDinozaurID], [TipDinozaur], [FamilieDinozaur], [Epoca], [NrOase], [CNPGhid]) " +
                        "VALUES (@fosila_dinozaur_id, @tip_dinozaur, @familie_dinozaur, @epoca, @nr_oase, @cnp_ghid);", conn);
                    insertCommand.Parameters.AddWithValue("@fosila_dinozaur_id", fosilaDinozaurIDNumericUpDown.Value);
                    insertCommand.Parameters.AddWithValue("@tip_dinozaur"      , tipDinozaurTextBox.Text);
                    insertCommand.Parameters.AddWithValue("@familie_dinozaur"  , familieDinozaurTextBox.Text);
                    insertCommand.Parameters.AddWithValue("@epoca"             , epocaTextBox.Text);
                    insertCommand.Parameters.AddWithValue("@nr_oase"           , nrOaseNumericUpDown.Value);
                    insertCommand.Parameters.AddWithValue("@cnp_ghid"          , CNPGhidComboBox.Text);
                    
                    int insertRowCount = insertCommand.ExecuteNonQuery();
                    Console.WriteLine("Insert Row Count: {0}", insertRowCount);
                    
                    if (insertRowCount != 0)
                    {
                        MessageBox.Show("[+]Adaugare realizata cu succes!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshBtn.Focus();
                    }
                    else
                    {
                        MessageBox.Show("[!]Adaugarea nu s-a putut realiza!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("[X]Eroare!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand updateCommand = new SqlCommand("UPDATE [MuzeuDB].[dbo].[FosileDinozauri] SET [TipDinozaur]=@tip_dinozaur, [FamilieDinozaur]=@familie_dinozaur, [Epoca]=@epoca, [NrOase]=@nr_oase, [CNPGhid]=@cnp_ghid WHERE " +
                        "[FosilaDinozaurID]=@fosila_dinozaur_id;", conn);
                    updateCommand.Parameters.AddWithValue("@tip_dinozaur"      , tipDinozaurTextBox.Text);
                    updateCommand.Parameters.AddWithValue("@familie_dinozaur"  , familieDinozaurTextBox.Text);
                    updateCommand.Parameters.AddWithValue("@epoca"             , epocaTextBox.Text);
                    updateCommand.Parameters.AddWithValue("@nr_oase"           , nrOaseNumericUpDown.Value);
                    updateCommand.Parameters.AddWithValue("@cnp_ghid"          , CNPGhidComboBox.Text);
                    updateCommand.Parameters.AddWithValue("@fosila_dinozaur_id", fosilaDinozaurIDNumericUpDown.Value);
                    
                    int updateRowCount = updateCommand.ExecuteNonQuery();
                    Console.WriteLine("Update Row Count: {0}", updateRowCount);
                    
                    if (updateRowCount != 0)
                    {
                        MessageBox.Show("[&]Modificare realizata cu succes!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshBtn.Focus();
                    }
                    else
                    {
                        MessageBox.Show("[!]Modificarea nu s-a putut realiza (nu exista o fosila de dinozaur cu id-ul introdus)!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("[X]Eroare!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sunteti sigur ca doriti sa stergeti fosila de dinozaur cu id-ul #" + fosilaDinozaurIDNumericUpDown.Value + "?", "Delete Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        SqlCommand deleteCommand = new SqlCommand("DELETE FROM [MuzeuDB].[dbo].[FosileDinozauri] WHERE [FosilaDinozaurID]=@fosila_dinozaur_id;", conn);
                        deleteCommand.Parameters.AddWithValue("@fosila_dinozaur_id", fosilaDinozaurIDNumericUpDown.Value);

                        int deleteRowCount = deleteCommand.ExecuteNonQuery();
                        Console.WriteLine("Delete Row Count: {0}", deleteRowCount);

                        if (deleteRowCount != 0)
                        {
                            MessageBox.Show("[-]Stergere realizata cu succes!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refreshBtn.Focus();
                        }
                        else
                        {
                            MessageBox.Show("[!]Stergerea nu s-a putut realiza (nu exista o fosila de dinozaur cu id-ul introdus)!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("[X]Eroare!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                ds = new DataSet();

                parentAdapter = new SqlDataAdapter();
                childAdapter = new SqlDataAdapter();

                parentBS = new BindingSource();
                childBS = new BindingSource();

                parentAdapter.SelectCommand = new SqlCommand("SELECT * FROM [MuzeuDB].[dbo].[Ghizi];", conn);
                childAdapter.SelectCommand = new SqlCommand("SELECT * FROM [MuzeuDB].[dbo].[FosileDinozauri];", conn);

                parentAdapter.Fill(ds, "Ghizi");
                childAdapter.Fill(ds, "FosileDinozauri");

                DataColumn parentColumn = ds.Tables["Ghizi"].Columns["CNPGhid"];
                DataColumn childColumn = ds.Tables["FosileDinozauri"].Columns["CNPGhid"];

                DataRelation relation = new DataRelation("fk_FosileDinozauri_CNPGhid", parentColumn, childColumn);
                ds.Relations.Add(relation);

                parentBS.DataSource = ds.Tables["Ghizi"];
                dataGridViewParent.DataSource = parentBS;
                childBS.DataSource = parentBS;
                childBS.DataMember = "fk_FosileDinozauri_CNPGhid";
                dataGridViewChild.DataSource = childBS;

                loadNumberOfGhiziAndFosileDinozauri(conn);
            }
        }

        private void dataGridViewParent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = CNPGhidComboBox.FindString(dataGridViewParent.SelectedRows[0].Cells[0].Value.ToString());
                CNPGhidComboBox.SelectedIndex = index;
            }
        }

        private void dataGridViewChild_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int val;
                int.TryParse(dataGridViewChild.SelectedRows[0].Cells[0].Value.ToString(), out val);
                fosilaDinozaurIDNumericUpDown.Value = val;
                tipDinozaurTextBox.Text = dataGridViewChild.SelectedRows[0].Cells[1].Value.ToString();
                familieDinozaurTextBox.Text = dataGridViewChild.SelectedRows[0].Cells[2].Value.ToString();
                epocaTextBox.Text = dataGridViewChild.SelectedRows[0].Cells[3].Value.ToString();
                int.TryParse(dataGridViewChild.SelectedRows[0].Cells[4].Value.ToString(), out val);
                nrOaseNumericUpDown.Value = val < 120 ? 120 : val;
            }
        }

        private void resetFieldsLbl_Click(object sender, EventArgs e)
        {
            setDefaultValuesForControls(true);
        }

        private void setBackgroundImage()
        {
            this.BackgroundImage = Image.FromFile(imageFolderPath + backgrounds[currentBackgroundIndex]);
        }

        private void prevBackgroundBtn_Click(object sender, EventArgs e)
        {
            if (currentBackgroundIndex == 0)
            {
                currentBackgroundIndex = backgrounds.Length - 1;
            }
            else
            {
                currentBackgroundIndex--;
            }
            setBackgroundImage();
        }

        private void nextBackgroundBtn_Click(object sender, EventArgs e)
        {
            currentBackgroundIndex = (currentBackgroundIndex + 1) % backgrounds.Length;
            setBackgroundImage();
        }

        private void MasterDetailWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Display a confirmation prompt to the user
            DialogResult result = MessageBox.Show("Sunteti sigur ca doriti sa inchideti aplicatia?", "Exit Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No || result == DialogResult.Cancel)
            {
                e.Cancel = true; // Cancel the form closing event
            }
        }
    }
}
