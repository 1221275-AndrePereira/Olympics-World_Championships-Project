using Application.DTO;
using Application.DTO.Basketball;
using Domain.IRepository;
using Domain.Model.Basketball.BasketballPlayer;
using Domain.Model.Basketball;

namespace Application.Services;

public class BasketballPlayerService
{
    private readonly IBasketballPlayerRepository _basketballPlayerRepository;

    public BasketballPlayerService(IBasketballPlayerRepository basketballPlayerRepository)
    {
        _basketballPlayerRepository = basketballPlayerRepository;
    }
    
    public async Task<IEnumerable<BasketballPlayerDTO>> GetAllBasketballPlayers()
    {
        IEnumerable<BasketballPlayer> basketballPlayers = await _basketballPlayerRepository.GetBasketballPlayersAsync();
        IEnumerable<BasketballPlayerDTO> basketballPlayersDto = BasketballPlayerDTO.ToDTO(basketballPlayers);

        return basketballPlayersDto;
    }

    public async Task<BasketballPlayerDTO> GetBasketballPlayerByName(string playerName)
    {
        BasketballPlayer basketballPlayer = await _basketballPlayerRepository.GetBasketballPlayerByPlayerNameAsync(playerName);

        BasketballPlayerDTO basketballPlayerDto = BasketballPlayerDTO.ToDTO(basketballPlayer);
        return basketballPlayerDto;
    }

    public async Task<BasketballPlayerDTO> GetBasketballPlayerByCountry(string country)
    {
        BasketballPlayer basketballPlayer = await _basketballPlayerRepository.GetBasketballPlayerByCountryAsync(country);

        BasketballPlayerDTO basketballPlayerDto = BasketballPlayerDTO.ToDTO(basketballPlayer);
        return basketballPlayerDto;
    }

    public async Task<IEnumerable<BasketballPlayerDTO>> GetBasketballPlayersByGame(string game)
    {
        IEnumerable<BasketballPlayer> basketballPlayers = await _basketballPlayerRepository.GetBasketballPlayersByGameAsync(game);
        IEnumerable<BasketballPlayerDTO> basketballPlayersDto = BasketballPlayerDTO.ToDTO(basketballPlayers);

        return basketballPlayersDto;
    }

    public async Task<IEnumerable<BasketballPlayerDTO>> GetBasketballPlayersByFilter(BasketballPlayerFilterDTO filter)
    {
        IEnumerable<BasketballPlayer> basketballPlayers = await _basketballPlayerRepository.GetBasketballPlayerByFilterAsync(
            filter?.PlayerName,
            filter?.Country);
        return BasketballPlayerDTO.ToDTO(basketballPlayers);
    }


    public async Task<BasketballPlayerDTO> AddBasketballPlayer(CreateBasketballPlayerDTO createdBasketballPlayerDTO,
        List<string> errorMessages)
    {

        Guid id = Guid.NewGuid();

        BasketballPlayerDTO basketballPlayerDto = new BasketballPlayerDTO(
            id,
            createdBasketballPlayerDTO.PlayerName,
            createdBasketballPlayerDTO.Country,
            createdBasketballPlayerDTO.NBALive95Rating,
            createdBasketballPlayerDTO.NBALive96Rating,
            createdBasketballPlayerDTO.NBALive97Rating,
            createdBasketballPlayerDTO.NBALive98Rating,
            createdBasketballPlayerDTO.NBALive99Rating,
            createdBasketballPlayerDTO.NBA2KRating,
            createdBasketballPlayerDTO.NBA2K1Rating,
            createdBasketballPlayerDTO.NBA2K2Rating,
            createdBasketballPlayerDTO.NBA2K3Rating,
            createdBasketballPlayerDTO.NBA2K4Rating,
            createdBasketballPlayerDTO.NBA2K5Rating,
            createdBasketballPlayerDTO.NBA2K6Rating,
            createdBasketballPlayerDTO.NBA2K7Rating,
            createdBasketballPlayerDTO.NBA2K8Rating,
            createdBasketballPlayerDTO.NBA2K9Rating,
            createdBasketballPlayerDTO.NBA2K10Rating,
            createdBasketballPlayerDTO.NBA2K11Rating,
            createdBasketballPlayerDTO.NBA2K12Rating,
            createdBasketballPlayerDTO.NBA2K13Rating,
            createdBasketballPlayerDTO.NBA2K14Rating,
            createdBasketballPlayerDTO.NBA2K15Rating,
            createdBasketballPlayerDTO.NBA2K16Rating,
            createdBasketballPlayerDTO.NBA2K17Rating,
            createdBasketballPlayerDTO.NBA2K18Rating,
            createdBasketballPlayerDTO.NBA2K19Rating,
            createdBasketballPlayerDTO.NBA2K20Rating,
            createdBasketballPlayerDTO.NBA2K21Rating,
            createdBasketballPlayerDTO.NBA2K22Rating,
            createdBasketballPlayerDTO.NBA2K23Rating,
            createdBasketballPlayerDTO.NBA2K24Rating,
            createdBasketballPlayerDTO.NBA2K25Rating,
            createdBasketballPlayerDTO.NBA2K26Rating);


        BasketballPlayer basketballPlayer = BasketballPlayerDTO.ToDomain(basketballPlayerDto);

        BasketballPlayer basketballPlayerSaved = await _basketballPlayerRepository.Add(basketballPlayer);

        BasketballPlayerDTO bpDto = BasketballPlayerDTO.ToDTO(basketballPlayerSaved);
        return bpDto;
    }

