namespace Core.Domains;

public class User : BaseEntity, ISoftDeletable, IEntityRevokable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }

    public string Email { get; set; }
    public string Phonenumber { get; set; }
    
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
    
    public bool IsRevoked { get; set; }
    public DateTime RevokedAt { get; set; }
}