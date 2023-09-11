namespace RecordKeeperWinForm
{
    partial class frmSearch
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
            tblSearch = new TableLayoutPanel();
            lblLastName = new Label();
            txtLastName = new TextBox();
            btnSearch = new Button();
            btnNew = new Button();
            gPresident = new DataGridView();
            lblParty = new Label();
            lblTermStart = new Label();
            lstParty = new ComboBox();
            tblTermStart = new TableLayoutPanel();
            txtBeginTermStart = new TextBox();
            txtEndTermStart = new TextBox();
            lblTermStartTo = new Label();
            tblMain.SuspendLayout();
            tblSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gPresident).BeginInit();
            tblTermStart.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(tblSearch, 0, 0);
            tblMain.Controls.Add(gPresident, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 31.3056374F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 68.69436F));
            tblMain.Size = new Size(956, 674);
            tblMain.TabIndex = 0;
            // 
            // tblSearch
            // 
            tblSearch.AutoSize = true;
            tblSearch.ColumnCount = 3;
            tblSearch.ColumnStyles.Add(new ColumnStyle());
            tblSearch.ColumnStyles.Add(new ColumnStyle());
            tblSearch.ColumnStyles.Add(new ColumnStyle());
            tblSearch.Controls.Add(btnSearch, 0, 3);
            tblSearch.Controls.Add(btnNew, 1, 3);
            tblSearch.Controls.Add(lblLastName, 0, 1);
            tblSearch.Controls.Add(txtLastName, 1, 1);
            tblSearch.Controls.Add(lblParty, 0, 0);
            tblSearch.Controls.Add(lblTermStart, 0, 2);
            tblSearch.Controls.Add(lstParty, 1, 0);
            tblSearch.Controls.Add(tblTermStart, 1, 2);
            tblSearch.Location = new Point(4, 4);
            tblSearch.Margin = new Padding(4);
            tblSearch.Name = "tblSearch";
            tblSearch.RowCount = 4;
            tblSearch.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tblSearch.RowStyles.Add(new RowStyle());
            tblSearch.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tblSearch.RowStyles.Add(new RowStyle());
            tblSearch.Size = new Size(367, 203);
            tblSearch.TabIndex = 0;
            // 
            // lblLastName
            // 
            lblLastName.Anchor = AnchorStyles.Left;
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(4, 66);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(103, 28);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "&Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Left;
            txtLastName.Location = new Point(114, 63);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 34);
            txtLastName.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.Location = new Point(3, 163);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 38);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.AutoSize = true;
            btnNew.Location = new Point(114, 163);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(74, 38);
            btnNew.TabIndex = 3;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // gPresident
            // 
            gPresident.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            gPresident.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gPresident.Location = new Point(3, 219);
            gPresident.Name = "gPresident";
            gPresident.RowHeadersWidth = 51;
            gPresident.RowTemplate.Height = 29;
            gPresident.Size = new Size(814, 452);
            gPresident.StandardTab = true;
            gPresident.TabIndex = 1;
            // 
            // lblParty
            // 
            lblParty.AutoSize = true;
            lblParty.Location = new Point(3, 0);
            lblParty.Name = "lblParty";
            lblParty.Size = new Size(65, 28);
            lblParty.TabIndex = 4;
            lblParty.Text = "Party";
            // 
            // lblTermStart
            // 
            lblTermStart.AutoSize = true;
            lblTermStart.Location = new Point(3, 100);
            lblTermStart.Name = "lblTermStart";
            lblTermStart.Size = new Size(100, 28);
            lblTermStart.TabIndex = 5;
            lblTermStart.Text = "Term Start";
            // 
            // lstParty
            // 
            lstParty.FormattingEnabled = true;
            lstParty.Location = new Point(114, 3);
            lstParty.Name = "lstParty";
            lstParty.Size = new Size(151, 36);
            lstParty.TabIndex = 6;
            // 
            // tblTermStart
            // 
            tblTermStart.ColumnCount = 3;
            tblTermStart.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblTermStart.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblTermStart.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 73F));
            tblTermStart.Controls.Add(txtBeginTermStart, 0, 0);
            tblTermStart.Controls.Add(txtEndTermStart, 2, 0);
            tblTermStart.Controls.Add(lblTermStartTo, 1, 0);
            tblTermStart.Location = new Point(114, 103);
            tblTermStart.Name = "tblTermStart";
            tblTermStart.RowCount = 1;
            tblTermStart.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblTermStart.Size = new Size(250, 54);
            tblTermStart.TabIndex = 7;
            // 
            // txtBeginTermStart
            // 
            txtBeginTermStart.Location = new Point(4, 3);
            txtBeginTermStart.Name = "txtBeginTermStart";
            txtBeginTermStart.Size = new Size(82, 34);
            txtBeginTermStart.TabIndex = 0;
            // 
            // txtEndTermStart
            // 
            txtEndTermStart.Location = new Point(180, 3);
            txtEndTermStart.Name = "txtEndTermStart";
            txtEndTermStart.Size = new Size(68, 34);
            txtEndTermStart.TabIndex = 1;
            // 
            // lblTermStartTo
            // 
            lblTermStartTo.AutoSize = true;
            lblTermStartTo.Location = new Point(91, 0);
            lblTermStartTo.Name = "lblTermStartTo";
            lblTermStartTo.Size = new Size(32, 28);
            lblTermStartTo.TabIndex = 2;
            lblTermStartTo.Text = "To";
            // 
            // frmSearch
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 674);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmSearch";
            Text = "President Search";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblSearch.ResumeLayout(false);
            tblSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gPresident).EndInit();
            tblTermStart.ResumeLayout(false);
            tblTermStart.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblSearch;
        private Label lblLastName;
        private TextBox txtLastName;
        private Button btnSearch;
        private DataGridView gPresident;
        private Button btnNew;
        private Label lblParty;
        private Label lblTermStart;
        private ComboBox lstParty;
        private TableLayoutPanel tblTermStart;
        private TextBox txtBeginTermStart;
        private TextBox txtEndTermStart;
        private Label lblTermStartTo;
    }
}