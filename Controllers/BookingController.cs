using FitnessClasses.Interfaces;
using FitnessClasses.Models;
using Microsoft.AspNetCore.Mvc;

namespace FitnessClasses.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpPost]
        [Route(("create"))]
        public IActionResult CreateBooking(string memberName, string className, DateTime participationDate)
        {
            try
            {
                var booking = _bookingService.CreateBooking(memberName, className, participationDate);
                return Ok(booking);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("search")]
        public IActionResult SearchBookings(string? memberName = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            var bookings = _bookingService.SearchBookings(memberName, startDate, endDate);
            return Ok(bookings);
        }
    }
}
