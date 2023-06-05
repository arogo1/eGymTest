using eGym.BLL.Models;
using eGym.BLL.Models.Requests;

namespace eGym.UI.Desktop
{
    public partial class frmAccount : Form
    {
        private readonly APIService _service = new APIService("Account");
        private AccountDTO selectedUser;

        public frmAccount()
        {
            InitializeComponent();
        }

        private async void frmAccount_Load(object sender, EventArgs e)
        {
            try
            {
                dgvAccount.DataSource = await _service.Get<List<AccountDTO>>(null, "/getAll");
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Desila se greska");
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvAccount.DataSource = await _service.Get<List<AccountDTO>>(new { text = txtSearch.Text }, "/search");
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Desila se greska");
            }

        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            selectedUser = dgvAccount.Rows[index].DataBoundItem as AccountDTO;

            txtId.Text = selectedUser.AccountId.ToString();
            txtName.Text = selectedUser.FirstName;
            txtLastName.Text = selectedUser.LastName;
            txtPassword.Text = selectedUser.Password;
            txtUsername.Text = selectedUser.Username;
            dateTimePicker1.Value = selectedUser.BirthDate;

            if (selectedUser.Gender == BLL.Models.Enums.Gender.Female)
            {
                rbZensko.Checked = true;
            }
            else
            {
                rbMale.Checked = true;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                await _service.Delete(new { id = selectedUser.AccountId });

                dgvAccount.DataSource = await _service.Get<List<AccountDTO>>(null, "/getAll");

                MessageBox.Show("Uspjesno obrisan korisnik");
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

                await _service.Put<AccountDTO>(selectedUser.AccountId, request);

                dgvAccount.DataSource = await _service.Get<List<AccountDTO>>(null, "/getAll");

                MessageBox.Show("Uspjesno updatevon korisnik");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            frmCreateAccount frm = new frmCreateAccount();
            frm.Show();
        }
    }
}
