namespace WindowsFormsApp1
{
    partial class StartSplashScreen
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
            this.components = new System.ComponentModel.Container();
            this.totalProgressPanel = new System.Windows.Forms.Panel();
            this.currentProgressPanel = new System.Windows.Forms.Panel();
            this.creatorLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rectanglePic = new System.Windows.Forms.PictureBox();
            this.tRexPic = new System.Windows.Forms.PictureBox();
            this.loadingLbl = new System.Windows.Forms.Label();
            this.leftColumnPic = new System.Windows.Forms.PictureBox();
            this.rightColumnPic = new System.Windows.Forms.PictureBox();
            this.totalProgressPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rectanglePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRexPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftColumnPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightColumnPic)).BeginInit();
            this.SuspendLayout();
            // 
            // totalProgressPanel
            // 
            this.totalProgressPanel.Controls.Add(this.currentProgressPanel);
            this.totalProgressPanel.Location = new System.Drawing.Point(1, 617);
            this.totalProgressPanel.Name = "totalProgressPanel";
            this.totalProgressPanel.Size = new System.Drawing.Size(979, 28);
            this.totalProgressPanel.TabIndex = 0;
            // 
            // currentProgressPanel
            // 
            this.currentProgressPanel.BackColor = System.Drawing.Color.Plum;
            this.currentProgressPanel.Location = new System.Drawing.Point(0, 0);
            this.currentProgressPanel.Name = "currentProgressPanel";
            this.currentProgressPanel.Size = new System.Drawing.Size(10, 28);
            this.currentProgressPanel.TabIndex = 1;
            // 
            // creatorLbl
            // 
            this.creatorLbl.AutoSize = true;
            this.creatorLbl.BackColor = System.Drawing.Color.Transparent;
            this.creatorLbl.Font = new System.Drawing.Font("Bauhaus 93", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.creatorLbl.ForeColor = System.Drawing.Color.Plum;
            this.creatorLbl.Location = new System.Drawing.Point(20, 554);
            this.creatorLbl.Name = "creatorLbl";
            this.creatorLbl.Size = new System.Drawing.Size(415, 34);
            this.creatorLbl.TabIndex = 3;
            this.creatorLbl.Text = "Created by Cristian Stanciu";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rectanglePic
            // 
            this.rectanglePic.Image = global::WindowsFormsApp1.Properties.Resources.Rectangle;
            this.rectanglePic.Location = new System.Drawing.Point(1, -4);
            this.rectanglePic.Name = "rectanglePic";
            this.rectanglePic.Size = new System.Drawing.Size(979, 468);
            this.rectanglePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rectanglePic.TabIndex = 4;
            this.rectanglePic.TabStop = false;
            // 
            // tRexPic
            // 
            this.tRexPic.Image = global::WindowsFormsApp1.Properties.Resources.TRexIcon;
            this.tRexPic.Location = new System.Drawing.Point(336, 91);
            this.tRexPic.Name = "tRexPic";
            this.tRexPic.Size = new System.Drawing.Size(312, 184);
            this.tRexPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tRexPic.TabIndex = 5;
            this.tRexPic.TabStop = false;
            // 
            // loadingLbl
            // 
            this.loadingLbl.AutoSize = true;
            this.loadingLbl.BackColor = System.Drawing.Color.Transparent;
            this.loadingLbl.Font = new System.Drawing.Font("Bauhaus 93", 30F, System.Drawing.FontStyle.Bold);
            this.loadingLbl.ForeColor = System.Drawing.Color.Plum;
            this.loadingLbl.Location = new System.Drawing.Point(332, 287);
            this.loadingLbl.Name = "loadingLbl";
            this.loadingLbl.Size = new System.Drawing.Size(316, 68);
            this.loadingLbl.TabIndex = 6;
            this.loadingLbl.Text = "Loading...";
            // 
            // leftColumnPic
            // 
            this.leftColumnPic.Image = global::WindowsFormsApp1.Properties.Resources.ColumnIcon;
            this.leftColumnPic.Location = new System.Drawing.Point(12, 12);
            this.leftColumnPic.Name = "leftColumnPic";
            this.leftColumnPic.Size = new System.Drawing.Size(80, 80);
            this.leftColumnPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leftColumnPic.TabIndex = 7;
            this.leftColumnPic.TabStop = false;
            // 
            // rightColumnPic
            // 
            this.rightColumnPic.Image = global::WindowsFormsApp1.Properties.Resources.ColumnIcon;
            this.rightColumnPic.Location = new System.Drawing.Point(886, 12);
            this.rightColumnPic.Name = "rightColumnPic";
            this.rightColumnPic.Size = new System.Drawing.Size(80, 80);
            this.rightColumnPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rightColumnPic.TabIndex = 8;
            this.rightColumnPic.TabStop = false;
            // 
            // StartSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.rightColumnPic);
            this.Controls.Add(this.leftColumnPic);
            this.Controls.Add(this.loadingLbl);
            this.Controls.Add(this.tRexPic);
            this.Controls.Add(this.rectanglePic);
            this.Controls.Add(this.creatorLbl);
            this.Controls.Add(this.totalProgressPanel);
            this.Name = "StartSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartSplashScreen";
            this.Load += new System.EventHandler(this.StartSplashScreen_Load);
            this.totalProgressPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rectanglePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRexPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftColumnPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightColumnPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel totalProgressPanel;
        private System.Windows.Forms.Panel currentProgressPanel;
        private System.Windows.Forms.Label creatorLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox rectanglePic;
        private System.Windows.Forms.PictureBox tRexPic;
        private System.Windows.Forms.Label loadingLbl;
        private System.Windows.Forms.PictureBox leftColumnPic;
        private System.Windows.Forms.PictureBox rightColumnPic;
    }
}