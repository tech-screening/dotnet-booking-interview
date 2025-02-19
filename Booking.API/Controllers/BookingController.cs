using Microsoft.AspNetCore.Mvc;
using Booking.API.Services;
using Booking.API.Models;

namespace Booking.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController()
        {
            _bookingService = new BookingService();
        }

        [HttpPost()]
        public async Task<ActionResult<BookingResponse>> CreateBooking(BookingRequest request)
        {
            var result = await _bookingService.CreateBooking(request.Name, request.Row, request.Column);

            return new BookingResponse
            {
                Result = result,
            };
        }
    }
}
