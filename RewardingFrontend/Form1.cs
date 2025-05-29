using RewardingFrontend.Models;
using RewardingFrontend.Services;
using System.Text;

namespace RewardingFrontend
{
    public partial class RewardingForm : Form
    {
        public RewardingForm()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToShortDateString();
            InitializeDeputiesComboBox();
        }

        private ApiService apiService = new ApiService();
        private Guid DeputyId { get; set; }
        private Guid? DirectorId { get; set; }
        private Guid WorkerId { get; set; }

        private async void InitializeDeputiesComboBox()
        {
            var deputies = await apiService.GetEmployeesByRole("Deputy");
            var deputiesNames = new List<string>();
            foreach (var deputy in deputies)
            {
                string name = $"{deputy.LastName} {deputy.FirstName} {deputy.Patronimic}";
                deputiesNames.Add(name);
            }
            deputiesComboBox.DataSource = deputiesNames;
            deputiesComboBox.SelectedIndexChanged += deputiesComboBox_SelectedIndexChanged;
        }

        private async void InitializeWorkersComboBox()
        {
            var workers = await apiService.GetSubordinates(DeputyId);
            var workersNames = new List<string>();
            foreach (var worker in workers)
            {
                string name = $"{worker.LastName} {worker.FirstName} {worker.Patronimic}";
                workersNames.Add(name);
            }
            workersComboBox.DataSource = workersNames;
            workersComboBox.SelectedIndexChanged += workersComboBox_SelectedIndexChanged;
        }

        private async void deputiesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var deputies = await apiService.GetEmployeesByRole("Deputy");
            var index = deputiesComboBox.SelectedIndex;
            Employee deputy = deputies[index];
            DeputyId = deputy.EmployeeId;
            DirectorId = deputy.ManagerId;

            directorLabel.Visible = true;
            directorTextBox.Visible = true;

            var director = await apiService.GetEmployeeById(DirectorId);
            directorTextBox.Text = $"{director.FirstName} {director.LastName} {director.Patronimic}";

            InitializeWorkersComboBox();
            workerLabel.Visible = true;
            workersComboBox.Visible = true;

        }

        private async void workersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var workers = await apiService.GetEmployeesByRole("Worker");
            var index = workersComboBox.SelectedIndex;
            Employee worker = workers[index];
            WorkerId = worker.EmployeeId;

            rewardLabel.Visible = true;
            rewardTextBox.Visible = true;
            saveButton.Visible = true;
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rewardTextBox.Text))
            {
                MessageBox.Show("Введите текст поощрения", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new CreateRewardtDto
            {
                EmployeeId = WorkerId,
                RewardText = rewardTextBox.Text
            };

            bool isSuccess = await apiService.AddReward(dto);

            if (isSuccess)
            {
                MessageBox.Show("Поощрение успешно добавлено!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                directorLabel.Visible = false;
                directorTextBox.Visible = false;
                workerLabel.Visible = false;
                workersComboBox.Visible = false;
                rewardLabel.Visible = false;
                rewardTextBox.Visible = false;
                saveButton.Visible = false;
                rewardTextBox.Text = String.Empty;
            }
        }
    }
}
