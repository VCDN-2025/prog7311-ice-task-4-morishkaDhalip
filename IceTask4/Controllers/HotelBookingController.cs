using IceTask4.Data;
using IceTask4.Models;
using Microsoft.AspNetCore.Mvc;

namespace IceTask4.Controllers
{
    public class HotelBookingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HotelBookingController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Display all bookings
        public IActionResult Index()
        {
            var bookings = _context.HotelBookings.ToList();
            return View(bookings);
        }

        // GET: Create Booking Form
        public IActionResult Create()
        {
            return View();
        }

        // POST: Save New Booking
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HotelBooking booking)
        {
            if (ModelState.IsValid)
            {
                _context.HotelBookings.Add(booking);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(booking);
        }
    }
}
