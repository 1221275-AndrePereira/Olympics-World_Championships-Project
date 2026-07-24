using Domain.IRepository;
using Microsoft.EntityFrameworkCore;
using DataModel.Mapper;
using DataModel.Model;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Domain.Model.Baseball;
using Domain.Model.Baseball.BaseballPlayer;
using System.ComponentModel;

namespace DataModel.Repository;

public class BaseballPlayerRepository : GenericRepository<BaseballPlayer>, IBaseballPlayerRepository
{
    private BaseballPlayerMapper _baseballPlayerMapper;

    public BaseballPlayerRepository(AbsanteeContext context, BaseballPlayerMapper baseballPlayerMapper) : base(context!)
    {
        _baseballPlayerMapper = baseballPlayerMapper;
    }

    public async Task<IEnumerable<BaseballPlayer>> GetBaseballPlayersAsync()
    {
        try
        {
            IEnumerable<BaseballPlayerDataModel> baseballPlayersDataModels =
                await _context.Set<BaseballPlayerDataModel>()
                    .ToListAsync();

            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayersDataModels);

            return baseballPlayers;
        }
        catch
        {
            throw;
        }
    }

    public async Task<BaseballPlayer> Add(BaseballPlayer baseballPlayer)
    {
        try
        {
            BaseballPlayerDataModel baseballPlayerDataModel = _baseballPlayerMapper.ToDataModel(baseballPlayer);
            EntityEntry<BaseballPlayerDataModel> baseballPlayerDataModelEntityEntry =
                _context.Set<BaseballPlayerDataModel>().Add(baseballPlayerDataModel);

            await _context.SaveChangesAsync();

            BaseballPlayerDataModel baseballPlayerDataModelSaved = baseballPlayerDataModelEntityEntry.Entity;
            BaseballPlayer baseballPlayerSaved = _baseballPlayerMapper.ToDomain(baseballPlayerDataModelSaved);

            return baseballPlayerSaved;
        }
        catch
        {
            throw;
        }
    }

    public async Task<BaseballPlayer> GetBaseballPlayerByPlayerNameAsync(string playerName)
    {
        try
        {
            BaseballPlayerDataModel baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .FirstAsync(c => c.PlayerName == playerName);

            BaseballPlayer baseballPlayer = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);

            return baseballPlayer;
        }
        catch
        {
            return null;
            throw;
        }
    }

    public async Task<BaseballPlayer> GetBaseballPlayerByCountryAsync(string country)
    {
        try
        {
            BaseballPlayerDataModel baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .FirstAsync(c => c.Country == country);

            BaseballPlayer baseballPlayer = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);

            return baseballPlayer;
        }
        catch
        {
            return null;
            throw;
        }
    }


    public async Task<IEnumerable<BaseballPlayer>> GetBaseballPlayersByGameAsync(string game)
    {
        if(game.Trim().ToLower() == "tripleplay99"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLBTriplePlay99Rating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        } else if(game.Trim().ToLower() == "tripleplay2000"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLBTriplePlay2000Rating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        } else if(game.Trim().ToLower() == "tripleplay2001"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLBTriplePlay2001Rating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        } else if(game.Trim().ToLower() == "tripleplaybaseball"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLBTriplePlayBaseballRating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        } else if(game.Trim().ToLower() == "tripleplay2002"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLBTriplePlay2002Rating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        } else if(game.Trim().ToLower() == "mlb2004"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLB2004Rating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        } else if(game.Trim().ToLower() == "mlbespn"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLBESPNRating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        } else if(game.Trim().ToLower() == "mlb2k5"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLB2K5Rating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        } else if(game.Trim().ToLower() == "mlb2k6"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLB2K6Rating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        } else if(game.Trim().ToLower() == "mlb2k7"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLB2K7Rating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        } else if(game.Trim().ToLower() == "mlb2k8"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLB2K8Rating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        } else if(game.Trim().ToLower() == "mlb2k9"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLB2K9Rating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        } else if(game.Trim().ToLower() == "mlb2k10"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLB2K10Rating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        } else if(game.Trim().ToLower() == "mlb2k11"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLB2K11Rating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        } else if(game.Trim().ToLower() == "mlb2k12"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLB2K12Rating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        } else if(game.Trim().ToLower() == "theshow13"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLBTheShow13Rating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        } else if(game.Trim().ToLower() == "theshow14"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLBTheShow14Rating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        } else if(game.Trim().ToLower() == "theshow15"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLBTheShow15Rating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        } else if(game.Trim().ToLower() == "theshow16"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLBTheShow16Rating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        } else if(game.Trim().ToLower() == "theshow17"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLBTheShow17Rating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        } else if(game.Trim().ToLower() == "theshow18"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLBTheShow18Rating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        } else if(game.Trim().ToLower() == "theshow19"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLBTheShow19Rating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        } else if(game.Trim().ToLower() == "theshow20"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLBTheShow20Rating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        } else if(game.Trim().ToLower() == "theshow21"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLBTheShow21Rating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        } else if(game.Trim().ToLower() == "theshow22"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLBTheShow22Rating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        } else if(game.Trim().ToLower() == "theshow23"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLBTheShow23Rating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        } else if(game.Trim().ToLower() == "theshow24"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLBTheShow24Rating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        } else if(game.Trim().ToLower() == "theshow25"){
            IEnumerable<BaseballPlayerDataModel> baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .Where(c => c.MLBTheShow25Rating != null).ToListAsync();
            IEnumerable<BaseballPlayer> baseballPlayers = _baseballPlayerMapper.ToDomain(baseballPlayerDataModel);
            return baseballPlayers;
        }
        else {
            return Enumerable.Empty<BaseballPlayer>();
        }
    }

    public async Task<bool> BaseballPlayerExists(Guid playerId)
    {
        return await _context.Set<BaseballPlayerDataModel>().AnyAsync(e => e.PlayerId == playerId);
    }

    public async Task<BaseballPlayer> Update(BaseballPlayer baseballPlayer, List<string> errorMessages)
    {
        try
        {
            var baseballPlayerDataModel = await _context.Set<BaseballPlayerDataModel>()
                .FirstAsync(c => c.PlayerId == baseballPlayer.PlayerId);

            _baseballPlayerMapper.UpdateDataModel(baseballPlayerDataModel, baseballPlayer);

            _context.Entry(baseballPlayerDataModel).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return baseballPlayer;
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!await BaseballPlayerExists(baseballPlayer.PlayerId))
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



    public Task<IEnumerable<BaseballPlayer>> GetBaseballPlayerByFilterAsync(string? playerName, string? country)
    {
        IQueryable<BaseballPlayerDataModel> query = _context.Set<BaseballPlayerDataModel>();

        if (!string.IsNullOrEmpty(playerName))
        {
            query = query.Where(c => EF.Functions.Like(c.PlayerName, "%" + playerName + "%"));
        }
        if (!string.IsNullOrEmpty(country))
        {
            query = query.Where(c => EF.Functions.Like(c.Country, "%" + country + "%"));
        }

        return Task.FromResult(_baseballPlayerMapper.ToDomain(query.AsEnumerable()));
    }
}