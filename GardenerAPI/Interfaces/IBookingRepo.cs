using GardenerAPI;
namespace WebApplication1.Interfaces;

public interface IBookingRepo
{
    Task<List<Booking>> GetAllBookings();
    Task<Booking> GetBooking(int id);
    Task<Booking> UpdateBooking(int id, Booking customer);
    Task<Booking> DeleteBooking(int id);
    Task<Booking> AddBooking (Booking customer);
    Task<Booking> ConfirmBooking (int id);
    Task<Booking> CancelBooking(int id);
}