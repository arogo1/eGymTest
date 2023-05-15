using eGym.BLL.Models;
using eGym.BLL.Models.Requests;

namespace eGym.UI.Desktop
{
    public partial class frmCreateEmployee : Form
    {
        private readonly APIService _service = new APIService("Employee");

        public frmCreateEmployee()
        {
            InitializeComponent();
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new CreateEmployeeRequest
                {
                    FirstName = txtName.Text,
                    LastName = txtLastName.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    BirthDate = dateTimePicker1.Value.Date,
                    Role = (BLL.Models.Enums.Role)cbRole.SelectedIndex,
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

                await _service.Post<EmployeeDTO>(request);
                MessageBox.Show("Uspjesno krairan uposlenik");
                this.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Desila se greska");
            }
        }
    }
}
