using eGym.BLL.Models.Requests;

namespace eGym.UI.Desktop
{
    public partial class frmLogin : Form
    {
        private readonly APIService _apiService = new APIService("Employee");

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            APIService.Username = txbUsername.Text;
            APIService.Password = txbPassword.Text;

            try
            {
                var request = new LoginRequest() 
                {
                    Username = txbUsername.Text,
                    Password = txbPassword.Text
                };
                var result = await _apiService.Login<dynamic>(request, "/login");

                frmMain frm = new frmMain();
                frm.Show();

                //this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong username or password");
            }
        }
    }
}
