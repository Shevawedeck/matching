namespace RecordKeeperWinForm
{
    partial class frmDataMaintenence
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
            tblMain = new TableLayoutPanel();
            btnSave = new Button();
            gData = new DataGridView();
            pnlOptButtons = new FlowLayoutPanel();
            optCountry = new RadioButton();
            optCity = new RadioButton();
            optOlympicMedal = new RadioButton();
            optSeason = new RadioButton();
            optSport = new RadioButton();
            optSportSubcategory = new RadioButton();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            pnlOptButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.181818F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.8181839F));
            tblMain.Controls.Add(btnSave, 0, 0);
            tblMain.Controls.Add(gData, 1, 1);
            tblMain.Controls.Add(pnlOptButtons, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.Size = new Size(1100, 630);
            tblMain.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(4, 4);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 41);
            btnSave.TabIndex = 0;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // gData
            // 
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(313, 52);
            gData.Name = "gData";
            gData.RowHeadersWidth = 51;
            gData.RowTemplate.Height = 29;
            gData.Size = new Size(784, 575);
            gData.TabIndex = 1;
            // 
            // pnlOptButtons
            // 
            pnlOptButtons.Controls.Add(optCountry);
            pnlOptButtons.Controls.Add(optCity);
            pnlOptButtons.Controls.Add(optOlympicMedal);
            pnlOptButtons.Controls.Add(optSeason);
            pnlOptButtons.Controls.Add(optSport);
            pnlOptButtons.Controls.Add(optSportSubcategory);
            pnlOptButtons.Dock = DockStyle.Fill;
            pnlOptButtons.FlowDirection = FlowDirection.TopDown;
            pnlOptButtons.Location = new Point(3, 52);
            pnlOptButtons.Name = "pnlOptButtons";
            pnlOptButtons.Size = new Size(304, 575);
            pnlOptButtons.TabIndex = 2;
            // 
            // optCountry
            // 
            optCountry.AutoSize = true;
            optCountry.Checked = true;
            optCountry.Location = new Point(3, 3);
            optCountry.Name = "optCountry";
            optCountry.Size = new Size(116, 32);
            optCountry.TabIndex = 0;
            optCountry.TabStop = true;
            optCountry.Text = "Countries";
            optCountry.UseVisualStyleBackColor = true;
            // 
            // optCity
            // 
            optCity.AutoSize = true;
            optCity.Location = new Point(3, 41);
            optCity.Name = "optCity";
            optCity.Size = new Size(80, 32);
            optCity.TabIndex = 1;
            optCity.Text = "Cities";
            optCity.UseVisualStyleBackColor = true;
            // 
            // optOlympicMedal
            // 
            optOlympicMedal.AutoSize = true;
            optOlympicMedal.Location = new Point(3, 79);
            optOlympicMedal.Name = "optOlympicMedal";
            optOlympicMedal.Size = new Size(96, 32);
            optOlympicMedal.TabIndex = 2;
            optOlympicMedal.Text = "Medals";
            optOlympicMedal.UseVisualStyleBackColor = true;
            // 
            // optSeason
            // 
            optSeason.AutoSize = true;
            optSeason.Location = new Point(3, 117);
            optSeason.Name = "optSeason";
            optSeason.Size = new Size(103, 32);
            optSeason.TabIndex = 3;
            optSeason.Text = "Seasons";
            optSeason.UseVisualStyleBackColor = true;
            // 
            // optSport
            // 
            optSport.AutoSize = true;
            optSport.Location = new Point(3, 155);
            optSport.Name = "optSport";
            optSport.Size = new Size(90, 32);
            optSport.TabIndex = 4;
            optSport.Text = "Sports";
            optSport.UseVisualStyleBackColor = true;
            // 
            // optSportSubcategory
            // 
            optSportSubcategory.AutoSize = true;
            optSportSubcategory.Location = new Point(3, 193);
            optSportSubcategory.Name = "optSportSubcategory";
            optSportSubcategory.Size = new Size(211, 32);
            optSportSubcategory.TabIndex = 5;
            optSportSubcategory.Text = "Sport Subcategories";
            optSportSubcategory.UseVisualStyleBackColor = true;
            // 
            // frmDataMaintenence
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmDataMaintenence";
            Text = "Data Maintenence";
            tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            pnlOptButtons.ResumeLayout(false);
            pnlOptButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSave;
        private DataGridView gData;
        private FlowLayoutPanel pnlOptButtons;
        private RadioButton optCountry;
        private RadioButton optCity;
        private RadioButton optOlympicMedal;
        private RadioButton optSeason;
        private RadioButton optSport;
        private RadioButton optSportSubcategory;
    }
}