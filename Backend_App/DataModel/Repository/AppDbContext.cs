using Microsoft.EntityFrameworkCore;
using Backend_App.Domain.Model;
 
namespace Backend_App.DataModel.Repository;
 
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
 
    public DbSet<SportSheet> SportSheets => Set<SportSheet>();
    public DbSet<ClassificationEntry> ClassificationEntries => Set<ClassificationEntry>();
    public DbSet<CountrySummary> CountrySummaries => Set<CountrySummary>();
    public DbSet<CountrySportQuota> CountrySportQuotas => Set<CountrySportQuota>();
 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SportSheet>()
            .HasMany(s => s.Entries)
            .WithOne(e => e.SportSheet)
            .HasForeignKey(e => e.SportSheetId);
 
        modelBuilder.Entity<ClassificationEntry>()
            .HasIndex(e => e.Country);
        modelBuilder.Entity<ClassificationEntry>()
            .HasIndex(e => e.Event);
 
        modelBuilder.Entity<SportSheet>()
            .HasIndex(s => s.Sport);
 
        modelBuilder.Entity<CountrySummary>()
            .HasIndex(c => c.Country)
            .IsUnique();
 
        modelBuilder.Entity<CountrySportQuota>()
            .HasIndex(c => new { c.Country, c.Sport });
    }
}