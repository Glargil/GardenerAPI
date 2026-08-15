namespace GardenerAPI;

public class User
{
    public string Id { get; set; }
    public string Email { get; set; }
    public string FireBaseID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}