using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using Microsoft.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class GenericMasterDetailWindow : Form
    {
        /*string connectionString = @"Server=LEGIONOFCRISTI\SQLEXPRESS;
                                    Database=MuzeuDB;
                                    Integrated Security=true;
                                    TrustServerCertificate=true;";*/
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        DataSet ds = new DataSet();
        
        SqlDataAdapter parentAdapter = new SqlDataAdapter();
        SqlDataAdapter childAdapter = new SqlDataAdapter();
        
        BindingSource parentBS = new BindingSource();
        BindingSource childBS = new BindingSource();

        readonly string appTitle = System.Configuration.ConfigurationManager.AppSettings["applicationTitle"];
        readonly string imageFolderPath = System.Configuration.ConfigurationManager.AppSettings["imageFolderPath"];
        readonly string iconName = System.Configuration.ConfigurationManager.AppSettings["iconName"];
        readonly string[] backgrounds = { System.Configuration.ConfigurationManager.AppSettings["firstBackground"], System.Configuration.ConfigurationManager.AppSettings["secondBackground"], System.Configuration.ConfigurationManager.AppSettings["thirdBackground"] };
        int currentBackgroundIndex = 0;

        readonly int xInitialPosition = 15;
        int yPosition = 10;
        readonly int yStep = 30;

        // Declare the combo box
        System.Windows.Forms.ComboBox comboBox1;

        public GenericMasterDetailWindow()
        {
            InitializeComponent();

            dataGridViewParent.MultiSelect = false;
            dataGridViewChild.MultiSelect = false;

            dataGridViewParent.EnableHeadersVisualStyles = false;
            dataGridViewParent.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridViewParent.Font, FontStyle.Bold);

            dataGridViewChild.EnableHeadersVisualStyles = false;
            dataGridViewChild.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridViewChild.Font, FontStyle.Bold);

            this.Text = appTitle;
            this.Icon = new Icon(imageFolderPath + iconName);
            this.BackgroundImage = Image.FromFile(imageFolderPath + backgrounds[currentBackgroundIndex]);
        }

        private void loadDataToTables(SqlConnection conn)
        {
            parentAdapter.SelectCommand = new SqlCommand("SELECT * FROM " + System.Configuration.ConfigurationManager.AppSettings["parentTable"] + ";", conn);
            childAdapter.SelectCommand = new SqlCommand("SELECT * FROM " + System.Configuration.ConfigurationManager.AppSettings["childTable"] + ";", conn);

            parentAdapter.Fill(ds, System.Configuration.ConfigurationManager.AppSettings["parentTableName"]);
            childAdapter.Fill(ds, System.Configuration.ConfigurationManager.AppSettings["childTableName"]);

            DataColumn parentColumn = ds.Tables[System.Configuration.ConfigurationManager.AppSettings["parentTableName"]].Columns[System.Configuration.ConfigurationManager.AppSettings["foreignKeyName"]];
            DataColumn childColumn = ds.Tables[System.Configuration.ConfigurationManager.AppSettings["childTableName"]].Columns[System.Configuration.ConfigurationManager.AppSettings["foreignKeyName"]];

            DataRelation relation = new DataRelation(System.Configuration.ConfigurationManager.AppSettings["foreignKeyRelation"], parentColumn, childColumn);
            ds.Relations.Add(relation);

            parentBS.DataSource = ds.Tables[System.Configuration.ConfigurationManager.AppSettings["parentTableName"]];
            dataGridViewParent.DataSource = parentBS;
            childBS.DataSource = parentBS;
            childBS.DataMember = System.Configuration.ConfigurationManager.AppSettings["foreignKeyRelation"];
            dataGridViewChild.DataSource = childBS;
        }

        private void createForeigKeyComboBox(SqlConnection conn)
        {
            // Initialize the combo box
            comboBox1 = new System.Windows.Forms.ComboBox();
            comboBox1.Location = new System.Drawing.Point(xInitialPosition, yPosition);
            yPosition += yStep;
            comboBox1.Width = 105;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            SqlCommand selectForeignKeyCommand = new SqlCommand("SELECT [" + System.Configuration.ConfigurationManager.AppSettings["foreignKeyName"] + "] FROM " + System.Configuration.ConfigurationManager.AppSettings["parentTableName"] + "; ", conn);
            SqlDataReader reader = selectForeignKeyCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    // Add items to the combo box
                    if (reader.GetFieldType(0) == typeof(string))
                    {
                        // Column is of type string
                        comboBox1.Items.Add(reader.GetString(0));
                    }
                    else if (reader.GetFieldType(0) == typeof(int))
                    {
                        // Column is of type int
                        comboBox1.Items.Add(reader.GetInt32(0));
                    }
                    else if (reader.GetFieldType(0) == typeof(float))
                    {
                        // Column is of type float
                        comboBox1.Items.Add(reader.GetFloat(0));
                    }
                }
            }
            reader.Close();

            // Set the default selected item
            comboBox1.SelectedIndex = 0;

            // Add the combo box to the panel
            mainPanel.Controls.Add(comboBox1);
        }

        private void createControls(SqlConnection conn)
        {
            foreach (DataGridViewColumn column in dataGridViewChild.Columns)
            {
                string columnName = column.Name;

                Label label = new Label();
                label.Name = columnName + "Lbl";
                label.Location = new Point(xInitialPosition, yPosition);
                label.Text = columnName;
                label.ForeColor = Color.Fuchsia;
                label.BackColor = Color.LightPink;
                label.Width = 230;
                label.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                yPosition += yStep;

                mainPanel.Controls.Add(label);

                if (columnName != System.Configuration.ConfigurationManager.AppSettings["foreignKeyName"])
                {
                    Control inputControl = null;

                    Type columnType = column.ValueType;
                    if (columnType == typeof(string))
                    {
                        TextBox textBox = new TextBox();
                        textBox.MaxLength = 50;

                        inputControl = textBox;
                        inputControl.Width = 230;
                    }
                    else if (columnType == typeof(int))
                    {
                        NumericUpDown numericUpDown = new NumericUpDown();
                        numericUpDown.Minimum = -2147483648;
                        numericUpDown.Maximum = 2147483647;
                        numericUpDown.Increment = 1;

                        inputControl = numericUpDown;
                        inputControl.Width = 85;
                    }

                    inputControl.Name = columnName + "Input";
                    inputControl.Location = new Point(xInitialPosition, yPosition);
                    yPosition += yStep;

                    mainPanel.Controls.Add(inputControl);
                }
            }

            createForeigKeyComboBox(conn);
        }

        private void MasterDetailWindow_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    loadDataToTables(conn);

                    createControls(conn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("[X]Eroare!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewParent_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the event is for a cell in an even row
            if (e.RowIndex % 2 == 0)
            {
                // Set the background color of the even cells to Thistle
                dataGridViewParent.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Thistle;
            }
            else
            {
                // Set the background color of the odd cells to LightPink
                dataGridViewParent.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightPink;
            }
        }

        private void dataGridViewChild_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the event is for a cell in an even row
            if (e.RowIndex % 2 == 0)
            {
                // Set the background color of the even cells to Thistle
                dataGridViewChild.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightPink;
            }
            else
            {
                // Set the background color of the odd cells to LightPink
                dataGridViewChild.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Thistle;
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

                    SqlCommand insertCommand = new SqlCommand("INSERT INTO " + System.Configuration.ConfigurationManager.AppSettings["childTable"] + "(" + System.Configuration.ConfigurationManager.AppSettings["insertColumns"] + ") VALUES (" + System.Configuration.ConfigurationManager.AppSettings["insertValues"] + ");", conn);

                    string valueName = "";
                    int count = 1;
                    foreach (DataGridViewColumn column in dataGridViewChild.Columns)
                    {
                        valueName = "@value" + count;
                        string columnName = column.Name;
                        if (columnName != System.Configuration.ConfigurationManager.AppSettings["foreignKeyName"])
                        {
                            string inputName = columnName + "Input";
                            Control inputControl = mainPanel.Controls[inputName];

                            insertCommand.Parameters.AddWithValue(valueName, inputControl.Text);

                            count++;
                        }
                    }
                    string selectedElementComboBox1 = comboBox1.SelectedItem.ToString();
                    insertCommand.Parameters.AddWithValue(valueName, selectedElementComboBox1);

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

                    SqlCommand updateCommand = new SqlCommand("UPDATE " + System.Configuration.ConfigurationManager.AppSettings["childTable"] + " SET " + System.Configuration.ConfigurationManager.AppSettings["updateValues"] + " WHERE " + System.Configuration.ConfigurationManager.AppSettings["updateCondition"] + ";", conn);

                    string valueName = "";
                    int count = 1;
                    foreach (DataGridViewColumn column in dataGridViewChild.Columns)
                    {
                        valueName = "@value" + count;
                        string columnName = column.Name;
                        if (columnName != System.Configuration.ConfigurationManager.AppSettings["foreignKeyName"])
                        {
                            string inputName = columnName + "Input";
                            Control inputControl = mainPanel.Controls[inputName];

                            updateCommand.Parameters.AddWithValue(valueName, inputControl.Text);

                            count++;
                        }
                    }
                    string selectedElementComboBox1 = comboBox1.SelectedItem.ToString();
                    updateCommand.Parameters.AddWithValue(valueName, selectedElementComboBox1);

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
            DialogResult result = MessageBox.Show("Sunteti sigur ca doriti sa stergeti fosila de dinozaur cu id-ul #" + 0 + "?", "Delete Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        SqlCommand deleteCommand = new SqlCommand("DELETE FROM " + System.Configuration.ConfigurationManager.AppSettings["childTable"] + " WHERE " + System.Configuration.ConfigurationManager.AppSettings["deleteCondition"] + ";", conn);

                        foreach (DataGridViewColumn column in dataGridViewChild.Columns)
                        {
                            string columnName = column.Name;
                            string inputName = columnName + "Input";
                            Control inputControl = mainPanel.Controls[inputName];

                            deleteCommand.Parameters.AddWithValue("@value1", inputControl.Text);

                            break;
                        }

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

                loadDataToTables(conn);
            }
        }

        private void dataGridViewParent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = comboBox1.FindString(dataGridViewParent.SelectedRows[0].Cells[0].Value.ToString());
                comboBox1.SelectedIndex = index;
            }
        }

        private void dataGridViewChild_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int count = 0;
                foreach (DataGridViewColumn column in dataGridViewChild.Columns)
                {
                    string columnName = column.Name;
                    if (columnName != System.Configuration.ConfigurationManager.AppSettings["foreignKeyName"])
                    {
                        string inputName = columnName + "Input";
                        Control inputControl = mainPanel.Controls[inputName];

                        Type columnType = column.ValueType;
                        if (columnType == typeof(string))
                        {
                            inputControl.Text = dataGridViewChild.SelectedRows[0].Cells[count].Value.ToString();
                        }
                        else if (columnType == typeof(int))
                        {
                            NumericUpDown numericUpDown = (NumericUpDown)inputControl;
                            int val;
                            int.TryParse(dataGridViewChild.SelectedRows[0].Cells[count].Value.ToString(), out val);
                            numericUpDown.Value = val;
                        }

                        count++;
                    }
                }
            }
        }

        private void resetFieldsLbl_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridViewChild.Columns)
            {
                string columnName = column.Name;
                if (columnName != System.Configuration.ConfigurationManager.AppSettings["foreignKeyName"])
                {
                    string inputName = columnName + "Input";
                    Control inputControl = mainPanel.Controls[inputName];

                    Type columnType = column.ValueType;
                    if (columnType == typeof(string))
                    {
                        inputControl.Text = "";
                    }
                    else if (columnType == typeof(int))
                    {
                        inputControl.Text = "0";
                    }
                }
            }
            comboBox1.SelectedIndex = 0;
        }

        private void setBackgroundImage()
        {
            this.BackgroundImage = Image.FromFile(imageFolderPath + backgrounds[currentBackgroundIndex]);
        }

        private void changeBackgroundBtn_Click(object sender, EventArgs e)
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
