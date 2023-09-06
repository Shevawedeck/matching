using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordKeeperWinForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            mnuSearchPres.Click += MnuSearchPres_Click;
            mnuNewPres.Click += MnuNewPres_Click;
            mnuWindowTile.Click += MnuWindowTile_Click;
            mnuWindowCascade.Click += MnuWindowCascade_Click;
            mnuDataMaintEdit.Click += MnuDataMaintEdit_Click;
        }
        public void OpenForm(Type frmtype, int pkvalue = 0)
        {
            bool b = WindowsFormUtility.IsFormOpen(frmtype);
            if (b == false)
            {
                Form? newfrm = null;
                if (frmtype == typeof(frmPresident))
                {
                    frmPresident f = new frmPresident();
                    newfrm = f;
                    f.ShowForm(pkvalue);
                }
                else if (frmtype == typeof(frmSearch))
                {
                    frmSearch f = new();
                    newfrm = f;
                    f.Show();
                }
                else if (frmtype == typeof(frmDataMaintenence))
                {
                    frmDataMaintenence f = new();
                    newfrm = f;
                    f.Show();
                }
                if (newfrm != null)
                {
                    newfrm.MdiParent = this;
                    newfrm.WindowState = FormWindowState.Maximized;
                    newfrm.FormClosed += Frm_FormClosed;
                    newfrm.TextChanged += Newfrm_TextChanged;
                }
                WindowsFormUtility.SetUpNav(tsMain);
            }
        }

        private void Newfrm_TextChanged(object? sender, EventArgs e)
        {
            WindowsFormUtility.SetUpNav(tsMain);
        }

        private void Frm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            WindowsFormUtility.SetUpNav(tsMain);
        }
        private void MnuWindowCascade_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MnuWindowTile_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void MnuNewPres_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmPresident));
        }

        private void MnuSearchPres_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmSearch));
        }
        private void MnuDataMaintEdit_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDataMaintenence));
        }
    }
}
