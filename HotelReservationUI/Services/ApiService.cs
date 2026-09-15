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

            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "HotelReservationUI/1.0"
            );
        }

        public HttpClient Client => _httpClient;
    }
}