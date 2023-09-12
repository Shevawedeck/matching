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
            btnSearch = new Button();
            btnNew = new Button();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblParty = new Label();
            lblTermStart = new Label();
            lstParty = new ComboBox();
            tblTermStart = new TableLayoutPanel();
            txtBeginTermStart = new TextBox();
            txtEndTermStart = new TextBox();
            lblTermStartTo = new Label();
            gPresident = new DataGridView();
            tblMain.SuspendLayout();
            tblSearch.SuspendLayout();
            tblTermStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gPresident).BeginInit();
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
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 30.8605347F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 69.1394653F));
            tblMain.Size = new Size(956, 674);
            tblMain.TabIndex = 1;
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
            tblSearch.RowStyles.Add(new RowStyle());
            tblSearch.RowStyles.Add(new RowStyle());
            tblSearch.RowStyles.Add(new RowStyle());
            tblSearch.RowStyles.Add(new RowStyle());
            tblSearch.Size = new Size(334, 172);
            tblSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.Location = new Point(3, 131);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 38);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Right;
            btnNew.AutoSize = true;
            btnNew.Location = new Point(257, 131);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(74, 38);
            btnNew.TabIndex = 7;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // lblLastName
            // 
            lblLastName.Anchor = AnchorStyles.Left;
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(4, 48);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(103, 28);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "&Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Dock = DockStyle.Fill;
            txtLastName.Location = new Point(114, 45);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(217, 34);
            txtLastName.TabIndex = 3;
            // 
            // lblParty
            // 
            lblParty.Anchor = AnchorStyles.Left;
            lblParty.AutoSize = true;
            lblParty.Location = new Point(3, 7);
            lblParty.Name = "lblParty";
            lblParty.Size = new Size(56, 28);
            lblParty.TabIndex = 1;
            lblParty.Text = "Party";
            // 
            // lblTermStart
            // 
            lblTermStart.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTermStart.AutoSize = true;
            lblTermStart.Location = new Point(3, 91);
            lblTermStart.Name = "lblTermStart";
            lblTermStart.Size = new Size(105, 28);
            lblTermStart.TabIndex = 4;
            lblTermStart.Text = "Term Start";
            // 
            // lstParty
            // 
            lstParty.Dock = DockStyle.Fill;
            lstParty.FormattingEnabled = true;
            lstParty.Location = new Point(114, 3);
            lstParty.Name = "lstParty";
            lstParty.Size = new Size(217, 36);
            lstParty.TabIndex = 1;
            // 
            // tblTermStart
            // 
            tblTermStart.AutoSize = true;
            tblTermStart.ColumnCount = 3;
            tblTermStart.ColumnStyles.Add(new ColumnStyle());
            tblTermStart.ColumnStyles.Add(new ColumnStyle());
            tblTermStart.ColumnStyles.Add(new ColumnStyle());
            tblTermStart.Controls.Add(txtBeginTermStart, 0, 0);
            tblTermStart.Controls.Add(txtEndTermStart, 2, 0);
            tblTermStart.Controls.Add(lblTermStartTo, 1, 0);
            tblTermStart.Dock = DockStyle.Fill;
            tblTermStart.Location = new Point(114, 85);
            tblTermStart.Name = "tblTermStart";
            tblTermStart.RowCount = 1;
            tblTermStart.RowStyles.Add(new RowStyle());
            tblTermStart.Size = new Size(217, 40);
            tblTermStart.TabIndex = 5;
            // 
            // txtBeginTermStart
            // 
            txtBeginTermStart.Location = new Point(3, 3);
            txtBeginTermStart.Name = "txtBeginTermStart";
            txtBeginTermStart.Size = new Size(82, 34);
            txtBeginTermStart.TabIndex = 0;
            // 
            // txtEndTermStart
            // 
            txtEndTermStart.Dock = DockStyle.Fill;
            txtEndTermStart.Location = new Point(129, 3);
            txtEndTermStart.Name = "txtEndTermStart";
            txtEndTermStart.Size = new Size(85, 34);
            txtEndTermStart.TabIndex = 2;
            // 
            // lblTermStartTo
            // 
            lblTermStartTo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblTermStartTo.AutoSize = true;
            lblTermStartTo.Location = new Point(91, 6);
            lblTermStartTo.Name = "lblTermStartTo";
            lblTermStartTo.Size = new Size(32, 28);
            lblTermStartTo.TabIndex = 1;
            lblTermStartTo.Text = "To";
            // 
            // gPresident
            // 
            gPresident.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            gPresident.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gPresident.Location = new Point(3, 211);
            gPresident.Name = "gPresident";
            gPresident.RowHeadersWidth = 51;
            gPresident.RowTemplate.Height = 29;
            gPresident.Size = new Size(814, 460);
            gPresident.StandardTab = true;
            gPresident.TabIndex = 1;
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
            tblTermStart.ResumeLayout(false);
            tblTermStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gPresident).EndInit();
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