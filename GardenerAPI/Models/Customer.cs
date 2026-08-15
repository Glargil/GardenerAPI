namespace GardenerAPI;

public class Customer : User
{
    public List<Address> CustomerAddresses { get; set; }
    public List<Booking> CustomerBookings { get; set; }
}