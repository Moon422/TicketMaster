namespace Core.Domains.Address;

public class District : BaseEntity, ISoftDeletable
{
    public string Name { get; set; }

    public int DivisionId { get; set; }
    public Division Division { get; set; }
    public IList<PostalAddress> PostalAddresses { get; set; }
    
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
}