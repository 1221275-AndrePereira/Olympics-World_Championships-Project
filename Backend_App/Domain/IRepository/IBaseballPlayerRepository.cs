namespace Domain.IRepository;

using Domain.Model;
using Domain.Model.Baseball.BaseballPlayer;

public interface IBaseballPlayerRepository : IGenericRepository<BaseballPlayer>
{
    Task<IEnumerable<BaseballPlayer>> GetBaseballPlayersAsync();
    Task<BaseballPlayer> GetBaseballPlayerByPlayerNameAsync(string playerName);

    Task<BaseballPlayer> GetBaseballPlayerByCountryAsync(string country);

    Task<IEnumerable<BaseballPlayer>> GetBaseballPlayersByGameAsync(string game);

    Task<IEnumerable<BaseballPlayer>> GetBaseballPlayerByFilterAsync(string? playerName, string? country);

    Task<BaseballPlayer> Add(BaseballPlayer baseballPlayer);
    Task<BaseballPlayer> Update(BaseballPlayer baseballPlayer, List<string> errorMessages);
    Task<bool> BaseballPlayerExists(Guid playerId);
}