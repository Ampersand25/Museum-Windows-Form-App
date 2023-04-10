namespace WindowsFormsApp1
{
    partial class GenericMasterDetailWindow
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
            this.meniulPrincipalLbl = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.changeBackgroundBtn = new System.Windows.Forms.Button();
            this.resetFieldsLbl = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParent)).BeginInit();
            this.mainPanel.SuspendLayout();
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
            this.dataGridViewChild.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewChild_CellFormatting);
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
            this.dataGridViewParent.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewParent_CellFormatting);
            // 
            // parentTableLbl
            // 
            this.parentTableLbl.AutoSize = true;
            this.parentTableLbl.BackColor = System.Drawing.Color.LightPink;
            this.parentTableLbl.Font = new System.Drawing.Font("Bauhaus 93", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentTableLbl.ForeColor = System.Drawing.Color.Fuchsia;
            this.parentTableLbl.Location = new System.Drawing.Point(13, 10);
            this.parentTableLbl.Name = "parentTableLbl";
            this.parentTableLbl.Size = new System.Drawing.Size(232, 34);
            this.parentTableLbl.TabIndex = 2;
            this.parentTableLbl.Text = "Tabelul Părinte";
            // 
            // childTableLbl
            // 
            this.childTableLbl.AutoSize = true;
            this.childTableLbl.BackColor = System.Drawing.Color.LightPink;
            this.childTableLbl.Font = new System.Drawing.Font("Bauhaus 93", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childTableLbl.ForeColor = System.Drawing.Color.Fuchsia;
            this.childTableLbl.Location = new System.Drawing.Point(13, 481);
            this.childTableLbl.Name = "childTableLbl";
            this.childTableLbl.Size = new System.Drawing.Size(212, 34);
            this.childTableLbl.TabIndex = 3;
            this.childTableLbl.Text = "Tabelul Copil";
            // 
            // meniulPrincipalLbl
            // 
            this.meniulPrincipalLbl.AutoSize = true;
            this.meniulPrincipalLbl.BackColor = System.Drawing.Color.LightPink;
            this.meniulPrincipalLbl.Font = new System.Drawing.Font("Bauhaus 93", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meniulPrincipalLbl.ForeColor = System.Drawing.Color.Fuchsia;
            this.meniulPrincipalLbl.Location = new System.Drawing.Point(1130, 11);
            this.meniulPrincipalLbl.Name = "meniulPrincipalLbl";
            this.meniulPrincipalLbl.Size = new System.Drawing.Size(252, 34);
            this.meniulPrincipalLbl.TabIndex = 4;
            this.meniulPrincipalLbl.Text = "Meniul Principal";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Window;
            this.mainPanel.Controls.Add(this.changeBackgroundBtn);
            this.mainPanel.Controls.Add(this.resetFieldsLbl);
            this.mainPanel.Controls.Add(this.refreshBtn);
            this.mainPanel.Controls.Add(this.deleteBtn);
            this.mainPanel.Controls.Add(this.updateBtn);
            this.mainPanel.Controls.Add(this.addBtn);
            this.mainPanel.Location = new System.Drawing.Point(1059, 48);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(394, 832);
            this.mainPanel.TabIndex = 5;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // changeBackgroundBtn
            // 
            this.changeBackgroundBtn.BackColor = System.Drawing.Color.LightPink;
            this.changeBackgroundBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBackgroundBtn.ForeColor = System.Drawing.Color.Fuchsia;
            this.changeBackgroundBtn.Location = new System.Drawing.Point(18, 771);
            this.changeBackgroundBtn.Name = "changeBackgroundBtn";
            this.changeBackgroundBtn.Size = new System.Drawing.Size(359, 45);
            this.changeBackgroundBtn.TabIndex = 13;
            this.changeBackgroundBtn.Text = "&Change Background";
            this.changeBackgroundBtn.UseVisualStyleBackColor = false;
            this.changeBackgroundBtn.Click += new System.EventHandler(this.changeBackgroundBtn_Click);
            // 
            // resetFieldsLbl
            // 
            this.resetFieldsLbl.AutoSize = true;
            this.resetFieldsLbl.BackColor = System.Drawing.Color.White;
            this.resetFieldsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetFieldsLbl.ForeColor = System.Drawing.Color.Fuchsia;
            this.resetFieldsLbl.Location = new System.Drawing.Point(14, 646);
            this.resetFieldsLbl.Name = "resetFieldsLbl";
            this.resetFieldsLbl.Size = new System.Drawing.Size(104, 20);
            this.resetFieldsLbl.TabIndex = 21;
            this.resetFieldsLbl.Text = "Clear Fields";
            this.resetFieldsLbl.Click += new System.EventHandler(this.resetFieldsLbl_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.LightPink;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.ForeColor = System.Drawing.Color.Fuchsia;
            this.refreshBtn.Location = new System.Drawing.Point(205, 720);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(172, 45);
            this.refreshBtn.TabIndex = 6;
            this.refreshBtn.Text = "&Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.LightPink;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Fuchsia;
            this.deleteBtn.Location = new System.Drawing.Point(18, 720);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(172, 45);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "&Ștergere";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.LightPink;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.Fuchsia;
            this.updateBtn.Location = new System.Drawing.Point(205, 669);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(172, 45);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "&Modificare";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.LightPink;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.Fuchsia;
            this.addBtn.Location = new System.Drawing.Point(18, 669);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(172, 45);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "&Adăugare";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // GenericMasterDetailWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.FormBackgroundImage1;
            this.ClientSize = new System.Drawing.Size(1458, 894);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.meniulPrincipalLbl);
            this.Controls.Add(this.childTableLbl);
            this.Controls.Add(this.parentTableLbl);
            this.Controls.Add(this.dataGridViewParent);
            this.Controls.Add(this.dataGridViewChild);
            this.ForeColor = System.Drawing.Color.Fuchsia;
            this.Name = "GenericMasterDetailWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MasterDetailWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasterDetailWindow_FormClosing);
            this.Load += new System.EventHandler(this.MasterDetailWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParent)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewChild;
        private System.Windows.Forms.DataGridView dataGridViewParent;
        private System.Windows.Forms.Label parentTableLbl;
        private System.Windows.Forms.Label childTableLbl;
        private System.Windows.Forms.Label meniulPrincipalLbl;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Label resetFieldsLbl;
        private System.Windows.Forms.Button changeBackgroundBtn;
    }
}

