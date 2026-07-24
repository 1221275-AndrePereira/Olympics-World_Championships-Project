using Domain.IRepository;
using Microsoft.EntityFrameworkCore;
using DataModel.Mapper;
using DataModel.Model;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Domain.Model.Football;
using Domain.Model.Football.FootballPlayer;
using System.ComponentModel;

namespace DataModel.Repository;

public class FootballPlayerRepository : GenericRepository<FootballPlayer>, IFootballPlayerRepository
{
    private FootballPlayerMapper _footballPlayerMapper;

    public FootballPlayerRepository(AbsanteeContext context, FootballPlayerMapper footballPlayerMapper) : base(context!)
    {
        _footballPlayerMapper = footballPlayerMapper;
    }

    public async Task<IEnumerable<FootballPlayer>> GetFootballPlayersAsync()
    {
        try
        {
            IEnumerable<FootballPlayerDataModel> footballPlayersDataModels =
                await _context.Set<FootballPlayerDataModel>()
                    .ToListAsync();

            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayersDataModels);

            return footballPlayers;
        }
        catch
        {
            throw;
        }
    }

    public async Task<FootballPlayer> Add(FootballPlayer footballPlayer)
    {
        try
        {
            FootballPlayerDataModel footballPlayerDataModel = _footballPlayerMapper.ToDataModel(footballPlayer);

            EntityEntry<FootballPlayerDataModel> footballPlayerDataModelEntityEntry =
                _context.Set<FootballPlayerDataModel>().Add(footballPlayerDataModel);

            await _context.SaveChangesAsync();

            FootballPlayerDataModel footballPlayerDataModelSaved = footballPlayerDataModelEntityEntry.Entity;
            FootballPlayer footballPlayerSaved = _footballPlayerMapper.ToDomain(footballPlayerDataModelSaved);

            return footballPlayerSaved;
        }
        catch
        {
            throw;
        }
    }

    public async Task<FootballPlayer> GetFootballPlayerByPlayerNameAsync(string playerName)
    {
        try
        {
            FootballPlayerDataModel footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .FirstAsync(c => c.PlayerName == playerName);

            FootballPlayer footballPlayer = _footballPlayerMapper.ToDomain(footballPlayerDataModel);


            return footballPlayer;
        }
        catch
        {
            return null;
            throw;
        }
    }

    public async Task<FootballPlayer> GetFootballPlayerByCountryAsync(string country)
    {
        try
        {
            FootballPlayerDataModel footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .FirstAsync(c => c.Country == country);

            FootballPlayer footballPlayer = _footballPlayerMapper.ToDomain(footballPlayerDataModel);


            return footballPlayer;
        }
        catch
        {
            return null;
            throw;
        }
    }


    public async Task<IEnumerable<FootballPlayer>> GetFootballPlayersByGameAsync(string game)
    {
        if(game.Trim().ToLower() == "fifa96"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA96Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "fifa97"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA97Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "fifa98"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA98Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "fifa99"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA99Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "fifa2000"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA2000Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "fifa2001"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA2001Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "fifa2002"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA2002Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "fifa2003"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA2003Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "fifa2004"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA2004Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "fifa2005"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA2005Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "fifa06"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA06Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "fifa07"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA07Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "fifa08"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA08Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "fifa09"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA09Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "fifa10"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA10Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "fifa11"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA11Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "fifa12"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA12Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "fifa13"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA13Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "fifa14"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA14Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "fifa15"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA15Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "fifa16"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA16Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "fifa17"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA17Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "fifa18"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA18Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "fifa19"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA19Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "fifa20"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA20Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "fifa21"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA21Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "fifa22"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA22Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "fifa23"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.FIFA23Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "eafc24"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.EAFC24Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "eafc25"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.EAFC25Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        } else if(game.Trim().ToLower() == "eafc26"){
            IEnumerable<FootballPlayerDataModel> footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .Where(c => c.EAFC26Rating != null).ToListAsync();
            IEnumerable<FootballPlayer> footballPlayers = _footballPlayerMapper.ToDomain(footballPlayerDataModel);
            return footballPlayers;
        }
        else {
            return Enumerable.Empty<FootballPlayer>();
        }
    }

    public async Task<bool> FootballPlayerExists(Guid playerId)
    {
        return await _context.Set<FootballPlayerDataModel>().AnyAsync(e => e.PlayerId == playerId);
    }

    public async Task<FootballPlayer> Update(FootballPlayer footballPlayer, List<string> errorMessages)
    {
        try
        {
            var footballPlayerDataModel = await _context.Set<FootballPlayerDataModel>()
                .FirstAsync(c => c.PlayerId == footballPlayer.PlayerId);

            _footballPlayerMapper.UpdateDataModel(footballPlayerDataModel, footballPlayer);

            _context.Entry(footballPlayerDataModel).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return footballPlayer;
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!await FootballPlayerExists(footballPlayer.PlayerId))
            {
                errorMessages.Add("Not found");

                return null;
            }
            else
            {
                throw;
            }

            return null;
        }
        catch
        {
            throw;
        }
    }



    public Task<IEnumerable<FootballPlayer>> GetFootballPlayerByFilterAsync(string? playerName, string? country)
    {
        IQueryable<FootballPlayerDataModel> query = _context.Set<FootballPlayerDataModel>();

        if (!string.IsNullOrEmpty(playerName))
        {
            query = query.Where(c => EF.Functions.Like(c.PlayerName, "%" + playerName + "%"));
        }
        if (!string.IsNullOrEmpty(country))
        {
            query = query.Where(c => EF.Functions.Like(c.Country, "%" + country + "%"));
        }

        return Task.FromResult(_footballPlayerMapper.ToDomain(query.AsEnumerable()));
    }
}