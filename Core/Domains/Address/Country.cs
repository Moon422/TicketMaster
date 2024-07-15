namespace Core.Domains.Address;

public class Country : BaseEntity, ISoftDeletable
{
    public string Name { get; set; }
    public string ShortCode { get; set; }

    public IList<Division> Divisions { get; set; }
    
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
}