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
            mnuPresident = new ToolStripMenuItem();
            mnuSearchPres = new ToolStripMenuItem();
            mnuNewPres = new ToolStripMenuItem();
            mnuWindow = new ToolStripMenuItem();
            mnuWindowTile = new ToolStripMenuItem();
            mnuWindowCascade = new ToolStripMenuItem();
            mnuDataMaint = new ToolStripMenuItem();
            mnuDataMaintEdit = new ToolStripMenuItem();
            tsMain = new ToolStrip();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mnuMain.ImageScalingSize = new Size(20, 20);
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuPresident, mnuDataMaint, mnuWindow });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(1100, 36);
            mnuMain.TabIndex = 1;
            mnuMain.Text = "menuStrip1";
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
            mnuDataMaintEdit.Size = new Size(224, 32);
            mnuDataMaintEdit.Text = "Edit Data";
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
    }
}