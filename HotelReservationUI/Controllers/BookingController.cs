using HotelReservationUI.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservationUI.Controllers
{
    public class BookingController : Controller
    {
        private readonly RoomTypeService _roomTypeService;

        public BookingController(RoomTypeService roomTypeService)
        {
            _roomTypeService = roomTypeService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AvailableRooms(
        DateTime? checkIn,
        DateTime? checkOut,
        int guests = 2)
        {
            if (!checkIn.HasValue ||
                !checkOut.HasValue ||
                checkOut.Value.Date <= checkIn.Value.Date ||
                guests < 1 ||
                guests > 6)
            {
                return RedirectToAction(nameof(Index));
            }

            var rooms = await _roomTypeService.GetAvailableAsync(
                checkIn.Value,
                checkOut.Value,
                guests);

            ViewBag.CheckIn = checkIn.Value.ToString("yyyy-MM-dd");
            ViewBag.CheckOut = checkOut.Value.ToString("yyyy-MM-dd");
            ViewBag.Guests = guests;

            return View(rooms);
        }



    }
}