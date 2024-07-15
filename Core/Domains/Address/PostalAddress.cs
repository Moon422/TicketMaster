namespace Core.Domains.Address;

public class PostalAddress : BaseEntity, ISoftDeletable
{
    public string Name { get; set; }
    public string PostCode { get; set; }

    public int DistrictId { get; set; }
    public District District { get; set; }

    public IList<PostalAddress> PostalAddresses { get; set; }
    
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
}