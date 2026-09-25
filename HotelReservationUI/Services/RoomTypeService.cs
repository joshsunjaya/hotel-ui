using HotelReservationUI.Models;

namespace HotelReservationUI.Services
{
    public class RoomTypeService
    {
        private readonly HttpClient _httpClient;

        public RoomTypeService(ApiService apiService)
        {
            _httpClient = apiService.Client;

            Console.WriteLine("RoomTypeService CREATED");
        }

        public async Task<List<RoomType>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync("api/RoomType/GetAll");

            var body = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(
                    $"API ERROR | Status: {(int)response.StatusCode} | Body: {body}"
                );
            }

            var result =
                System.Text.Json.JsonSerializer.Deserialize<List<RoomType>>(
                    body,
                    new System.Text.Json.JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }
                );

            return result ?? new List<RoomType>();
        }
    }
}