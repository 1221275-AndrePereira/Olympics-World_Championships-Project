namespace DataModel.Repository;

using Microsoft.EntityFrameworkCore;

using DataModel.Model;


public interface IAbsanteeContext
{
	DbSet<AmericanFootballPlayerDataModel> AmericanFootballPlayers { get; set; }
	DbSet<BaseballPlayerDataModel> BaseballPlayers { get; set; }
	DbSet<BasketballPlayerDataModel> BasketballPlayers { get; set; }
	DbSet<FootballPlayerDataModel> FootballPlayers { get; set; }
	DbSet<HandballPlayerDataModel> HandballPlayers { get; set; }
	DbSet<IceHockeyPlayerDataModel> IceHockeyPlayers { get; set; }

}