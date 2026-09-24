using HotelReservationUI.Models;
using System.Text.Json;

namespace HotelReservationUI.Services
{
    public class FacilityService
    {
        private readonly HttpClient _httpClient;

        public FacilityService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;

            var baseUrl = configuration["ApiSettings:BaseUrl"];

            _httpClient.BaseAddress = new Uri(baseUrl!);
        }

        public async Task<List<Facility>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync("api/Facility/GetAll");

            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<List<Facility>>(
                json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }
            ) ?? new List<Facility>();
        }
    }
}