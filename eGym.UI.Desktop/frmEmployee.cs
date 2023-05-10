using eGym.BLL.Models;

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
            dgvEmployee.DataSource = await _service.Get<List<EmployeeDTO>>(null, "/getAll");
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            dgvEmployee.DataSource = await _service.Get<List<EmployeeDTO>>(new { text = txtSearch.Text}, "/search");
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            await _service.Delete(selectedEmployee.EmployeeId);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            await _service.Put<EmployeeDTO>(selectedEmployee.EmployeeId, null);
        }

        private void dgvKorisinici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvEmployee.SelectedRows[0].DataBoundItem as EmployeeDTO;

            selectedEmployee = item;
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
