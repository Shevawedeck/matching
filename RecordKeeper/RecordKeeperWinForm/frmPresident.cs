using System.Data;
using System.Diagnostics;

namespace RecordKeeperWinForm
{
    public partial class frmPresident : Form
    {
        DataTable dtpresident;
        public frmPresident()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        public void ShowForm(int presidentid)
        {
            dtpresident = President.Load(presidentid);
            if (presidentid == 0) { dtpresident.Rows.Add(); }
            DataTable dtparty = President.GetPartyList();
            WindowsFormUtility.SetListBinding(lstPartyName, dtparty, dtpresident, "Party");
            WindowsFormUtility.SetControlBinding(txtNum, dtpresident);
            WindowsFormUtility.SetControlBinding(txtLastName, dtpresident);
            WindowsFormUtility.SetControlBinding(txtFirstName, dtpresident);
            WindowsFormUtility.SetControlBinding(dtpDateBorn, dtpresident);
            WindowsFormUtility.SetControlBinding(txtDateDied, dtpresident);
            WindowsFormUtility.SetControlBinding(txtTermStart, dtpresident);
            WindowsFormUtility.SetControlBinding(txtTermEnd, dtpresident);
            this.Show();
        }
        private void Save()
        {
            President.Save(dtpresident);
        }
        private void Delete()
        {
            President.Delete(dtpresident);
            this.Close();
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}
