namespace Domain.IRepository;

using Domain.Model;
using Domain.Model.IceHockey.IceHockeyPlayer;

public interface IIceHockeyPlayerRepository : IGenericRepository<IceHockeyPlayer>
{
    Task<IEnumerable<IceHockeyPlayer>> GetIceHockeyPlayersAsync();
    Task<IceHockeyPlayer> GetIceHockeyPlayerByPlayerNameAsync(string playerName);

    Task<IceHockeyPlayer> GetIceHockeyPlayerByCountryAsync(string country);

    Task<IEnumerable<IceHockeyPlayer>> GetIceHockeyPlayersByGameAsync(string game);

    Task<IEnumerable<IceHockeyPlayer>> GetIceHockeyPlayerByFilterAsync(string? playerName, string? country);

    Task<IceHockeyPlayer> Add(IceHockeyPlayer iceHockeyPlayer);
    Task<IceHockeyPlayer> Update(IceHockeyPlayer iceHockeyPlayer, List<string> errorMessages);
    Task<bool> IceHockeyPlayerExists(Guid playerId);
}