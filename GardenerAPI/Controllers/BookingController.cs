using Microsoft.AspNetCore.Mvc;
using GardenerAPI.DTOs;
using WebApplication1.Interfaces;

namespace GardenerAPI;

public class BookingController : Controller
{
    private readonly IBookingRepo _bookingRepo;

    public BookingController(IBookingRepo bookingRepo)
    {
        _bookingRepo = bookingRepo;
    }

    // Create Booking
    [HttpPost]
    public async Task<ActionResult<BookingDTO>> CreateBooking(Booking booking)
    {
        var entity = new Booking
        {
            BookingReference = booking.BookingReference,
            Customer = booking.Customer,
            BookingDate = booking.BookingDate,
            CustomerAddress = booking.CustomerAddress,
            ServiceType = booking.ServiceType,
            CreatedAt = booking.CreatedAt,
            UpdatedAt = booking.UpdatedAt,
            Status = booking.Status,
            Description = booking.Description,
            RecentlyChanged = booking.RecentlyChanged
        };
        await _bookingRepo.AddBooking(entity);
        return Ok(entity);
    }
}
