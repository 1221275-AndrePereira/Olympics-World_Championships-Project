namespace Domain.IRepository;

using Domain.Model;
using Domain.Model.AmericanFootball.AmericanFootballPlayer;

public interface IAmericanFootballPlayerRepository : IGenericRepository<AmericanFootballPlayer>
{
    Task<IEnumerable<AmericanFootballPlayer>> GetAmericanFootballPlayersAsync();
    Task<AmericanFootballPlayer> GetAmericanFootballPlayerByPlayerNameAsync(string playerName);

    Task<IEnumerable<AmericanFootballPlayer>> GetAmericanFootballPlayersByGameAsync(string game);
    Task<IEnumerable<AmericanFootballPlayer>> GetAmericanFootballPlayerByFilterAsync(string? playerName);

    Task<AmericanFootballPlayer> Add(AmericanFootballPlayer americanFootballPlayer);
    Task<AmericanFootballPlayer> Update(AmericanFootballPlayer americanFootballPlayer, List<string> errorMessages);
    Task<bool> AmericanFootballPlayerExists(Guid playerId);
}