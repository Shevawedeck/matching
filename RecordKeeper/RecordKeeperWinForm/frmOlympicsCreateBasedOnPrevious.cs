namespace RecordKeeperWinForm
{
    public partial class frmOlympicsCreateBasedOnPrevious : Form
    {
        public frmOlympicsCreateBasedOnPrevious()
        {
            InitializeComponent();
            BindData();
            btnCreate.Click += BtnCreate_Click;
        }
        private void BindData()
        {
            WindowsFormUtility.SetListBinding(lstSeasonName, DataMaintenance.GetDataList("Season", true), null, "Season");
            WindowsFormUtility.SetListBinding(lstCityDesc, DataMaintenance.GetDataList("City", true), null, "City");
            WindowsFormUtility.SetListBinding(lstOlympicDesc, DataMaintenance.GetDataList("Olympics", true), null, "Olympics");
        }
        private void CreateOlympics()
        {
            int seasonid = WindowsFormUtility.GetIdFromComboBox(lstSeasonName);
            int cityid = WindowsFormUtility.GetIdFromComboBox(lstCityDesc);
            int basedonid = WindowsFormUtility.GetIdFromComboBox(lstOlympicDesc);
            int year = 0;
            int.TryParse(txtYear.Text, out year);
            Cursor = Cursors.WaitCursor;
            try
            {
                Olympics.CreateOlympicsBasedOnPrevious(seasonid, cityid, year, basedonid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally 
            {
                Cursor = Cursors.Default;
            }
        }
        private void BtnCreate_Click(object? sender, EventArgs e)
        {
            CreateOlympics();
        }
    }
}
