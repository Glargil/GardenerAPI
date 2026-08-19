using GardenerAPI;
using WebApplication1.Interfaces;
namespace WebApplication1.Repos;

public class AddressRepo :IAddressRepo

{
    // private readonly ProjectDbContext _context;
    //
    // public AddressRepo(ProjectDbContext context)
    // {
    //     _context = context;
    // }
    //
    // public async Task<List<Booking>> GetAllBookings()
    // {
    //     return _context.Bookings.ToList();
    // }
    //
    // public async Task<Booking> GetBooking(int id)
    // {
    //     return await _context.Bookings.FindAsync(id);
    // }
    //
    // public async Task<Booking> AddBooking(Booking customer)
    // {
    //     await _context.Bookings.AddAsync(customer);
    //     await _context.SaveChangesAsync();
    //     return customer;
    // }
    //
    // public async Task<Booking> DeleteBooking(int id)
    // {
    //     var bookingToDelete = _context.Bookings.Find(id);
    //     if (bookingToDelete != null)
    //     {
    //         _context.Bookings.Remove(bookingToDelete);
    //         _context.SaveChanges();
    //         return bookingToDelete;
    //     }
    //
    //     return null;
    // }
    //
    // public async Task<Booking> UpdateBooking(int id, Booking updatedbooking)
    // {
    //     var booking = _context.Bookings.FirstOrDefault(booking => booking.Id == id);
    //     if (booking != null)
    //     {
    //         booking.BookingDate = updatedbooking.BookingDate;
    //         booking.ServiceType = updatedbooking.ServiceType;
    //         booking.UpdatedAt = updatedbooking.UpdatedAt;
    //         booking.Description = updatedbooking.Description;
    //         booking.Status = updatedbooking.Status;
    //         booking.RecentlyChanged = true;
    //         return booking;
    //     }
    //     return null;
    // }
    //
    // public async Task<Booking> ConfirmBooking(int id)
    // {
    //     var booking = _context.Bookings.FirstOrDefault(booking => booking.Id == id);
    //     if (booking != null)
    //     {
    //         booking.RecentlyChanged = false;
    //         booking.Status = Booking.BookingStatus.Confirmed;
    //         //implement email sending logic (to customer)
    //         return booking;
    //     }
    //     return null;
    // }
    //
    // public async Task<Booking> CancelBooking(int id)
    // {
    //     var booking = _context.Bookings.FirstOrDefault(booking => booking.Id == id);
    //     if (booking != null)
    //     {
    //         booking.Status = Booking.BookingStatus.Cancelled;
    //         //implement email sending logic (to gardener)
    //         return booking;
    //     }
    //     return null;
    // }
}