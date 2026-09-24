using Microsoft.AspNetCore.Mvc;

namespace HotelReservationUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
