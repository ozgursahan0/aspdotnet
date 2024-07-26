namespace Core.entities;

public class District
{
    public int DistrictId { get; set; }
    public string DistrictName { get; set; }
    public int CityId { get; set; }
    public City City { get; set; }
}
