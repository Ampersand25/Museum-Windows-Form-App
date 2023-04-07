namespace WindowsFormsApp1
{
    partial class MasterDetailWindow
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
            this.dataGridViewChild = new System.Windows.Forms.DataGridView();
            this.dataGridViewParent = new System.Windows.Forms.DataGridView();
            this.parentTableLbl = new System.Windows.Forms.Label();
            this.childTableLbl = new System.Windows.Forms.Label();
            this.meniuPrincipalLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resetFieldsLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.nrTotalFosileLbl = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.nrTotalGhiziLbl = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CNPGhidLbl = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.nrOaseLbl = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.epocaLbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.familieDinozaurLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tipDinozaurLbl = new System.Windows.Forms.Label();
            this.fosilaDinozaurIDLbl = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.prevBackgroundBtn = new System.Windows.Forms.Button();
            this.nextBackgroundBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParent)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewChild
            // 
            this.dataGridViewChild.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewChild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChild.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewChild.Location = new System.Drawing.Point(12, 518);
            this.dataGridViewChild.Name = "dataGridViewChild";
            this.dataGridViewChild.RowHeadersWidth = 62;
            this.dataGridViewChild.RowTemplate.Height = 28;
            this.dataGridViewChild.RowTemplate.ReadOnly = true;
            this.dataGridViewChild.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChild.Size = new System.Drawing.Size(1013, 362);
            this.dataGridViewChild.TabIndex = 0;
            this.dataGridViewChild.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChild_CellClick);
            // 
            // dataGridViewParent
            // 
            this.dataGridViewParent.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewParent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParent.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewParent.Location = new System.Drawing.Point(12, 48);
            this.dataGridViewParent.Name = "dataGridViewParent";
            this.dataGridViewParent.RowHeadersWidth = 62;
            this.dataGridViewParent.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dataGridViewParent.RowTemplate.Height = 28;
            this.dataGridViewParent.RowTemplate.ReadOnly = true;
            this.dataGridViewParent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewParent.Size = new System.Drawing.Size(1013, 362);
            this.dataGridViewParent.TabIndex = 1;
            this.dataGridViewParent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewParent_CellClick);
            // 
            // parentTableLbl
            // 
            this.parentTableLbl.AutoSize = true;
            this.parentTableLbl.BackColor = System.Drawing.Color.LightCyan;
            this.parentTableLbl.Font = new System.Drawing.Font("MV Boli", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentTableLbl.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.parentTableLbl.Location = new System.Drawing.Point(805, 5);
            this.parentTableLbl.Name = "parentTableLbl";
            this.parentTableLbl.Size = new System.Drawing.Size(211, 40);
            this.parentTableLbl.TabIndex = 2;
            this.parentTableLbl.Text = "Tabelul Ghizi";
            // 
            // childTableLbl
            // 
            this.childTableLbl.AutoSize = true;
            this.childTableLbl.BackColor = System.Drawing.Color.LightCyan;
            this.childTableLbl.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childTableLbl.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.childTableLbl.Location = new System.Drawing.Point(641, 475);
            this.childTableLbl.Name = "childTableLbl";
            this.childTableLbl.Size = new System.Drawing.Size(375, 40);
            this.childTableLbl.TabIndex = 3;
            this.childTableLbl.Text = "Tabelul Fosile Dinozauri";
            // 
            // meniuPrincipalLbl
            // 
            this.meniuPrincipalLbl.AutoSize = true;
            this.meniuPrincipalLbl.BackColor = System.Drawing.Color.LightCyan;
            this.meniuPrincipalLbl.Font = new System.Drawing.Font("MV Boli", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meniuPrincipalLbl.Location = new System.Drawing.Point(1132, 5);
            this.meniuPrincipalLbl.Name = "meniuPrincipalLbl";
            this.meniuPrincipalLbl.Size = new System.Drawing.Size(251, 40);
            this.meniuPrincipalLbl.TabIndex = 4;
            this.meniuPrincipalLbl.Text = "Meniu Principal";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.resetFieldsLbl);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.numericUpDown4);
            this.panel1.Controls.Add(this.nrTotalFosileLbl);
            this.panel1.Controls.Add(this.numericUpDown3);
            this.panel1.Controls.Add(this.nrTotalGhiziLbl);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.CNPGhidLbl);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.nrOaseLbl);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.epocaLbl);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.familieDinozaurLbl);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.tipDinozaurLbl);
            this.panel1.Controls.Add(this.fosilaDinozaurIDLbl);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Location = new System.Drawing.Point(1059, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 829);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // resetFieldsLbl
            // 
            this.resetFieldsLbl.AutoSize = true;
            this.resetFieldsLbl.BackColor = System.Drawing.Color.White;
            this.resetFieldsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetFieldsLbl.Location = new System.Drawing.Point(267, 696);
            this.resetFieldsLbl.Name = "resetFieldsLbl";
            this.resetFieldsLbl.Size = new System.Drawing.Size(110, 20);
            this.resetFieldsLbl.TabIndex = 21;
            this.resetFieldsLbl.Text = "Reset Fields";
            this.resetFieldsLbl.Click += new System.EventHandler(this.resetFieldsLbl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.DinoFossilImage;
            this.pictureBox1.Location = new System.Drawing.Point(205, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(226, 649);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(125, 26);
            this.numericUpDown4.TabIndex = 19;
            // 
            // nrTotalFosileLbl
            // 
            this.nrTotalFosileLbl.AutoSize = true;
            this.nrTotalFosileLbl.BackColor = System.Drawing.Color.LightCyan;
            this.nrTotalFosileLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrTotalFosileLbl.Location = new System.Drawing.Point(221, 605);
            this.nrTotalFosileLbl.Name = "nrTotalFosileLbl";
            this.nrTotalFosileLbl.Size = new System.Drawing.Size(141, 25);
            this.nrTotalFosileLbl.TabIndex = 18;
            this.nrTotalFosileLbl.Text = "NrTotalFosile";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(18, 649);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(125, 26);
            this.numericUpDown3.TabIndex = 17;
            // 
            // nrTotalGhiziLbl
            // 
            this.nrTotalGhiziLbl.AutoSize = true;
            this.nrTotalGhiziLbl.BackColor = System.Drawing.Color.LightCyan;
            this.nrTotalGhiziLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrTotalGhiziLbl.Location = new System.Drawing.Point(13, 605);
            this.nrTotalGhiziLbl.Name = "nrTotalGhiziLbl";
            this.nrTotalGhiziLbl.Size = new System.Drawing.Size(132, 25);
            this.nrTotalGhiziLbl.TabIndex = 15;
            this.nrTotalGhiziLbl.Text = "NrTotalGhizi";
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.LightCyan;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(205, 770);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(172, 45);
            this.refreshBtn.TabIndex = 6;
            this.refreshBtn.Text = "&Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.LightCyan;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(18, 770);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(172, 45);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "&Ștergere";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.LightCyan;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(205, 719);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(172, 45);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "&Modificare";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.LightCyan;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(18, 719);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(172, 45);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "&Adăugare";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(226, 525);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 11;
            // 
            // CNPGhidLbl
            // 
            this.CNPGhidLbl.AutoSize = true;
            this.CNPGhidLbl.BackColor = System.Drawing.Color.LightCyan;
            this.CNPGhidLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNPGhidLbl.Location = new System.Drawing.Point(221, 484);
            this.CNPGhidLbl.Name = "CNPGhidLbl";
            this.CNPGhidLbl.Size = new System.Drawing.Size(102, 25);
            this.CNPGhidLbl.TabIndex = 10;
            this.CNPGhidLbl.Text = "CNPGhid";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(18, 527);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(125, 26);
            this.numericUpDown2.TabIndex = 9;
            this.numericUpDown2.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // nrOaseLbl
            // 
            this.nrOaseLbl.AutoSize = true;
            this.nrOaseLbl.BackColor = System.Drawing.Color.LightCyan;
            this.nrOaseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrOaseLbl.Location = new System.Drawing.Point(13, 484);
            this.nrOaseLbl.Name = "nrOaseLbl";
            this.nrOaseLbl.Size = new System.Drawing.Size(86, 25);
            this.nrOaseLbl.TabIndex = 8;
            this.nrOaseLbl.Text = "NrOase";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(18, 406);
            this.textBox3.MaxLength = 50;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(359, 26);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Cretacicului superior";
            // 
            // epocaLbl
            // 
            this.epocaLbl.AutoSize = true;
            this.epocaLbl.BackColor = System.Drawing.Color.LightCyan;
            this.epocaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.epocaLbl.Location = new System.Drawing.Point(13, 364);
            this.epocaLbl.Name = "epocaLbl";
            this.epocaLbl.Size = new System.Drawing.Size(73, 25);
            this.epocaLbl.TabIndex = 6;
            this.epocaLbl.Text = "Epocă";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(18, 287);
            this.textBox2.MaxLength = 50;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(359, 26);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Tyrannosauridae";
            // 
            // familieDinozaurLbl
            // 
            this.familieDinozaurLbl.AutoSize = true;
            this.familieDinozaurLbl.BackColor = System.Drawing.Color.LightCyan;
            this.familieDinozaurLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.familieDinozaurLbl.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.familieDinozaurLbl.Location = new System.Drawing.Point(13, 244);
            this.familieDinozaurLbl.Name = "familieDinozaurLbl";
            this.familieDinozaurLbl.Size = new System.Drawing.Size(167, 25);
            this.familieDinozaurLbl.TabIndex = 4;
            this.familieDinozaurLbl.Text = "FamilieDinozaur";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 169);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(359, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Tyrannosaurus";
            // 
            // tipDinozaurLbl
            // 
            this.tipDinozaurLbl.AutoSize = true;
            this.tipDinozaurLbl.BackColor = System.Drawing.Color.LightCyan;
            this.tipDinozaurLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipDinozaurLbl.Location = new System.Drawing.Point(13, 130);
            this.tipDinozaurLbl.Name = "tipDinozaurLbl";
            this.tipDinozaurLbl.Size = new System.Drawing.Size(129, 25);
            this.tipDinozaurLbl.TabIndex = 2;
            this.tipDinozaurLbl.Text = "TipDinozaur";
            // 
            // fosilaDinozaurIDLbl
            // 
            this.fosilaDinozaurIDLbl.AutoSize = true;
            this.fosilaDinozaurIDLbl.BackColor = System.Drawing.Color.LightCyan;
            this.fosilaDinozaurIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fosilaDinozaurIDLbl.Location = new System.Drawing.Point(13, 17);
            this.fosilaDinozaurIDLbl.Name = "fosilaDinozaurIDLbl";
            this.fosilaDinozaurIDLbl.Size = new System.Drawing.Size(177, 25);
            this.fosilaDinozaurIDLbl.TabIndex = 1;
            this.fosilaDinozaurIDLbl.Text = "FosilăDinozaurID";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(18, 57);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(125, 26);
            this.numericUpDown1.TabIndex = 0;
            // 
            // prevBackgroundBtn
            // 
            this.prevBackgroundBtn.BackColor = System.Drawing.Color.LightCyan;
            this.prevBackgroundBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevBackgroundBtn.Location = new System.Drawing.Point(12, 5);
            this.prevBackgroundBtn.Name = "prevBackgroundBtn";
            this.prevBackgroundBtn.Size = new System.Drawing.Size(210, 40);
            this.prevBackgroundBtn.TabIndex = 13;
            this.prevBackgroundBtn.Text = "&Prev Background";
            this.prevBackgroundBtn.UseVisualStyleBackColor = false;
            this.prevBackgroundBtn.Click += new System.EventHandler(this.prevBackgroundBtn_Click);
            // 
            // nextBackgroundBtn
            // 
            this.nextBackgroundBtn.BackColor = System.Drawing.Color.LightCyan;
            this.nextBackgroundBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBackgroundBtn.Location = new System.Drawing.Point(228, 5);
            this.nextBackgroundBtn.Name = "nextBackgroundBtn";
            this.nextBackgroundBtn.Size = new System.Drawing.Size(210, 40);
            this.nextBackgroundBtn.TabIndex = 14;
            this.nextBackgroundBtn.Text = "&Next Background";
            this.nextBackgroundBtn.UseVisualStyleBackColor = false;
            this.nextBackgroundBtn.Click += new System.EventHandler(this.nextBackgroundBtn_Click);
            // 
            // MasterDetailWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.FormBackgroundImage;
            this.ClientSize = new System.Drawing.Size(1458, 894);
            this.Controls.Add(this.nextBackgroundBtn);
            this.Controls.Add(this.prevBackgroundBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.meniuPrincipalLbl);
            this.Controls.Add(this.childTableLbl);
            this.Controls.Add(this.parentTableLbl);
            this.Controls.Add(this.dataGridViewParent);
            this.Controls.Add(this.dataGridViewChild);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Name = "MasterDetailWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewChild;
        private System.Windows.Forms.DataGridView dataGridViewParent;
        private System.Windows.Forms.Label parentTableLbl;
        private System.Windows.Forms.Label childTableLbl;
        private System.Windows.Forms.Label meniuPrincipalLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fosilaDinozaurIDLbl;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label tipDinozaurLbl;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label epocaLbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label familieDinozaurLbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label CNPGhidLbl;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label nrOaseLbl;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Label nrTotalGhiziLbl;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label nrTotalFosileLbl;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label resetFieldsLbl;
        private System.Windows.Forms.Button prevBackgroundBtn;
        private System.Windows.Forms.Button nextBackgroundBtn;
    }
}

