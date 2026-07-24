using Domain.IRepository;
using Microsoft.EntityFrameworkCore;
using DataModel.Mapper;
using DataModel.Model;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Domain.Model.IceHockey;
using Domain.Model.IceHockey.IceHockeyPlayer;
using System.ComponentModel;

namespace DataModel.Repository;

public class IceHockeyPlayerRepository : GenericRepository<IceHockeyPlayer>, IIceHockeyPlayerRepository
{
    private IceHockeyPlayerMapper _iceHockeyPlayerMapper;

    public IceHockeyPlayerRepository(AbsanteeContext context, IceHockeyPlayerMapper iceHockeyPlayerMapper) : base(context!)
    {
        _iceHockeyPlayerMapper = iceHockeyPlayerMapper;
    }

    public async Task<IEnumerable<IceHockeyPlayer>> GetIceHockeyPlayersAsync()
    {
        try
        {
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayersDataModels =
                await _context.Set<IceHockeyPlayerDataModel>()
                    .ToListAsync();

            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayersDataModels);

            return iceHockeyPlayers;
        }
        catch
        {
            throw;
        }
    }

    public async Task<IceHockeyPlayer> Add(IceHockeyPlayer iceHockeyPlayer)
    {
        try
        {
            IceHockeyPlayerDataModel iceHockeyPlayerDataModel = _iceHockeyPlayerMapper.ToDataModel(iceHockeyPlayer);
            EntityEntry<IceHockeyPlayerDataModel> iceHockeyPlayerDataModelEntityEntry =
                _context.Set<IceHockeyPlayerDataModel>().Add(iceHockeyPlayerDataModel);

            await _context.SaveChangesAsync();

            IceHockeyPlayerDataModel iceHockeyPlayerDataModelSaved = iceHockeyPlayerDataModelEntityEntry.Entity;
            IceHockeyPlayer iceHockeyPlayerSaved = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModelSaved);

            return iceHockeyPlayerSaved;
        }
        catch
        {
            throw;
        }
    }

    public async Task<IceHockeyPlayer> GetIceHockeyPlayerByPlayerNameAsync(string playerName)
    {
        try
        {
            IceHockeyPlayerDataModel iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .FirstAsync(c => c.PlayerName == playerName);

            IceHockeyPlayer iceHockeyPlayer = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);

            return iceHockeyPlayer;
        }
        catch
        {
            return null;
            throw;
        }
    }

    public async Task<IceHockeyPlayer> GetIceHockeyPlayerByCountryAsync(string country)
    {
        try
        {
            IceHockeyPlayerDataModel iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .FirstAsync(c => c.Country == country);

            IceHockeyPlayer iceHockeyPlayer = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);

            return iceHockeyPlayer;
        }
        catch
        {
            return null;
            throw;
        }
    }


    public async Task<IEnumerable<IceHockeyPlayer>> GetIceHockeyPlayersByGameAsync(string game)
    {
        if(game.Trim().ToLower() == "nhl93"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL93Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl94"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL94Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl95"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL95Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl96"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL96Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl97"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL97Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl98"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL98Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl99"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL99Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl2000"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL2000Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl2001"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL2001Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl2002"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL2002Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl2003"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL2003Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl2004"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL2004Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl2005"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL2005Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl06"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL06Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl07"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL07Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl08"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL08Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl09"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL09Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl10"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL10Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl11"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL11Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl12"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL12Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl13"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL13Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl14"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL14Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl15"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL15Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl16"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL16Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl17"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL17Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl18"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL18Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl19"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL19Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl20"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL20Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl21"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL21Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl22"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL22Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl23"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL23Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl24"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL24Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl25"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL25Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        } else if(game.Trim().ToLower() == "nhl26"){
            IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .Where(c => c.NHL26Rating != null).ToListAsync();
            IEnumerable<IceHockeyPlayer> iceHockeyPlayers = _iceHockeyPlayerMapper.ToDomain(iceHockeyPlayerDataModel);
            return iceHockeyPlayers;
        }
        else {
            return Enumerable.Empty<IceHockeyPlayer>();
        }
    }

    public async Task<bool> IceHockeyPlayerExists(Guid playerId)
    {
        return await _context.Set<IceHockeyPlayerDataModel>().AnyAsync(e => e.PlayerId == playerId);
    }

    public async Task<IceHockeyPlayer> Update(IceHockeyPlayer iceHockeyPlayer, List<string> errorMessages)
    {
        try
        {
            var iceHockeyPlayerDataModel = await _context.Set<IceHockeyPlayerDataModel>()
                .FirstAsync(c => c.PlayerId == iceHockeyPlayer.PlayerId);

            _iceHockeyPlayerMapper.UpdateDataModel(iceHockeyPlayerDataModel, iceHockeyPlayer);

            _context.Entry(iceHockeyPlayerDataModel).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return iceHockeyPlayer;
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!await IceHockeyPlayerExists(iceHockeyPlayer.PlayerId))
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



    public Task<IEnumerable<IceHockeyPlayer>> GetIceHockeyPlayerByFilterAsync(string? playerName, string? country)
    {
        IQueryable<IceHockeyPlayerDataModel> query = _context.Set<IceHockeyPlayerDataModel>();

        if (!string.IsNullOrEmpty(playerName))
        {
            query = query.Where(c => EF.Functions.Like(c.PlayerName, "%" + playerName + "%"));
        }
        if (!string.IsNullOrEmpty(country))
        {
            query = query.Where(c => EF.Functions.Like(c.Country, "%" + country + "%"));
        }

        return Task.FromResult(_iceHockeyPlayerMapper.ToDomain(query.AsEnumerable()));
    }
}