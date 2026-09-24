using HotelReservationUI.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservationUI.Controllers
{
    public class FacilityController : Controller
    {
        private readonly FacilityService _facilityService;

        public FacilityController(FacilityService facilityService)
        {
            _facilityService = facilityService;
        }

        public async Task<IActionResult> Index()
        {
            var facilities = await _facilityService.GetAllAsync();

            return View(facilities);
        }
    }
}
