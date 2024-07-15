namespace Core.Domains.Address;

public class Division : BaseEntity, ISoftDeletable
{
    public string Name { get; set; }
    
    public int CountryId { get; set; }
    public Country Country { get; set; }
    public IList<District> Districts { get; set; }
    
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
}