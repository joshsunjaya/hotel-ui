using HotelReservationUI.Models;

namespace HotelReservationUI.Services
{
    public class RoomTypeService
    {
        private readonly HttpClient _httpClient;

        public RoomTypeService(ApiService apiService)
        {
            _httpClient = apiService.Client;
        }

        public async Task<List<RoomType>> GetAllAsync()
        {
            var result = await _httpClient.GetFromJsonAsync<List<RoomType>>(
                "api/RoomType/GetAll"
            );

            return result ?? new List<RoomType>();
        }
    }
}