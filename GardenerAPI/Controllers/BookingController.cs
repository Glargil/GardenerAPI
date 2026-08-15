using Microsoft.AspNetCore.Mvc;

namespace GardenerAPI;

public class BookingController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}