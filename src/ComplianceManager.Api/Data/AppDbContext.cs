using ComplianceManager.Api.Models;
using Microsoft.EntityFrameworkCore;
namespace ComplianceManager.Api.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Obligation> Obligations => Set<Obligation>();
}