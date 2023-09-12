namespace RecordKeeperWinForm
{
    partial class frmMain
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
            mnuMain = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuDashboard = new ToolStripMenuItem();
            mnuPresident = new ToolStripMenuItem();
            mnuSearchPres = new ToolStripMenuItem();
            mnuNewPres = new ToolStripMenuItem();
            mnuOlympics = new ToolStripMenuItem();
            mnuOlympicsList = new ToolStripMenuItem();
            mnuOlympicsCreateNewBasedOn = new ToolStripMenuItem();
            mnuDataMaint = new ToolStripMenuItem();
            mnuDataMaintEdit = new ToolStripMenuItem();
            mnuWindow = new ToolStripMenuItem();
            mnuWindowTile = new ToolStripMenuItem();
            mnuWindowCascade = new ToolStripMenuItem();
            tsMain = new ToolStrip();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mnuMain.ImageScalingSize = new Size(20, 20);
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuFile, mnuPresident, mnuOlympics, mnuDataMaint, mnuWindow });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(1100, 36);
            mnuMain.TabIndex = 1;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuDashboard });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(56, 32);
            mnuFile.Text = "File";
            // 
            // mnuDashboard
            // 
            mnuDashboard.Name = "mnuDashboard";
            mnuDashboard.Size = new Size(194, 32);
            mnuDashboard.Text = "Dashboard";
            // 
            // mnuPresident
            // 
            mnuPresident.DropDownItems.AddRange(new ToolStripItem[] { mnuSearchPres, mnuNewPres });
            mnuPresident.Name = "mnuPresident";
            mnuPresident.Size = new Size(107, 32);
            mnuPresident.Text = "President";
            // 
            // mnuSearchPres
            // 
            mnuSearchPres.Name = "mnuSearchPres";
            mnuSearchPres.Size = new Size(223, 32);
            mnuSearchPres.Text = "Search";
            // 
            // mnuNewPres
            // 
            mnuNewPres.Name = "mnuNewPres";
            mnuNewPres.Size = new Size(223, 32);
            mnuNewPres.Text = "New President";
            // 
            // mnuOlympics
            // 
            mnuOlympics.DropDownItems.AddRange(new ToolStripItem[] { mnuOlympicsList, mnuOlympicsCreateNewBasedOn });
            mnuOlympics.Name = "mnuOlympics";
            mnuOlympics.Size = new Size(107, 32);
            mnuOlympics.Text = "Olympics";
            // 
            // mnuOlympicsList
            // 
            mnuOlympicsList.Name = "mnuOlympicsList";
            mnuOlympicsList.Size = new Size(362, 32);
            mnuOlympicsList.Text = "List Of Olympics";
            // 
            // mnuOlympicsCreateNewBasedOn
            // 
            mnuOlympicsCreateNewBasedOn.Name = "mnuOlympicsCreateNewBasedOn";
            mnuOlympicsCreateNewBasedOn.Size = new Size(362, 32);
            mnuOlympicsCreateNewBasedOn.Text = "Create New based on Previous";
            // 
            // mnuDataMaint
            // 
            mnuDataMaint.DropDownItems.AddRange(new ToolStripItem[] { mnuDataMaintEdit });
            mnuDataMaint.Name = "mnuDataMaint";
            mnuDataMaint.Size = new Size(184, 32);
            mnuDataMaint.Text = "Data Maintenence";
            // 
            // mnuDataMaintEdit
            // 
            mnuDataMaintEdit.Name = "mnuDataMaintEdit";
            mnuDataMaintEdit.Size = new Size(178, 32);
            mnuDataMaintEdit.Text = "Edit Data";
            // 
            // mnuWindow
            // 
            mnuWindow.DropDownItems.AddRange(new ToolStripItem[] { mnuWindowTile, mnuWindowCascade });
            mnuWindow.Name = "mnuWindow";
            mnuWindow.Size = new Size(99, 32);
            mnuWindow.Text = "Window";
            // 
            // mnuWindowTile
            // 
            mnuWindowTile.Name = "mnuWindowTile";
            mnuWindowTile.Size = new Size(169, 32);
            mnuWindowTile.Text = "Tile";
            // 
            // mnuWindowCascade
            // 
            mnuWindowCascade.Name = "mnuWindowCascade";
            mnuWindowCascade.Size = new Size(169, 32);
            mnuWindowCascade.Text = "Cascade";
            // 
            // tsMain
            // 
            tsMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Location = new Point(0, 36);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(1100, 25);
            tsMain.TabIndex = 3;
            tsMain.Text = "toolStrip1";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(tsMain);
            Controls.Add(mnuMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IsMdiContainer = true;
            MainMenuStrip = mnuMain;
            Margin = new Padding(4);
            Name = "frmMain";
            Text = "RecordKeeper";
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuPresident;
        private ToolStripMenuItem mnuSearchPres;
        private ToolStripMenuItem mnuNewPres;
        private ToolStripMenuItem mnuWindow;
        private ToolStripMenuItem mnuWindowTile;
        private ToolStripMenuItem mnuWindowCascade;
        private ToolStrip tsMain;
        private ToolStripMenuItem mnuDataMaint;
        private ToolStripMenuItem mnuDataMaintEdit;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuDashboard;
        private ToolStripMenuItem mnuOlympics;
        private ToolStripMenuItem mnuOlympicsList;
        private ToolStripMenuItem mnuOlympicsCreateNewBasedOn;
    }
}