namespace RecordKeeperWinForm
{
    partial class frmPresident
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPresident));
            tblMain = new TableLayoutPanel();
            lblCaptionParty = new Label();
            lblCaptionNum = new Label();
            lblCaptionFirstName = new Label();
            lblCaptionLastName = new Label();
            lblCaptionDateBorn = new Label();
            lblCaptionDateDied = new Label();
            lblCaptionTermStart = new Label();
            lblCaptionTermEnd = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtDateDied = new TextBox();
            txtTermStart = new TextBox();
            txtTermEnd = new TextBox();
            lstPartyName = new ComboBox();
            txtNum = new TextBox();
            dtpDateBorn = new DateTimePicker();
            tsMain = new ToolStrip();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            ttPresident = new ToolTip(components);
            tbChildRecords = new TabControl();
            tbMedal = new TabPage();
            tbExecutiveOrder = new TabPage();
            tblMedals = new TableLayoutPanel();
            btnSaveMedal = new Button();
            gMedal = new DataGridView();
            tblMain.SuspendLayout();
            tsMain.SuspendLayout();
            tbChildRecords.SuspendLayout();
            tbMedal.SuspendLayout();
            tblMedals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gMedal).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblCaptionParty, 0, 0);
            tblMain.Controls.Add(lblCaptionNum, 0, 1);
            tblMain.Controls.Add(lblCaptionFirstName, 0, 2);
            tblMain.Controls.Add(lblCaptionLastName, 0, 3);
            tblMain.Controls.Add(lblCaptionDateBorn, 0, 4);
            tblMain.Controls.Add(lblCaptionDateDied, 0, 5);
            tblMain.Controls.Add(lblCaptionTermStart, 0, 6);
            tblMain.Controls.Add(lblCaptionTermEnd, 0, 7);
            tblMain.Controls.Add(txtFirstName, 1, 2);
            tblMain.Controls.Add(txtLastName, 1, 3);
            tblMain.Controls.Add(txtDateDied, 1, 5);
            tblMain.Controls.Add(txtTermStart, 1, 6);
            tblMain.Controls.Add(txtTermEnd, 1, 7);
            tblMain.Controls.Add(lstPartyName, 1, 0);
            tblMain.Controls.Add(txtNum, 1, 1);
            tblMain.Controls.Add(dtpDateBorn, 1, 4);
            tblMain.Controls.Add(tbChildRecords, 0, 8);
            tblMain.Location = new Point(0, 43);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 9;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(750, 569);
            tblMain.TabIndex = 0;
            tblMain.TabStop = true;
            // 
            // lblCaptionParty
            // 
            lblCaptionParty.Anchor = AnchorStyles.Left;
            lblCaptionParty.AutoSize = true;
            lblCaptionParty.Location = new Point(3, 7);
            lblCaptionParty.Name = "lblCaptionParty";
            lblCaptionParty.Size = new Size(56, 28);
            lblCaptionParty.TabIndex = 0;
            lblCaptionParty.Text = "Party";
            // 
            // lblCaptionNum
            // 
            lblCaptionNum.Anchor = AnchorStyles.Left;
            lblCaptionNum.AutoSize = true;
            lblCaptionNum.Location = new Point(3, 48);
            lblCaptionNum.Name = "lblCaptionNum";
            lblCaptionNum.Size = new Size(55, 28);
            lblCaptionNum.TabIndex = 2;
            lblCaptionNum.Text = "Num";
            // 
            // lblCaptionFirstName
            // 
            lblCaptionFirstName.Anchor = AnchorStyles.Left;
            lblCaptionFirstName.AutoSize = true;
            lblCaptionFirstName.Location = new Point(3, 88);
            lblCaptionFirstName.Name = "lblCaptionFirstName";
            lblCaptionFirstName.Size = new Size(106, 28);
            lblCaptionFirstName.TabIndex = 4;
            lblCaptionFirstName.Text = "First Name";
            // 
            // lblCaptionLastName
            // 
            lblCaptionLastName.Anchor = AnchorStyles.Left;
            lblCaptionLastName.AutoSize = true;
            lblCaptionLastName.Location = new Point(3, 128);
            lblCaptionLastName.Name = "lblCaptionLastName";
            lblCaptionLastName.Size = new Size(103, 28);
            lblCaptionLastName.TabIndex = 6;
            lblCaptionLastName.Text = "Last Name";
            // 
            // lblCaptionDateBorn
            // 
            lblCaptionDateBorn.Anchor = AnchorStyles.Left;
            lblCaptionDateBorn.AutoSize = true;
            lblCaptionDateBorn.Location = new Point(3, 168);
            lblCaptionDateBorn.Name = "lblCaptionDateBorn";
            lblCaptionDateBorn.Size = new Size(99, 28);
            lblCaptionDateBorn.TabIndex = 8;
            lblCaptionDateBorn.Text = "Date Born";
            // 
            // lblCaptionDateDied
            // 
            lblCaptionDateDied.Anchor = AnchorStyles.Left;
            lblCaptionDateDied.AutoSize = true;
            lblCaptionDateDied.Location = new Point(3, 208);
            lblCaptionDateDied.Name = "lblCaptionDateDied";
            lblCaptionDateDied.Size = new Size(99, 28);
            lblCaptionDateDied.TabIndex = 10;
            lblCaptionDateDied.Text = "Date Died";
            // 
            // lblCaptionTermStart
            // 
            lblCaptionTermStart.Anchor = AnchorStyles.Left;
            lblCaptionTermStart.AutoSize = true;
            lblCaptionTermStart.Location = new Point(3, 248);
            lblCaptionTermStart.Name = "lblCaptionTermStart";
            lblCaptionTermStart.Size = new Size(100, 28);
            lblCaptionTermStart.TabIndex = 12;
            lblCaptionTermStart.Text = "Term Start";
            // 
            // lblCaptionTermEnd
            // 
            lblCaptionTermEnd.Anchor = AnchorStyles.Left;
            lblCaptionTermEnd.AutoSize = true;
            lblCaptionTermEnd.Location = new Point(3, 288);
            lblCaptionTermEnd.Name = "lblCaptionTermEnd";
            lblCaptionTermEnd.Size = new Size(92, 28);
            lblCaptionTermEnd.TabIndex = 14;
            lblCaptionTermEnd.Text = "Term End";
            // 
            // txtFirstName
            // 
            txtFirstName.Dock = DockStyle.Top;
            txtFirstName.Location = new Point(115, 85);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(632, 34);
            txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Dock = DockStyle.Top;
            txtLastName.Location = new Point(115, 125);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(632, 34);
            txtLastName.TabIndex = 7;
            // 
            // txtDateDied
            // 
            txtDateDied.Dock = DockStyle.Top;
            txtDateDied.Location = new Point(115, 205);
            txtDateDied.Name = "txtDateDied";
            txtDateDied.Size = new Size(632, 34);
            txtDateDied.TabIndex = 11;
            // 
            // txtTermStart
            // 
            txtTermStart.Dock = DockStyle.Top;
            txtTermStart.Location = new Point(115, 245);
            txtTermStart.Name = "txtTermStart";
            txtTermStart.Size = new Size(632, 34);
            txtTermStart.TabIndex = 13;
            ttPresident.SetToolTip(txtTermStart, "Enter a Year not a Date");
            // 
            // txtTermEnd
            // 
            txtTermEnd.Dock = DockStyle.Top;
            txtTermEnd.Location = new Point(115, 285);
            txtTermEnd.Name = "txtTermEnd";
            txtTermEnd.Size = new Size(632, 34);
            txtTermEnd.TabIndex = 15;
            ttPresident.SetToolTip(txtTermEnd, "Enter a Year not a Date");
            // 
            // lstPartyName
            // 
            lstPartyName.FormattingEnabled = true;
            lstPartyName.Location = new Point(115, 3);
            lstPartyName.Name = "lstPartyName";
            lstPartyName.Size = new Size(225, 36);
            lstPartyName.TabIndex = 1;
            // 
            // txtNum
            // 
            txtNum.Dock = DockStyle.Fill;
            txtNum.Location = new Point(115, 45);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(632, 34);
            txtNum.TabIndex = 3;
            // 
            // dtpDateBorn
            // 
            dtpDateBorn.Format = DateTimePickerFormat.Short;
            dtpDateBorn.Location = new Point(115, 165);
            dtpDateBorn.Name = "dtpDateBorn";
            dtpDateBorn.Size = new Size(132, 34);
            dtpDateBorn.TabIndex = 9;
            // 
            // tsMain
            // 
            tsMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete, toolStripSeparator2 });
            tsMain.Location = new Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(750, 35);
            tsMain.TabIndex = 1;
            tsMain.Text = "toolStrip1";
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(57, 32);
            btnSave.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 35);
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(72, 32);
            btnDelete.Text = "Delete";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 35);
            // 
            // tbChildRecords
            // 
            tblMain.SetColumnSpan(tbChildRecords, 2);
            tbChildRecords.Controls.Add(tbMedal);
            tbChildRecords.Controls.Add(tbExecutiveOrder);
            tbChildRecords.Dock = DockStyle.Fill;
            tbChildRecords.Location = new Point(3, 325);
            tbChildRecords.Name = "tbChildRecords";
            tbChildRecords.SelectedIndex = 0;
            tbChildRecords.Size = new Size(744, 241);
            tbChildRecords.TabIndex = 16;
            // 
            // tbMedal
            // 
            tbMedal.Controls.Add(tblMedals);
            tbMedal.Location = new Point(4, 37);
            tbMedal.Name = "tbMedal";
            tbMedal.Padding = new Padding(3);
            tbMedal.Size = new Size(736, 200);
            tbMedal.TabIndex = 0;
            tbMedal.Text = "Medals";
            tbMedal.UseVisualStyleBackColor = true;
            // 
            // tbExecutiveOrder
            // 
            tbExecutiveOrder.Location = new Point(4, 37);
            tbExecutiveOrder.Name = "tbExecutiveOrder";
            tbExecutiveOrder.Padding = new Padding(3);
            tbExecutiveOrder.Size = new Size(736, 99);
            tbExecutiveOrder.TabIndex = 1;
            tbExecutiveOrder.Text = "Executive Orders";
            tbExecutiveOrder.UseVisualStyleBackColor = true;
            // 
            // tblMedals
            // 
            tblMedals.ColumnCount = 1;
            tblMedals.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMedals.Controls.Add(btnSaveMedal, 0, 0);
            tblMedals.Controls.Add(gMedal, 0, 1);
            tblMedals.Dock = DockStyle.Fill;
            tblMedals.Location = new Point(3, 3);
            tblMedals.Name = "tblMedals";
            tblMedals.RowCount = 2;
            tblMedals.RowStyles.Add(new RowStyle());
            tblMedals.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMedals.Size = new Size(730, 194);
            tblMedals.TabIndex = 0;
            // 
            // btnSaveMedal
            // 
            btnSaveMedal.AutoSize = true;
            btnSaveMedal.Location = new Point(3, 3);
            btnSaveMedal.Name = "btnSaveMedal";
            btnSaveMedal.Size = new Size(94, 38);
            btnSaveMedal.TabIndex = 0;
            btnSaveMedal.Text = "Save";
            btnSaveMedal.UseVisualStyleBackColor = true;
            // 
            // gMedal
            // 
            gMedal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gMedal.Dock = DockStyle.Fill;
            gMedal.Location = new Point(3, 47);
            gMedal.Name = "gMedal";
            gMedal.RowHeadersWidth = 51;
            gMedal.RowTemplate.Height = 29;
            gMedal.Size = new Size(724, 144);
            gMedal.TabIndex = 1;
            // 
            // frmPresident
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 613);
            Controls.Add(tsMain);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmPresident";
            Text = "President";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            tbChildRecords.ResumeLayout(false);
            tbMedal.ResumeLayout(false);
            tblMedals.ResumeLayout(false);
            tblMedals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gMedal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionParty;
        private Label lblCaptionNum;
        private Label lblCaptionFirstName;
        private Label lblCaptionLastName;
        private Label lblCaptionDateBorn;
        private Label lblCaptionDateDied;
        private Label lblCaptionTermStart;
        private Label lblCaptionTermEnd;
        private Label lblParty;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtDateDied;
        private TextBox txtTermStart;
        private TextBox txtTermEnd;
        private ToolStrip tsMain;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator2;
        private ComboBox lstPartyName;
        private TextBox txtNum;
        private DateTimePicker dtpDateBorn;
        private ToolTip ttPresident;
        private TabControl tbChildRecords;
        private TabPage tbMedal;
        private TableLayoutPanel tblMedals;
        private Button btnSaveMedal;
        private DataGridView gMedal;
        private TabPage tbExecutiveOrder;
    }
}