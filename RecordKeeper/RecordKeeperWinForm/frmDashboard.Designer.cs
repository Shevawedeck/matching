namespace RecordKeeperWinForm
{
    partial class frmDashboard
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
            lblWelcome = new Label();
            lblDescription = new Label();
            btnPresident = new Button();
            btnOlympics = new Button();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(lblWelcome, 0, 0);
            tblMain.Controls.Add(lblDescription, 0, 1);
            tblMain.Controls.Add(btnPresident, 0, 2);
            tblMain.Controls.Add(btnOlympics, 0, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4, 10, 4, 50);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 5;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(1100, 630);
            tblMain.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.Location = new Point(4, 10);
            lblWelcome.Margin = new Padding(4, 10, 4, 50);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(380, 41);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to Record Keeper";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.Location = new Point(4, 101);
            lblDescription.Margin = new Padding(4, 0, 4, 50);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(133, 38);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "This app..";
            // 
            // btnPresident
            // 
            btnPresident.Dock = DockStyle.Fill;
            btnPresident.Location = new Point(40, 199);
            btnPresident.Margin = new Padding(40, 10, 40, 10);
            btnPresident.Name = "btnPresident";
            btnPresident.Size = new Size(1020, 41);
            btnPresident.TabIndex = 2;
            btnPresident.UseVisualStyleBackColor = true;
            // 
            // btnOlympics
            // 
            btnOlympics.Dock = DockStyle.Fill;
            btnOlympics.Location = new Point(40, 260);
            btnOlympics.Margin = new Padding(40, 10, 40, 10);
            btnOlympics.Name = "btnOlympics";
            btnOlympics.Size = new Size(1020, 41);
            btnOlympics.TabIndex = 3;
            btnOlympics.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmDashboard";
            Text = "Dashboard";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblWelcome;
        private Label lblDescription;
        private Button btnPresident;
        private Button btnOlympics;
    }
}