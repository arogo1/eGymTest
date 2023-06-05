using eGym.BLL.Models;
using eGym.BLL.Models.Requests;

namespace eGym.UI.Desktop
{
    public partial class frmDiet : Form
    {
        private readonly APIService _service = new APIService("Diet");
        private readonly APIService _userService = new APIService("Account");
        private AccountDTO selectedUser;
        private DietDTO selectedDiet;

        public frmDiet()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvAccount.DataSource = await _userService.Get<List<AccountDTO>>(new { text = txtSearch.Text }, "/search");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }
        }

        private async void frmDiet_Load(object sender, EventArgs e)
        {
            try
            {
                dgvAccount.DataSource = await _userService.Get<List<AccountDTO>>(null, "/getAll");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new UpdateDietRequest()
                {
                    Day = (DayOfWeek)cmbDay.SelectedIndex,
                    Meal = (BLL.Models.Enums.Meal)cmbMeal.SelectedIndex,
                    Description = rtxtDescription.Text
                };

                await _service.Put<DietDTO>(selectedDiet.DietId, request);

                MessageBox.Show("Uspjesno updatovan");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }
        }

        private async void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            selectedUser = dgvAccount.Rows[index].DataBoundItem as AccountDTO;

            txtName.Text = selectedUser.FirstName + " " + selectedUser.LastName;

            try
            {
                dgvDiet.DataSource = await _service.Get<List<DietDTO>>(new { userId = selectedUser.AccountId }, "/getByUserId");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }
        }

        private void dgvDiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            selectedDiet = dgvDiet.Rows[index].DataBoundItem as DietDTO;

            cmbDay.SelectedIndex = (int)selectedDiet.Day;
            cmbMeal.SelectedIndex = (int)selectedDiet.Meal;
            rtxtDescription.Text = selectedDiet.Description;
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            if (selectedUser == null) 
            {
                MessageBox.Show("Morate odabrati korisnika");
                return;
            };
            frmCreateNewDiet frm = new frmCreateNewDiet(selectedUser);
            frm.Show();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                await _service.Delete(selectedDiet.DietId);

                dgvDiet.DataSource = await _service.Get<List<DietDTO>>(new { userId = selectedUser.AccountId }, "/getByUserId");
                cmbDay.SelectedIndex = 0;
                cmbDay.SelectedIndex = 0;
                rtxtDescription.Text = "";

                MessageBox.Show("Uspjesno obrisan unos");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }
        }
    }
}
