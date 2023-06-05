using eGym.BLL.Models;
using eGym.BLL.Models.Requests;

namespace eGym.UI.Desktop
{
    public partial class frmTraining : Form
    {
        private readonly APIService _userService = new APIService("Account");
        private readonly APIService _service = new APIService("Training");
        private AccountDTO selectedUser;
        private TrainingDTO selectedTraining;

        public frmTraining()
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

        private async void frmTraining_Load(object sender, EventArgs e)
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
                var request = new UpdateTrainingRequest()
                {
                    Day = (DayOfWeek)cmbDay.SelectedIndex,
                    Description = rtxtDescription.Text
                };

                await _service.Put<TrainingDTO>(selectedTraining.TrainingId, request);

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
                dgvTraining.DataSource = await _service.Get<List<TrainingDTO>>(new { userId = selectedUser.AccountId }, "/getUserTraningPlan");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }
        }

        private void dgvTraining_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            selectedTraining = dgvTraining.Rows[index].DataBoundItem as TrainingDTO;

            cmbDay.SelectedIndex = (int)selectedTraining.Day;
            rtxtDescription.Text = selectedTraining.Description;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                await _service.Delete(selectedTraining.TrainingId);

                dgvTraining.DataSource = await _service.Get<List<TrainingDTO>>(new { userId = selectedUser.AccountId }, "/getUserTraningPlan");
                cmbDay.SelectedIndex = 0;
                cmbDay.SelectedIndex = 0;
                rtxtDescription.Text = "";

                MessageBox.Show("Uspjesno obrisan unos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }
        }

        private void btnCreateNewTraining_Click(object sender, EventArgs e)
        {
            if(selectedUser == null)
            {
                MessageBox.Show("Morate odabrati korisnika");
                return;
            }
            frmCreateNewTraining frm = new frmCreateNewTraining(selectedUser);
            frm.Show();
        }
    }
}
