namespace RecordKeeperWinForm
{
    partial class frmOlympicsCreateBasedOnPrevious
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
            lblHeader = new Label();
            lblSeason = new Label();
            lblCity = new Label();
            lblYear = new Label();
            lblBasedOn = new Label();
            lstSeasonName = new ComboBox();
            lstCityDesc = new ComboBox();
            txtYear = new TextBox();
            lstOlympicDesc = new ComboBox();
            btnCreate = new Button();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.Controls.Add(lblHeader, 0, 0);
            tblMain.Controls.Add(lblSeason, 0, 1);
            tblMain.Controls.Add(lblCity, 0, 2);
            tblMain.Controls.Add(lblYear, 0, 3);
            tblMain.Controls.Add(lblBasedOn, 0, 4);
            tblMain.Controls.Add(lstSeasonName, 1, 1);
            tblMain.Controls.Add(lstCityDesc, 1, 2);
            tblMain.Controls.Add(txtYear, 1, 3);
            tblMain.Controls.Add(lstOlympicDesc, 1, 4);
            tblMain.Controls.Add(btnCreate, 1, 5);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 6;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(630, 450);
            tblMain.TabIndex = 0;
            // 
            // lblHeader
            // 
            tblMain.SetColumnSpan(lblHeader, 2);
            lblHeader.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeader.Location = new Point(3, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(533, 41);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Create New Olympics Based On Previous Olympics";
            lblHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSeason
            // 
            lblSeason.AutoSize = true;
            lblSeason.Location = new Point(3, 41);
            lblSeason.Name = "lblSeason";
            lblSeason.Size = new Size(90, 20);
            lblSeason.TabIndex = 1;
            lblSeason.Text = "New Season";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(3, 82);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(68, 20);
            lblCity.TabIndex = 2;
            lblCity.Text = "New City";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(3, 123);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(71, 20);
            lblYear.TabIndex = 3;
            lblYear.Text = "New Year";
            // 
            // lblBasedOn
            // 
            lblBasedOn.AutoSize = true;
            lblBasedOn.Location = new Point(3, 163);
            lblBasedOn.Name = "lblBasedOn";
            lblBasedOn.Size = new Size(72, 20);
            lblBasedOn.TabIndex = 4;
            lblBasedOn.Text = "Based On";
            // 
            // lstSeasonName
            // 
            lstSeasonName.Dock = DockStyle.Fill;
            lstSeasonName.FormattingEnabled = true;
            lstSeasonName.Location = new Point(99, 44);
            lstSeasonName.Margin = new Padding(3, 3, 3, 10);
            lstSeasonName.Name = "lstSeasonName";
            lstSeasonName.Size = new Size(437, 28);
            lstSeasonName.TabIndex = 0;
            // 
            // lstCityDesc
            // 
            lstCityDesc.Dock = DockStyle.Fill;
            lstCityDesc.FormattingEnabled = true;
            lstCityDesc.Location = new Point(99, 85);
            lstCityDesc.Margin = new Padding(3, 3, 3, 10);
            lstCityDesc.Name = "lstCityDesc";
            lstCityDesc.Size = new Size(437, 28);
            lstCityDesc.TabIndex = 1;
            // 
            // txtYear
            // 
            txtYear.Dock = DockStyle.Fill;
            txtYear.Location = new Point(99, 126);
            txtYear.Margin = new Padding(3, 3, 3, 10);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(437, 27);
            txtYear.TabIndex = 2;
            // 
            // lstOlympicDesc
            // 
            lstOlympicDesc.Dock = DockStyle.Fill;
            lstOlympicDesc.FormattingEnabled = true;
            lstOlympicDesc.Location = new Point(99, 166);
            lstOlympicDesc.Margin = new Padding(3, 3, 3, 10);
            lstOlympicDesc.Name = "lstOlympicDesc";
            lstOlympicDesc.Size = new Size(437, 28);
            lstOlympicDesc.TabIndex = 3;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreate.AutoSize = true;
            btnCreate.Location = new Point(375, 207);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(161, 30);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Create New Olympics";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // frmOlympicsCreateBasedOnPrevious
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 450);
            Controls.Add(tblMain);
            Name = "frmOlympicsCreateBasedOnPrevious";
            Text = "Olympics Create Based On Previous";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblHeader;
        private Label lblSeason;
        private Label lblCity;
        private Label lblYear;
        private Label lblBasedOn;
        private ComboBox lstSeasonName;
        private ComboBox lstCityDesc;
        private TextBox txtYear;
        private ComboBox lstOlympicDesc;
        private Button btnCreate;
    }
}