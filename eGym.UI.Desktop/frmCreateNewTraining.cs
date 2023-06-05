using eGym.BLL.Models;
using eGym.BLL.Models.Requests;

namespace eGym.UI.Desktop
{
    public partial class frmCreateNewTraining : Form
    {
        private readonly APIService _service = new APIService("Training");
        private AccountDTO selectedUser;

        public frmCreateNewTraining(AccountDTO user)
        {
            selectedUser = user;
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new CreateTrainingRequest()
                {
                    AccountId = selectedUser.AccountId,
                    Day = (DayOfWeek)cmbDay.SelectedIndex,
                    Description = rtxtDescription.Text
                };

                await _service.Post<TrainingDTO>(request);

                MessageBox.Show("Uspjesno kreiran");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }
        }

        private void frmCreateNewTraining_Load(object sender, EventArgs e)
        {
            txtName.Text = selectedUser.FirstName + " " + selectedUser.LastName;
        }
    }
}
