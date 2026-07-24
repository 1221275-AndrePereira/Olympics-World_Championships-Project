namespace Domain.IRepository;

using Domain.Model;
using Domain.Model.Handball.HandballPlayer;

public interface IHandballPlayerRepository : IGenericRepository<HandballPlayer>
{
    Task<IEnumerable<HandballPlayer>> GetHandballPlayersAsync();
    Task<HandballPlayer> GetHandballPlayerByPlayerNameAsync(string playerName);

    Task<HandballPlayer> GetHandballPlayerByCountryAsync(string country);

    Task<IEnumerable<HandballPlayer>> GetHandballPlayersByGameAsync(string game);

    Task<IEnumerable<HandballPlayer>> GetHandballPlayerByFilterAsync(string? playerName, string? country);

    Task<HandballPlayer> Add(HandballPlayer handballPlayer);
    Task<HandballPlayer> Update(HandballPlayer handballPlayer, List<string> errorMessages);
    Task<bool> HandballPlayerExists(Guid playerId);
}