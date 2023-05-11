namespace eGym.UI.Desktop
{
    public partial class frmReport : Form
    {
        private readonly APIService _service = new APIService("Report");
        public frmReport()
        {
            InitializeComponent();
        }

        private async void btnFinance_Click(object sender, EventArgs e)
        {
            try
            {
                await _service.Get("finance");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