    public async Task<BasketballPlayerDTO> UpdateBasketballPlayer(Guid playerId, UpdateBasketballPlayerDTO updateBasketballPlayerDTO,
        List<string> errorMessages)
    {
        bool bExists = await _basketballPlayerRepository.BasketballPlayerExists(playerId);

        if (!bExists)
        {
            errorMessages.Add("A basketball player with the entered ID does not exist");
            return null;
        }
        

        BasketballPlayerDTO basketballPlayerDto = new BasketballPlayerDTO(
            playerId,
            updateBasketballPlayerDTO.PlayerName,
            updateBasketballPlayerDTO.Country,
            updateBasketballPlayerDTO.NBALive95Rating,
            updateBasketballPlayerDTO.NBALive96Rating,
            updateBasketballPlayerDTO.NBALive97Rating,
            updateBasketballPlayerDTO.NBALive98Rating,
            updateBasketballPlayerDTO.NBALive99Rating,
            updateBasketballPlayerDTO.NBA2KRating,
            updateBasketballPlayerDTO.NBA2K1Rating,
            updateBasketballPlayerDTO.NBA2K2Rating,
            updateBasketballPlayerDTO.NBA2K3Rating,
            updateBasketballPlayerDTO.NBA2K4Rating,
            updateBasketballPlayerDTO.NBA2K5Rating,
            updateBasketballPlayerDTO.NBA2K6Rating,
            updateBasketballPlayerDTO.NBA2K7Rating,
            updateBasketballPlayerDTO.NBA2K8Rating,
            updateBasketballPlayerDTO.NBA2K9Rating,
            updateBasketballPlayerDTO.NBA2K10Rating,
            updateBasketballPlayerDTO.NBA2K11Rating,
            updateBasketballPlayerDTO.NBA2K12Rating,
            updateBasketballPlayerDTO.NBA2K13Rating,
            updateBasketballPlayerDTO.NBA2K14Rating,
            updateBasketballPlayerDTO.NBA2K15Rating,
            updateBasketballPlayerDTO.NBA2K16Rating,
            updateBasketballPlayerDTO.NBA2K17Rating,
            updateBasketballPlayerDTO.NBA2K18Rating,
            updateBasketballPlayerDTO.NBA2K19Rating,
            updateBasketballPlayerDTO.NBA2K20Rating,
            updateBasketballPlayerDTO.NBA2K21Rating,
            updateBasketballPlayerDTO.NBA2K22Rating,
            updateBasketballPlayerDTO.NBA2K23Rating,
            updateBasketballPlayerDTO.NBA2K24Rating,
            updateBasketballPlayerDTO.NBA2K25Rating,
            updateBasketballPlayerDTO.NBA2K26Rating);

        BasketballPlayer basketballPlayer = BasketballPlayerDTO.ToDomain(basketballPlayerDto);

        BasketballPlayer updatedBasketballPlayer = await _basketballPlayerRepository.Update(basketballPlayer, errorMessages);
        BasketballPlayerDTO basketballPlayerDTO = BasketballPlayerDTO.ToDTO(updatedBasketballPlayer);
        return basketballPlayerDTO;
    }
}