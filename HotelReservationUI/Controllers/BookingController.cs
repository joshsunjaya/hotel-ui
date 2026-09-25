//using HotelReservationUI.Services;
//using Microsoft.AspNetCore.Mvc;

//namespace HotelReservationUI.Controllers
//{
//    public class BookingController : Controller
//    {
//        private readonly RoomTypeService _roomTypeService;

//        public BookingController(RoomTypeService roomTypeService)
//        {
//            _roomTypeService = roomTypeService;
//        }

//        public IActionResult Index()
//        {
//            return View();
//        }

//        public async Task<IActionResult> AvailableRooms()
//        {
//            var rooms = await _roomTypeService.GetAllAsync();

//            return View(rooms);
//        }
//    }
//}


using Microsoft.AspNetCore.Mvc;

namespace HotelReservationUI.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}