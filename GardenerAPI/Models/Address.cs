namespace GardenerAPI;

public class Address
{
    public enum ResidentialTypeEnum
    {
        House,
        VacationHome
    }

    public ResidentialTypeEnum ResidentialType { get; set; }
    public string Zipcode { get; set; }
    public string Municipality { get; set; }
    public string StreetName { get; set; }
    public string StreetNumber { get; set; }
}