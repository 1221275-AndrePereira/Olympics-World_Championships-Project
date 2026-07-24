

namespace DataModel.Repository;

using DataModel.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

public class AbsanteeContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public AbsanteeContext()
    {
        
    }

    public AbsanteeContext(DbContextOptions<AbsanteeContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    public virtual DbSet<AmericanFootballPlayerDataModel> AmericanFootballPlayers { get; set; } = null!;
    public virtual DbSet<BaseballPlayerDataModel> BaseballPlayers { get; set; } = null!;
    public virtual DbSet<BasketballPlayerDataModel> BasketballPlayers { get; set; } = null!;
    public virtual DbSet<FootballPlayerDataModel> FootballPlayers { get; set; } = null!;
    public virtual DbSet<HandballPlayerDataModel> HandballPlayers { get; set; } = null!;
    public virtual DbSet<IceHockeyPlayerDataModel> IceHockeyPlayers { get; set; } = null!;
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<AmericanFootballPlayerDataModel>().HasKey(x => x.PlayerId);

        
        modelBuilder.Entity<AmericanFootballPlayerDataModel>(entity =>
        {
            entity.OwnsOne(x => x.NFLGameday98Rating);
            entity.OwnsOne(x => x.NFLGameday99Rating);
            entity.OwnsOne(x => x.MaddenNFL2000Rating);
            entity.OwnsOne(x => x.MaddenNFL2001Rating);
            entity.OwnsOne(x => x.MaddenNFL2002Rating);
            entity.OwnsOne(x => x.MaddenNFL2003Rating);
            entity.OwnsOne(x => x.MaddenNFL2004Rating);
            entity.OwnsOne(x => x.MaddenNFL2005Rating);
            entity.OwnsOne(x => x.MaddenNFL06Rating);
            entity.OwnsOne(x => x.MaddenNFL07Rating);
            entity.OwnsOne(x => x.MaddenNFL08Rating);
            entity.OwnsOne(x => x.MaddenNFL09Rating);
            entity.OwnsOne(x => x.MaddenNFL10Rating);
            entity.OwnsOne(x => x.MaddenNFL11Rating);
            entity.OwnsOne(x => x.MaddenNFL12Rating);
            entity.OwnsOne(x => x.MaddenNFL13Rating);
            entity.OwnsOne(x => x.MaddenNFL14Rating);
            entity.OwnsOne(x => x.MaddenNFL15Rating);
            entity.OwnsOne(x => x.MaddenNFL16Rating);
            entity.OwnsOne(x => x.MaddenNFL17Rating);
            entity.OwnsOne(x => x.MaddenNFL18Rating);
            entity.OwnsOne(x => x.MaddenNFL19Rating);
            entity.OwnsOne(x => x.MaddenNFL20Rating);
            entity.OwnsOne(x => x.MaddenNFL21Rating);
            entity.OwnsOne(x => x.MaddenNFL22Rating);
            entity.OwnsOne(x => x.MaddenNFL23Rating);
            entity.OwnsOne(x => x.MaddenNFL24Rating);
            entity.OwnsOne(x => x.MaddenNFL25Rating);
            entity.OwnsOne(x => x.MaddenNFL26Rating);
        });

        modelBuilder.Entity<BaseballPlayerDataModel>().HasKey(x => x.PlayerId);

        
        modelBuilder.Entity<BaseballPlayerDataModel>(entity =>
        {
            entity.OwnsOne(x => x.MLBTriplePlay99Rating);
            entity.OwnsOne(x => x.MLBTriplePlay2000Rating);
            entity.OwnsOne(x => x.MLBTriplePlay2001Rating);
            entity.OwnsOne(x => x.MLBTriplePlay2002Rating);
            entity.OwnsOne(x => x.MLBTriplePlayBaseballRating);
            entity.OwnsOne(x => x.MLB2004Rating);
            entity.OwnsOne(x => x.MLBESPNRating);
            entity.OwnsOne(x => x.MLB2K5Rating);
            entity.OwnsOne(x => x.MLB2K6Rating);
            entity.OwnsOne(x => x.MLB2K7Rating);
            entity.OwnsOne(x => x.MLB2K8Rating);
            entity.OwnsOne(x => x.MLB2K9Rating);
            entity.OwnsOne(x => x.MLB2K10Rating);
            entity.OwnsOne(x => x.MLB2K11Rating);
            entity.OwnsOne(x => x.MLB2K12Rating);
            entity.OwnsOne(x => x.MLBTheShow13Rating);
            entity.OwnsOne(x => x.MLBTheShow14Rating);
            entity.OwnsOne(x => x.MLBTheShow15Rating);
            entity.OwnsOne(x => x.MLBTheShow16Rating);
            entity.OwnsOne(x => x.MLBTheShow17Rating);
            entity.OwnsOne(x => x.MLBTheShow18Rating);
            entity.OwnsOne(x => x.MLBTheShow19Rating);
            entity.OwnsOne(x => x.MLBTheShow20Rating);
            entity.OwnsOne(x => x.MLBTheShow21Rating);
            entity.OwnsOne(x => x.MLBTheShow22Rating);
            entity.OwnsOne(x => x.MLBTheShow23Rating);
            entity.OwnsOne(x => x.MLBTheShow24Rating);
            entity.OwnsOne(x => x.MLBTheShow25Rating);
        });

        modelBuilder.Entity<BasketballPlayerDataModel>().HasKey(x => x.PlayerId);

        
        modelBuilder.Entity<BasketballPlayerDataModel>(entity =>
        {
            entity.OwnsOne(x => x.NBALive95Rating);
            entity.OwnsOne(x => x.NBALive96Rating);
            entity.OwnsOne(x => x.NBALive97Rating);
            entity.OwnsOne(x => x.NBALive98Rating);
            entity.OwnsOne(x => x.NBALive99Rating);
            entity.OwnsOne(x => x.NBA2KRating);
            entity.OwnsOne(x => x.NBA2K1Rating);
            entity.OwnsOne(x => x.NBA2K2Rating);
            entity.OwnsOne(x => x.NBA2K3Rating);
            entity.OwnsOne(x => x.NBA2K4Rating);
            entity.OwnsOne(x => x.NBA2K5Rating);
            entity.OwnsOne(x => x.NBA2K6Rating);
            entity.OwnsOne(x => x.NBA2K7Rating);
            entity.OwnsOne(x => x.NBA2K8Rating);
            entity.OwnsOne(x => x.NBA2K9Rating);
            entity.OwnsOne(x => x.NBA2K10Rating);
            entity.OwnsOne(x => x.NBA2K11Rating);
            entity.OwnsOne(x => x.NBA2K12Rating);
            entity.OwnsOne(x => x.NBA2K13Rating);
            entity.OwnsOne(x => x.NBA2K14Rating);
            entity.OwnsOne(x => x.NBA2K15Rating);
            entity.OwnsOne(x => x.NBA2K16Rating);
            entity.OwnsOne(x => x.NBA2K17Rating);
            entity.OwnsOne(x => x.NBA2K18Rating);
            entity.OwnsOne(x => x.NBA2K19Rating);
            entity.OwnsOne(x => x.NBA2K20Rating);
            entity.OwnsOne(x => x.NBA2K21Rating);
            entity.OwnsOne(x => x.NBA2K22Rating);
            entity.OwnsOne(x => x.NBA2K23Rating);
            entity.OwnsOne(x => x.NBA2K24Rating);
            entity.OwnsOne(x => x.NBA2K25Rating);
            entity.OwnsOne(x => x.NBA2K26Rating);
        });
        
        modelBuilder.Entity<FootballPlayerDataModel>().HasKey(x => x.PlayerId);

        
        modelBuilder.Entity<FootballPlayerDataModel>(entity =>
        {
            entity.OwnsOne(x => x.FIFA96Rating);
            entity.OwnsOne(x => x.FIFA97Rating);
            entity.OwnsOne(x => x.FIFA98Rating);
            entity.OwnsOne(x => x.FIFA99Rating);
            entity.OwnsOne(x => x.FIFA2000Rating);
            entity.OwnsOne(x => x.FIFA2001Rating);
            entity.OwnsOne(x => x.FIFA2002Rating);
            entity.OwnsOne(x => x.FIFA2003Rating);
            entity.OwnsOne(x => x.FIFA2004Rating);
            entity.OwnsOne(x => x.FIFA2005Rating);
            entity.OwnsOne(x => x.FIFA06Rating);
            entity.OwnsOne(x => x.FIFA07Rating);
            entity.OwnsOne(x => x.FIFA08Rating);
            entity.OwnsOne(x => x.FIFA09Rating);
            entity.OwnsOne(x => x.FIFA10Rating);
            entity.OwnsOne(x => x.FIFA11Rating);
            entity.OwnsOne(x => x.FIFA12Rating);
            entity.OwnsOne(x => x.FIFA13Rating);
            entity.OwnsOne(x => x.FIFA14Rating);
            entity.OwnsOne(x => x.FIFA15Rating);
            entity.OwnsOne(x => x.FIFA16Rating);
            entity.OwnsOne(x => x.FIFA17Rating);
            entity.OwnsOne(x => x.FIFA18Rating);
            entity.OwnsOne(x => x.FIFA19Rating);
            entity.OwnsOne(x => x.FIFA20Rating);
            entity.OwnsOne(x => x.FIFA21Rating);
            entity.OwnsOne(x => x.FIFA22Rating);
            entity.OwnsOne(x => x.FIFA23Rating);
            entity.OwnsOne(x => x.EAFC24Rating);
            entity.OwnsOne(x => x.EAFC25Rating);
            entity.OwnsOne(x => x.EAFC26Rating);
        });

        modelBuilder.Entity<HandballPlayerDataModel>().HasKey(x => x.PlayerId);

        
        modelBuilder.Entity<HandballPlayerDataModel>(entity =>
        {
            entity.OwnsOne(x => x.Handball17Rating);
            entity.OwnsOne(x => x.Handball21Rating);
        });

        modelBuilder.Entity<IceHockeyPlayerDataModel>().HasKey(x => x.PlayerId);

        
        modelBuilder.Entity<IceHockeyPlayerDataModel>(entity =>
        {
            entity.OwnsOne(x => x.NHL93Rating);
            entity.OwnsOne(x => x.NHL94Rating);
            entity.OwnsOne(x => x.NHL95Rating);
            entity.OwnsOne(x => x.NHL96Rating);
            entity.OwnsOne(x => x.NHL97Rating);
            entity.OwnsOne(x => x.NHL98Rating);
            entity.OwnsOne(x => x.NHL99Rating);
            entity.OwnsOne(x => x.NHL2000Rating);
            entity.OwnsOne(x => x.NHL2001Rating);
            entity.OwnsOne(x => x.NHL2002Rating);
            entity.OwnsOne(x => x.NHL2003Rating);
            entity.OwnsOne(x => x.NHL2004Rating);
            entity.OwnsOne(x => x.NHL2005Rating);
            entity.OwnsOne(x => x.NHL06Rating);
            entity.OwnsOne(x => x.NHL07Rating);
            entity.OwnsOne(x => x.NHL08Rating);
            entity.OwnsOne(x => x.NHL09Rating);
            entity.OwnsOne(x => x.NHL10Rating);
            entity.OwnsOne(x => x.NHL11Rating);
            entity.OwnsOne(x => x.NHL12Rating);
            entity.OwnsOne(x => x.NHL13Rating);
            entity.OwnsOne(x => x.NHL14Rating);
            entity.OwnsOne(x => x.NHL15Rating);
            entity.OwnsOne(x => x.NHL16Rating);
            entity.OwnsOne(x => x.NHL17Rating);
            entity.OwnsOne(x => x.NHL18Rating);
            entity.OwnsOne(x => x.NHL19Rating);
            entity.OwnsOne(x => x.NHL20Rating);
            entity.OwnsOne(x => x.NHL21Rating);
            entity.OwnsOne(x => x.NHL22Rating);
            entity.OwnsOne(x => x.NHL23Rating);
            entity.OwnsOne(x => x.NHL24Rating);
            entity.OwnsOne(x => x.NHL25Rating);
            entity.OwnsOne(x => x.NHL26Rating);
        });
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder
        .LogTo(Console.WriteLine)
        .EnableSensitiveDataLogging() //to log sensitive data
        .EnableDetailedErrors();
}