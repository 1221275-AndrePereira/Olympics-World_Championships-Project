using Domain.IRepository;
using Microsoft.EntityFrameworkCore;
using DataModel.Mapper;
using DataModel.Model;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Domain.Model.AmericanFootball;
using Domain.Model.AmericanFootball.AmericanFootballPlayer;
using System.ComponentModel;

namespace DataModel.Repository;

public class AmericanFootballPlayerRepository : GenericRepository<AmericanFootballPlayer>, IAmericanFootballPlayerRepository
{
    private AmericanFootballPlayerMapper _americanFootballPlayerMapper;

    public AmericanFootballPlayerRepository(AbsanteeContext context, AmericanFootballPlayerMapper americanFootballPlayerMapper) : base(context!)
    {
        _americanFootballPlayerMapper = americanFootballPlayerMapper;
    }

    public async Task<IEnumerable<AmericanFootballPlayer>> GetAmericanFootballPlayersAsync()
    {
        try
        {
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayersDataModels =
                await _context.Set<AmericanFootballPlayerDataModel>()
                    .ToListAsync();

            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayersDataModels);

            return americanFootballPlayers;
        }
        catch
        {
            throw;
        }
    }

    public async Task<AmericanFootballPlayer> Add(AmericanFootballPlayer americanFootballPlayer)
    {
        try
        {
            AmericanFootballPlayerDataModel americanFootballPlayerDataModel = _americanFootballPlayerMapper.ToDataModel(americanFootballPlayer);
            EntityEntry<AmericanFootballPlayerDataModel> americanFootballPlayerDataModelEntityEntry =
                _context.Set<AmericanFootballPlayerDataModel>().Add(americanFootballPlayerDataModel);

            await _context.SaveChangesAsync();

            AmericanFootballPlayerDataModel americanFootballPlayerDataModelSaved = americanFootballPlayerDataModelEntityEntry.Entity;
            AmericanFootballPlayer americanFootballPlayerSaved = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModelSaved);

            return americanFootballPlayerSaved;
        }
        catch
        {
            throw;
        }
    }

    public async Task<AmericanFootballPlayer> GetAmericanFootballPlayerByPlayerNameAsync(string playerName)
    {
        try
        {
            AmericanFootballPlayerDataModel americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .FirstAsync(c => c.PlayerName == playerName);

            AmericanFootballPlayer americanFootballPlayer = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);

            return americanFootballPlayer;
        }
        catch
        {
            return null;
            throw;
        }
    }


    public async Task<IEnumerable<AmericanFootballPlayer>> GetAmericanFootballPlayersByGameAsync(string game)
    {
        if(game.Trim().ToLower() == "gameday98"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.NFLGameday98Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "gameday99"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.NFLGameday99Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "madden2000"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.MaddenNFL2000Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "madden2001"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.MaddenNFL2001Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "madden2002"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.MaddenNFL2002Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "madden2003"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.MaddenNFL2003Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "madden2004"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.MaddenNFL2004Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "madden2005"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.MaddenNFL2005Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "madden06"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.MaddenNFL06Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "madden07"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.MaddenNFL07Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "madden08"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.MaddenNFL08Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "madden09"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.MaddenNFL09Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "madden10"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.MaddenNFL10Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "madden11"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.MaddenNFL11Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "madden12"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.MaddenNFL12Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "madden13"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.MaddenNFL13Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "madden14"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.MaddenNFL14Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "madden15"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.MaddenNFL15Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "madden16"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.MaddenNFL16Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "madden17"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.MaddenNFL17Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "madden18"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.MaddenNFL18Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "madden19"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.MaddenNFL19Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "madden20"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.MaddenNFL20Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "madden21"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.MaddenNFL21Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "madden22"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.MaddenNFL22Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "madden23"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.MaddenNFL23Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "madden24"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.MaddenNFL24Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "madden25"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.MaddenNFL25Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        } else if(game.Trim().ToLower() == "madden26"){
            IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .Where(c => c.MaddenNFL26Rating != null).ToListAsync();
            IEnumerable<AmericanFootballPlayer> americanFootballPlayers = _americanFootballPlayerMapper.ToDomain(americanFootballPlayerDataModel);
            return americanFootballPlayers;
        }
        else {
            return Enumerable.Empty<AmericanFootballPlayer>();
        }
    }

    public async Task<bool> AmericanFootballPlayerExists(Guid playerId)
    {
        return await _context.Set<AmericanFootballPlayerDataModel>().AnyAsync(e => e.PlayerId == playerId);
    }

    public async Task<AmericanFootballPlayer> Update(AmericanFootballPlayer americanFootballPlayer, List<string> errorMessages)
    {
        try
        {
            var americanFootballPlayerDataModel = await _context.Set<AmericanFootballPlayerDataModel>()
                .FirstAsync(c => c.PlayerId == americanFootballPlayer.PlayerId);

            _americanFootballPlayerMapper.UpdateDataModel(americanFootballPlayerDataModel, americanFootballPlayer);

            _context.Entry(americanFootballPlayerDataModel).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return americanFootballPlayer;
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!await AmericanFootballPlayerExists(americanFootballPlayer.PlayerId))
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



    public Task<IEnumerable<AmericanFootballPlayer>> GetAmericanFootballPlayerByFilterAsync(string? playerName)
    {
        IQueryable<AmericanFootballPlayerDataModel> query = _context.Set<AmericanFootballPlayerDataModel>();

        if (!string.IsNullOrEmpty(playerName))
        {
            query = query.Where(c => EF.Functions.Like(c.PlayerName, "%" + playerName + "%"));
        }

        return Task.FromResult(_americanFootballPlayerMapper.ToDomain(query.AsEnumerable()));
    }
}