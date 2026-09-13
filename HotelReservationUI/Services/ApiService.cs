namespace HotelReservationUI.Services
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(
            IHttpClientFactory httpClientFactory,
            IConfiguration configuration)
        {
            _httpClient = httpClientFactory.CreateClient();

            var baseUrl = configuration["ApiSettings:BaseUrl"];

            _httpClient.BaseAddress = new Uri(baseUrl!);
        }

        public HttpClient Client => _httpClient;
    }
}
