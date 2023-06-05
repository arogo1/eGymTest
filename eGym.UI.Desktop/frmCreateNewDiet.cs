using eGym.BLL.Models;
using eGym.BLL.Models.Requests;

namespace eGym.UI.Desktop
{
    public partial class frmCreateNewDiet : Form
    {
        private readonly APIService _service = new APIService("Diet");
        private readonly AccountDTO selectedUser;

        public frmCreateNewDiet(AccountDTO user)
        {
            selectedUser = user;
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new CreateDietRequest()
                {
                    AccountId = selectedUser.AccountId,
                    Day = (DayOfWeek)cmbDay.SelectedIndex,
                    Meal = (BLL.Models.Enums.Meal)cmbMeal.SelectedIndex,
                    Description = rtxtDescription.Text
                };

                await _service.Post<DietDTO>(request);

                MessageBox.Show("Uspjesno kreiran");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Desila se greska");
            }
        }

        private void frmCreateNewDiet_Load(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text = selectedUser.FirstName + " " + selectedUser.LastName;
        }
    }
}
