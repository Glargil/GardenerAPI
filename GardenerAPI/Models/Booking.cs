namespace GardenerAPI;

public class Booking
{
    public enum BookingStatus
    {
        Pending,
        Confirmed,
        Cancelled,
        Completed
    }

    //maybe for tracking which bookings requires action from the gardener
    // public enum PriorityLevel
    // {
    //     PendingRequiresAction,
    //     ConfirmedRequiresAction
    // }

    public int Id { get; set; }
    public Guid BookingReference  { get; set; }
    public User Customer { get; set; }
    public DateTime BookingDate { get; set; }
    public Address CustomerAddress { get; set; }
    public List<ServiceType> ServiceType { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public BookingStatus Status { get; set; }
    public string Description { get; set; }
    public bool RecentlyChanged { get; set; } = false; 
    //public PriorityLevel Priority { get; set; }
}