namespace Core.entities;

public class City
{
    public int CityId { get; set; }
    public string CityName { get; set; }
    public string CountryCode { get; set; }
    public Country Country { get; set; }
    public ICollection<District> Districts { get; set; }
}
