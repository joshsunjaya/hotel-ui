using Microsoft.AspNetCore.Mvc;
using HotelReservationUI.Services;

namespace HotelReservationUI.Controllers
{
    public class RoomController : Controller
    {
        private readonly RoomTypeService _roomService;

        public RoomController(ApiService apiService)
        {
            _roomService = new RoomTypeService(apiService);
        }

        public async Task<IActionResult> Index()
        {
            var result = await _roomService.GetAllAsync();

            return View(result);
        }
    }
}
