namespace GardenerAPI.DTOs;

public class BookingUpdateDTO
{
    public Guid BookingReference  { get; set; }
    public User Customer { get; set; }
    public DateTime BookingDate { get; set; }
    public Address CustomerAddress { get; set; }
    public List<ServiceType> ServiceType { get; set; }
    public DateTime UpdatedAt { get; set; }
    public BookingStatus Status { get; set; }
    public string Description { get; set; }
    public bool RecentlyChanged { get; set; } = false; 
}