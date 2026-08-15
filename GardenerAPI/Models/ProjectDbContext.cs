using Microsoft.EntityFrameworkCore;

namespace GardenerAPI;

public class ProjectDbContext : DbContext
{
    public ProjectDbContext(DbContextOptions<ProjectDbContext> options)
    {
    }
    public DbSet<Gardener> Gardeners { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<ServiceType> ServiceTypes { get; set; }
    public DbSet<Address> Addresses { get; set; }
}