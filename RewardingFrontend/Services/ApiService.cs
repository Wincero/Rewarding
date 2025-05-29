using RewardingFrontend.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace RewardingFrontend.Services
{
    internal class ApiService
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "http://localhost:5248/api";

        public ApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(BaseUrl);
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Employee>> GetEmployeesByRole(string role)
        {
            var response = await _httpClient.GetAsync($"api/employees/role/{role}");
            return await response.Content.ReadAsAsync<List<Employee>>();
        }

        public async Task<Employee> GetEmployeeById(Guid? id)
        {
            var response = await _httpClient.GetAsync($"api/employees/id/{id}");
            return await response.Content.ReadAsAsync<Employee>();
        }

        public async Task<List<Employee>> GetSubordinates(Guid managerId)
        {
            var response = await _httpClient.GetAsync($"api/employees/managerId/{managerId}");
            return await response.Content.ReadAsAsync<List<Employee>>();
        }

        public async Task<bool> AddReward(CreateRewardtDto rewardDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/rewards/reward", rewardDto);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }

            var errorContent = await response.Content.ReadAsStringAsync();
            MessageBox.Show($"Ошибка при добавлении: {errorContent}", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
