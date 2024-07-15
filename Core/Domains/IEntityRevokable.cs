namespace Core.Domains;

public interface IEntityRevokable
{
    public bool IsRevoked { get; set; }
    public DateTime RevokedAt { get; set; }
}