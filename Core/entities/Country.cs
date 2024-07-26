namespace Core.entities;

public class Country
{
    public string CountryCode { get; set; }
    public string CountryName { get; set; }
    public ICollection<City> Cities { get; set; }
}
