namespace Core.Domains.Address;

public class LocalAddress : BaseEntity
{
    public string FlatName { get; set; }
    public int FloorNumber { get; set; }
    public string BuildingName { get; set; }
    public string RoadName { get; set; }
    public string AreaName { get; set; }

    public int PostalAddressId { get; set; }
    public PostalAddress PostalAddress { get; set; }
}