using Application.DTO;
using Application.DTO.Handball;
using Domain.IRepository;
using Domain.Model.Handball.HandballPlayer;
using Domain.Model.Handball;

namespace Application.Services;

public class HandballPlayerService
{
    private readonly IHandballPlayerRepository _handballPlayerRepository;

    public HandballPlayerService(IHandballPlayerRepository handballPlayerRepository)
    {
        _handballPlayerRepository = handballPlayerRepository;
    }
    
    public async Task<IEnumerable<HandballPlayerDTO>> GetAllHandballPlayers()
    {
        IEnumerable<HandballPlayer> handballPlayers = await _handballPlayerRepository.GetHandballPlayersAsync();
        IEnumerable<HandballPlayerDTO> handballPlayersDto = HandballPlayerDTO.ToDTO(handballPlayers);

        return handballPlayersDto;
    }

    public async Task<HandballPlayerDTO> GetHandballPlayerByName(string playerName)
    {
        HandballPlayer handballPlayer = await _handballPlayerRepository.GetHandballPlayerByPlayerNameAsync(playerName);

        HandballPlayerDTO handballPlayerDto = HandballPlayerDTO.ToDTO(handballPlayer);
        return handballPlayerDto;
    }

    public async Task<HandballPlayerDTO> GetHandballPlayerByCountry(string country)
    {
        HandballPlayer handballPlayer = await _handballPlayerRepository.GetHandballPlayerByCountryAsync(country);

        HandballPlayerDTO handballPlayerDto = HandballPlayerDTO.ToDTO(handballPlayer);
        return handballPlayerDto;
    }

    public async Task<IEnumerable<HandballPlayerDTO>> GetHandballPlayersByGame(string game)
    {
        IEnumerable<HandballPlayer> handballPlayers = await _handballPlayerRepository.GetHandballPlayersByGameAsync(game);
        IEnumerable<HandballPlayerDTO> handballPlayersDto = HandballPlayerDTO.ToDTO(handballPlayers);

        return handballPlayersDto;
    }

    public async Task<IEnumerable<HandballPlayerDTO>> GetHandballPlayersByFilter(HandballPlayerFilterDTO filter)
    {
        IEnumerable<HandballPlayer> handballPlayers = await _handballPlayerRepository.GetHandballPlayerByFilterAsync(
            filter?.PlayerName,
            filter?.Country);
        return HandballPlayerDTO.ToDTO(handballPlayers);
    }


    public async Task<HandballPlayerDTO> AddHandballPlayer(CreateHandballPlayerDTO createdHandballPlayerDTO,
        List<string> errorMessages)
    {

        Guid id = Guid.NewGuid();

        HandballPlayerDTO handballPlayerDto = new HandballPlayerDTO(
            id,
            createdHandballPlayerDTO.PlayerName,
            createdHandballPlayerDTO.Country,
            createdHandballPlayerDTO.Handball17Rating,
            createdHandballPlayerDTO.Handball21Rating);


        HandballPlayer handballPlayer = HandballPlayerDTO.ToDomain(handballPlayerDto);

        HandballPlayer handballPlayerSaved = await _handballPlayerRepository.Add(handballPlayer);

        HandballPlayerDTO hpDto = HandballPlayerDTO.ToDTO(handballPlayerSaved);
        return hpDto;
    }

    public async Task<HandballPlayerDTO> UpdateHandballPlayer(Guid playerId, UpdateHandballPlayerDTO updateHandballPlayerDTO,
        List<string> errorMessages)
    {
        bool bExists = await _handballPlayerRepository.HandballPlayerExists(playerId);

        if (!bExists)
        {
            errorMessages.Add("A handball player with the entered ID does not exist");
            return null;
        }
        

        HandballPlayerDTO handballPlayerDto = new HandballPlayerDTO(
            playerId,
            updateHandballPlayerDTO.PlayerName,
            updateHandballPlayerDTO.Country,
            updateHandballPlayerDTO.Handball17Rating,
            updateHandballPlayerDTO.Handball21Rating);

        HandballPlayer handballPlayer = HandballPlayerDTO.ToDomain(handballPlayerDto);

        HandballPlayer updatedHandballPlayer = await _handballPlayerRepository.Update(handballPlayer, errorMessages);
        HandballPlayerDTO handballPlayerDTO = HandballPlayerDTO.ToDTO(updatedHandballPlayer);
        return handballPlayerDTO;
    }
}