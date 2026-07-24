using Domain.IRepository;
using Microsoft.EntityFrameworkCore;
using DataModel.Mapper;
using DataModel.Model;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Domain.Model.Handball;
using Domain.Model.Handball.HandballPlayer;
using System.ComponentModel;

namespace DataModel.Repository;

public class HandballPlayerRepository : GenericRepository<HandballPlayer>, IHandballPlayerRepository
{
    private HandballPlayerMapper _handballPlayerMapper;

    public HandballPlayerRepository(AbsanteeContext context, HandballPlayerMapper handballPlayerMapper) : base(context!)
    {
        _handballPlayerMapper = handballPlayerMapper;
    }

    public async Task<IEnumerable<HandballPlayer>> GetHandballPlayersAsync()
    {
        try
        {
            IEnumerable<HandballPlayerDataModel> handballPlayersDataModels =
                await _context.Set<HandballPlayerDataModel>()
                    .ToListAsync();

            IEnumerable<HandballPlayer> handballPlayers = _handballPlayerMapper.ToDomain(handballPlayersDataModels);

            return handballPlayers;
        }
        catch
        {
            throw;
        }
    }

    public async Task<HandballPlayer> Add(HandballPlayer handballPlayer)
    {
        try
        {
            HandballPlayerDataModel handballPlayerDataModel = _handballPlayerMapper.ToDataModel(handballPlayer);
            EntityEntry<HandballPlayerDataModel> handballPlayerDataModelEntityEntry =
                _context.Set<HandballPlayerDataModel>().Add(handballPlayerDataModel);

            await _context.SaveChangesAsync();

            HandballPlayerDataModel handballPlayerDataModelSaved = handballPlayerDataModelEntityEntry.Entity;
            HandballPlayer handballPlayerSaved = _handballPlayerMapper.ToDomain(handballPlayerDataModelSaved);

            return handballPlayerSaved;
        }
        catch
        {
            throw;
        }
    }

    public async Task<HandballPlayer> GetHandballPlayerByPlayerNameAsync(string playerName)
    {
        try
        {
            HandballPlayerDataModel handballPlayerDataModel = await _context.Set<HandballPlayerDataModel>()
                .FirstAsync(c => c.PlayerName == playerName);

            HandballPlayer handballPlayer = _handballPlayerMapper.ToDomain(handballPlayerDataModel);

            return handballPlayer;
        }
        catch
        {
            return null;
            throw;
        }
    }

    public async Task<HandballPlayer> GetHandballPlayerByCountryAsync(string country)
    {
        try
        {
            HandballPlayerDataModel handballPlayerDataModel = await _context.Set<HandballPlayerDataModel>()
                .FirstAsync(c => c.Country == country);

            HandballPlayer handballPlayer = _handballPlayerMapper.ToDomain(handballPlayerDataModel);

            return handballPlayer;
        }
        catch
        {
            return null;
            throw;
        }
    }


    public async Task<IEnumerable<HandballPlayer>> GetHandballPlayersByGameAsync(string game)
    {
        if(game.Trim().ToLower() == "handball17"){
            IEnumerable<HandballPlayerDataModel> handballPlayerDataModel = await _context.Set<HandballPlayerDataModel>()
                .Where(c => c.Handball17Rating != null).ToListAsync();
            IEnumerable<HandballPlayer> handballPlayers = _handballPlayerMapper.ToDomain(handballPlayerDataModel);
            return handballPlayers;
        } else if(game.Trim().ToLower() == "handball21"){
            IEnumerable<HandballPlayerDataModel> handballPlayerDataModel = await _context.Set<HandballPlayerDataModel>()
                .Where(c => c.Handball21Rating != null).ToListAsync();
            IEnumerable<HandballPlayer> handballPlayers = _handballPlayerMapper.ToDomain(handballPlayerDataModel);
            return handballPlayers;
        }
        else {
            return Enumerable.Empty<HandballPlayer>();
        }
    }

    public async Task<bool> HandballPlayerExists(Guid playerId)
    {
        return await _context.Set<HandballPlayerDataModel>().AnyAsync(e => e.PlayerId == playerId);
    }

    public async Task<HandballPlayer> Update(HandballPlayer handballPlayer, List<string> errorMessages)
    {
        try
        {
            var handballPlayerDataModel = await _context.Set<HandballPlayerDataModel>()
                .FirstAsync(c => c.PlayerId == handballPlayer.PlayerId);

            _handballPlayerMapper.UpdateDataModel(handballPlayerDataModel, handballPlayer);

            _context.Entry(handballPlayerDataModel).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return handballPlayer;
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!await HandballPlayerExists(handballPlayer.PlayerId))
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



    public Task<IEnumerable<HandballPlayer>> GetHandballPlayerByFilterAsync(string? playerName, string? country)
    {
        IQueryable<HandballPlayerDataModel> query = _context.Set<HandballPlayerDataModel>();

        if (!string.IsNullOrEmpty(playerName))
        {
            query = query.Where(c => EF.Functions.Like(c.PlayerName, "%" + playerName + "%"));
        }
        if (!string.IsNullOrEmpty(country))
        {
            query = query.Where(c => EF.Functions.Like(c.Country, "%" + country + "%"));
        }

        return Task.FromResult(_handballPlayerMapper.ToDomain(query.AsEnumerable()));
    }
}