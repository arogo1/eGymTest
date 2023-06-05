using eGym.BLL.Models;
using eGym.BLL.Models.Requests;

namespace eGym.UI.Desktop
{
    public partial class frmEmployee : Form
    {
        private readonly APIService _service = new APIService("Employee");
        private EmployeeDTO selectedEmployee = new EmployeeDTO();

        public frmEmployee()
        {
            InitializeComponent();
        }

        private async void frmEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                dgvEmployee.DataSource = await _service.Get<List<EmployeeDTO>>(null, "/getAll");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvEmployee.DataSource = await _service.Get<List<EmployeeDTO>>(new { text = txtSearch.Text }, "/search");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                await _service.Delete(new { id = selectedEmployee.EmployeeId });

                dgvEmployee.DataSource = await _service.Get<List<EmployeeDTO>>(null, "/getAll");

                MessageBox.Show("Uspjesno obirsan uposlenik");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new UpdateAccountRequest()
                {
                    FirstName = txtName.Text,
                    LastName = txtLastName.Text,
                    BirthDate = dateTimePicker1.Value,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text
                };

                await _service.Put<EmployeeDTO>(selectedEmployee.EmployeeId, request);

                dgvEmployee.DataSource = await _service.Get<List<EmployeeDTO>>(null, "/getAll");

                MessageBox.Show("Uspjesno updatevon uposlenik");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            frmCreateEmployee frm = new frmCreateEmployee();

            frm.Show();

            //this.Close();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            selectedEmployee = dgvEmployee.Rows[index].DataBoundItem as EmployeeDTO;

            txtId.Text = selectedEmployee.EmployeeId.ToString();
            txtName.Text = selectedEmployee.FirstName;
            txtLastName.Text = selectedEmployee.LastName;
            txtPassword.Text = selectedEmployee.Password;
            txtUsername.Text = selectedEmployee.Username;
            dateTimePicker1.Value = selectedEmployee.BirthDate;
            comboBox1.SelectedIndex = (int)selectedEmployee.Role;

            if(selectedEmployee.Gender == BLL.Models.Enums.Gender.Female)
            {
                rbZensko.Checked = true;
            }
            else
            {
                rbMale.Checked = true;
            }
        }
    }
}
