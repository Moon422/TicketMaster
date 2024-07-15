using Core.Domains;
using Core.Domains.Address;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class TicketMasterDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<LocalAddress> LocalAddresses { get; set; }
    public DbSet<PostalAddress> PostalAddresses { get; set; }
    public DbSet<District> Districts { get; set; }
    public DbSet<Division> Divisions { get; set; }
    public DbSet<Country> Countries { get; set; }
    
    public TicketMasterDbContext(DbContextOptions<TicketMasterDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(a =>
        {
            
        });
        
        base.OnModelCreating(modelBuilder);
    }
}