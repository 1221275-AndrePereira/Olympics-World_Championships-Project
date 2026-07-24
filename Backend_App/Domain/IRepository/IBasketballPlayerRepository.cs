namespace Domain.IRepository;

using Domain.Model;
using Domain.Model.Basketball.BasketballPlayer;

public interface IBasketballPlayerRepository : IGenericRepository<BasketballPlayer>
{
    Task<IEnumerable<BasketballPlayer>> GetBasketballPlayersAsync();
    Task<BasketballPlayer> GetBasketballPlayerByPlayerNameAsync(string playerName);

    Task<BasketballPlayer> GetBasketballPlayerByCountryAsync(string country);

    Task<IEnumerable<BasketballPlayer>> GetBasketballPlayersByGameAsync(string game);

    Task<IEnumerable<BasketballPlayer>> GetBasketballPlayerByFilterAsync(string? playerName, string? country);

    Task<BasketballPlayer> Add(BasketballPlayer basketballPlayer);
    Task<BasketballPlayer> Update(BasketballPlayer basketballPlayer, List<string> errorMessages);
    Task<bool> BasketballPlayerExists(Guid playerId);
}