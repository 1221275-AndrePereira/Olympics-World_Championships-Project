using Domain.IRepository;
using Microsoft.EntityFrameworkCore;
using DataModel.Mapper;
using DataModel.Model;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Domain.Model.Basketball;
using Domain.Model.Basketball.BasketballPlayer;
using System.ComponentModel;

namespace DataModel.Repository;

public class BasketballPlayerRepository : GenericRepository<BasketballPlayer>, IBasketballPlayerRepository
{
    private BasketballPlayerMapper _basketballPlayerMapper;

    public BasketballPlayerRepository(AbsanteeContext context, BasketballPlayerMapper basketballPlayerMapper) : base(context!)
    {
        _basketballPlayerMapper = basketballPlayerMapper;
    }

    public async Task<IEnumerable<BasketballPlayer>> GetBasketballPlayersAsync()
    {
        try
        {
            IEnumerable<BasketballPlayerDataModel> basketballPlayersDataModels =
                await _context.Set<BasketballPlayerDataModel>()
                    .ToListAsync();

            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayersDataModels);

            return basketballPlayers;
        }
        catch
        {
            throw;
        }
    }

    public async Task<BasketballPlayer> Add(BasketballPlayer basketballPlayer)
    {
        try
        {
            BasketballPlayerDataModel basketballPlayerDataModel = _basketballPlayerMapper.ToDataModel(basketballPlayer);
            EntityEntry<BasketballPlayerDataModel> basketballPlayerDataModelEntityEntry =
                _context.Set<BasketballPlayerDataModel>().Add(basketballPlayerDataModel);

            await _context.SaveChangesAsync();

            BasketballPlayerDataModel basketballPlayerDataModelSaved = basketballPlayerDataModelEntityEntry.Entity;
            BasketballPlayer basketballPlayerSaved = _basketballPlayerMapper.ToDomain(basketballPlayerDataModelSaved);

            return basketballPlayerSaved;
        }
        catch
        {
            throw;
        }
    }

    public async Task<BasketballPlayer> GetBasketballPlayerByPlayerNameAsync(string playerName)
    {
        try
        {
            BasketballPlayerDataModel basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .FirstAsync(c => c.PlayerName == playerName);

            BasketballPlayer basketballPlayer = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);

            return basketballPlayer;
        }
        catch
        {
            return null;
            throw;
        }
    }

    public async Task<BasketballPlayer> GetBasketballPlayerByCountryAsync(string country)
    {
        try
        {
            BasketballPlayerDataModel basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .FirstAsync(c => c.Country == country);

            BasketballPlayer basketballPlayer = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);

            return basketballPlayer;
        }
        catch
        {
            return null;
            throw;
        }
    }


    public async Task<IEnumerable<BasketballPlayer>> GetBasketballPlayersByGameAsync(string game)
    {
        if(game.Trim().ToLower() == "nbalive95"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBALive95Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nbalive96"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBALive96Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nbalive97"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBALive97Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nbalive98"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBALive98Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nbalive99"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBALive99Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nba2k"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBA2KRating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nba2k1"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBA2K1Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nba2k2"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBA2K2Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nba2k3"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBA2K3Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nba2k4"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBA2K4Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nba2k5"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBA2K5Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nba2k6"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBA2K6Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nba2k7"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBA2K7Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nba2k8"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBA2K8Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nba2k9"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBA2K9Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nba2k10"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBA2K10Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nba2k11"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBA2K11Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nba2k12"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBA2K12Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nba2k13"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBA2K13Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nba2k14"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBA2K14Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nba2k15"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBA2K15Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nba2k16"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBA2K16Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nba2k17"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBA2K17Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nba2k18"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBA2K18Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nba2k19"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBA2K19Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nba2k20"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBA2K20Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nba2k21"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBA2K21Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nba2k22"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBA2K22Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nba2k23"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBA2K23Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nba2k24"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBA2K24Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nba2k25"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBA2K25Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        } else if(game.Trim().ToLower() == "nba2k26"){
            IEnumerable<BasketballPlayerDataModel> basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .Where(c => c.NBA2K26Rating != null).ToListAsync();
            IEnumerable<BasketballPlayer> basketballPlayers = _basketballPlayerMapper.ToDomain(basketballPlayerDataModel);
            return basketballPlayers;
        }
        else {
            return Enumerable.Empty<BasketballPlayer>();
        }
    }

    public async Task<bool> BasketballPlayerExists(Guid playerId)
    {
        return await _context.Set<BasketballPlayerDataModel>().AnyAsync(e => e.PlayerId == playerId);
    }

    public async Task<BasketballPlayer> Update(BasketballPlayer basketballPlayer, List<string> errorMessages)
    {
        try
        {
            var basketballPlayerDataModel = await _context.Set<BasketballPlayerDataModel>()
                .FirstAsync(c => c.PlayerId == basketballPlayer.PlayerId);

            _basketballPlayerMapper.UpdateDataModel(basketballPlayerDataModel, basketballPlayer);

            _context.Entry(basketballPlayerDataModel).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return basketballPlayer;
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!await BasketballPlayerExists(basketballPlayer.PlayerId))
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



    public Task<IEnumerable<BasketballPlayer>> GetBasketballPlayerByFilterAsync(string? playerName, string? country)
    {
        IQueryable<BasketballPlayerDataModel> query = _context.Set<BasketballPlayerDataModel>();

        if (!string.IsNullOrEmpty(playerName))
        {
            query = query.Where(c => EF.Functions.Like(c.PlayerName, "%" + playerName + "%"));
        }
        if (!string.IsNullOrEmpty(country))
        {
            query = query.Where(c => EF.Functions.Like(c.Country, "%" + country + "%"));
        }

        return Task.FromResult(_basketballPlayerMapper.ToDomain(query.AsEnumerable()));
    }
}