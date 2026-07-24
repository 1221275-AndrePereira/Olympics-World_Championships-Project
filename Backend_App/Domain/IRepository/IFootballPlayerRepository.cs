namespace Domain.IRepository;

using Domain.Model;
using Domain.Model.Football.FootballPlayer;

public interface IFootballPlayerRepository : IGenericRepository<FootballPlayer>
{
    Task<IEnumerable<FootballPlayer>> GetFootballPlayersAsync();
    Task<FootballPlayer> GetFootballPlayerByPlayerNameAsync(string playerName);

    Task<FootballPlayer> GetFootballPlayerByCountryAsync(string country);

    Task<IEnumerable<FootballPlayer>> GetFootballPlayersByGameAsync(string game);

    Task<IEnumerable<FootballPlayer>> GetFootballPlayerByFilterAsync(string? playerName, string? country);

    Task<FootballPlayer> Add(FootballPlayer footballPlayer);
    Task<FootballPlayer> Update(FootballPlayer footballPlayer, List<string> errorMessages);
    Task<bool> FootballPlayerExists(Guid playerId);
}