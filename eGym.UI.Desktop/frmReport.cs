using eGym.BLL.Models;
using System.Diagnostics;

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
                var token = await _service.Get<Token>(null, "/token");
                Process.Start(new ProcessStartInfo($"{APIService._endpoint}Report/finance?token={token.Key}") { UseShellExecute = true });
            }
            catch(Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }
        }

        private async void btnEmployees_Click(object sender, EventArgs e)
        {
            try
            {
                var token = await _service.Get<Token>(null, "/token");
                Process.Start(new ProcessStartInfo($"{APIService._endpoint}Report/employees?token={token.Key}") { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }
        }

        private async void btnUsers_Click(object sender, EventArgs e)
        {
            try
            {
                var token = await _service.Get<Token>(null, "/token");
                Process.Start(new ProcessStartInfo($"{APIService._endpoint}Report/users?token={token.Key}") { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }
        }
    }
}
