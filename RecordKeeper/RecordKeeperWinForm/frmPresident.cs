﻿
namespace RecordKeeperWinForm
{
    public partial class frmPresident : Form
    {
        DataTable dtpresident = new DataTable();
        DataTable dtpresidentmedal = new DataTable();
        BindingSource bindsource = new BindingSource();
        string deletecolname = "deletecol";
        int presidentid = 0;
        public frmPresident()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            this.FormClosing += FrmPresident_FormClosing;
            btnSaveMedal.Click += BtnSaveMedal_Click;
            gMedal.CellContentClick += GMedal_CellContentClick;
        }
        public void LoadForm(int presidentidval)
        {
            presidentid = presidentidval;
            this.Tag = presidentid;
            dtpresident = President.Load(presidentid);
            bindsource.DataSource = dtpresident;
            if (presidentid == 0)
            {
                dtpresident.Rows.Add();
            }
            DataTable dtparty = President.GetPartyList();
            WindowsFormUtility.SetListBinding(lstPartyName, dtparty, dtpresident, "Party");
            WindowsFormUtility.SetControlBinding(txtNum, bindsource);
            WindowsFormUtility.SetControlBinding(txtLastName, bindsource);
            WindowsFormUtility.SetControlBinding(txtFirstName, bindsource);
            WindowsFormUtility.SetControlBinding(dtpDateBorn, bindsource);
            WindowsFormUtility.SetControlBinding(txtDateDied, bindsource);
            WindowsFormUtility.SetControlBinding(txtTermStart, bindsource);
            WindowsFormUtility.SetControlBinding(txtTermEnd, bindsource);
            this.Text = GetPresidentDesc();
            LoadPresidentMedals();
            SetButtonsEnabledBasedOnNew();
        }
        private void LoadPresidentMedals()
        {
            dtpresidentmedal = PresidentMedal.LoadByPresidentId(presidentid);
            gMedal.Columns.Clear();
            gMedal.DataSource = dtpresidentmedal;
            WindowsFormUtility.AddComboBoxToGrid(gMedal, DataMaintenance.GetDataList("Medal"), "Medal", "MedalName");
            WindowsFormUtility.AddDeleteButtonToGrid(gMedal, deletecolname);
            WindowsFormUtility.FormatGridForEdit(gMedal, "PresidentMedal");
        }
        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                President.Save(dtpresident);
                b = true;
                bindsource.ResetBindings(false);
                presidentid = SQLUtility.GetValueFromFirstRowAsInt(dtpresident, "PresidentId");
                this.Tag = presidentid;
                SetButtonsEnabledBasedOnNew();
                this.Text = GetPresidentDesc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "RecordKeeper");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }
        private void Delete()
        {
            string alloweddelete = SQLUtility.GetValueFromFirstRowAsString(dtpresident, "IsDeleteAllowed");
            if (alloweddelete != "")
            {
                MessageBox.Show(alloweddelete, Application.ProductName);
                return;
            }
            var response = MessageBox.Show("Are you sure you want to delete this president?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                President.Delete(dtpresident);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }
        private void SavePresidentMedal()
        {
            try
            {

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            PresidentMedal.SaveTable(dtpresidentmedal, presidentid);
        }
        private void DeletePresidentMedal(int rowindex)
        {
            int id = WindowsFormUtility.GetIdFromGrid(gMedal, rowindex, "PresidentMedalId");
            if(id > 0)
            {
                try
                {
                    PresidentMedal.Delete(id);
                    LoadPresidentMedals();
                }
                catch(Exception ex )
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if(id < gMedal.Rows.Count)
            {
                gMedal.Rows.RemoveAt(rowindex);
            }
        }
        private void SetButtonsEnabledBasedOnNew()
        {
            bool b = presidentid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnSaveMedal.Enabled = b;
        }
        private string GetPresidentDesc()
        {
            string value = "New President";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtpresident, "PresidentId");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsInt(dtpresident, "Num") + " " + SQLUtility.GetValueFromFirstRowAsString(dtpresident, "LastName");
            }
            return value;
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
        private void FrmPresident_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtpresident))
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing the form?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }

        }
        private void BtnSaveMedal_Click(object? sender, EventArgs e)
        {
            SavePresidentMedal();
        }
        private void GMedal_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeletePresidentMedal(e.RowIndex);
        }
    }
}
