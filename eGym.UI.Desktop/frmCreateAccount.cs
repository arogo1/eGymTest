using eGym.BLL.Models;
using eGym.BLL.Models.Requests;

namespace eGym.UI.Desktop
{
    public partial class frmCreateAccount : Form
    {
        private readonly APIService _service = new APIService("Account");

        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new CreateAccountRequest
                {
                    FirstName = txtName.Text,
                    LastName = txtLastName.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    BirthDate = dateTimePicker1.Value.Date,
                    Email = txtEmail.Text
                };

                if (rbFemale.Checked)
                {
                    request.Gender = BLL.Models.Enums.Gender.Female;
                }
                else
                {
                    request.Gender = BLL.Models.Enums.Gender.Male;
                }

                await _service.Post<AccountDTO>(request);
                MessageBox.Show("Uspjesno krairan korisnik");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }
        }
    }
}
