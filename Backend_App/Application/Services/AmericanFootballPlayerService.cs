using Application.DTO;
using Application.DTO.AmericanFootball;
using Domain.IRepository;
using Domain.Model.AmericanFootball.AmericanFootballPlayer;
using Domain.Model.AmericanFootball;

namespace Application.Services;

public class AmericanFootballPlayerService
{
    private readonly IAmericanFootballPlayerRepository _americanFootballPlayerRepository;

    public AmericanFootballPlayerService(IAmericanFootballPlayerRepository americanFootballPlayerRepository)
    {
        _americanFootballPlayerRepository = americanFootballPlayerRepository;
    }
    
    public async Task<IEnumerable<AmericanFootballPlayerDTO>> GetAllAmericanFootballPlayers()
    {
        IEnumerable<AmericanFootballPlayer> americanFootballPlayers = await _americanFootballPlayerRepository.GetAmericanFootballPlayersAsync();
        IEnumerable<AmericanFootballPlayerDTO> americanFootballPlayersDto = AmericanFootballPlayerDTO.ToDTO(americanFootballPlayers);

        return americanFootballPlayersDto;
    }

    public async Task<AmericanFootballPlayerDTO> GetAmericanFootballPlayerByName(string playerName)
    {
        AmericanFootballPlayer americanFootballPlayer = await _americanFootballPlayerRepository.GetAmericanFootballPlayerByPlayerNameAsync(playerName);

        AmericanFootballPlayerDTO americanFootballPlayerDto = AmericanFootballPlayerDTO.ToDTO(americanFootballPlayer);
        return americanFootballPlayerDto;
    }

    public async Task<IEnumerable<AmericanFootballPlayerDTO>> GetAmericanFootballPlayersByGame(string game)
    {
        IEnumerable<AmericanFootballPlayer> americanFootballPlayers = await _americanFootballPlayerRepository.GetAmericanFootballPlayersByGameAsync(game);
        IEnumerable<AmericanFootballPlayerDTO> americanFootballPlayersDto = AmericanFootballPlayerDTO.ToDTO(americanFootballPlayers);

        return americanFootballPlayersDto;
    }

    public async Task<IEnumerable<AmericanFootballPlayerDTO>> GetAmericanFootballPlayersByFilter(AmericanFootballPlayerFilterDTO filter)
    {
        IEnumerable<AmericanFootballPlayer> americanFootballPlayers = await _americanFootballPlayerRepository.GetAmericanFootballPlayerByFilterAsync(
            filter?.PlayerName);
        return AmericanFootballPlayerDTO.ToDTO(americanFootballPlayers);
    }


    public async Task<AmericanFootballPlayerDTO> AddAmericanFootballPlayer(CreateAmericanFootballPlayerDTO createdAmericanFootballPlayerDTO,
        List<string> errorMessages)
    {

        Guid id = Guid.NewGuid();

        AmericanFootballPlayerDTO americanFootballPlayerDto = new AmericanFootballPlayerDTO(
            id,
            createdAmericanFootballPlayerDTO.PlayerName,
            createdAmericanFootballPlayerDTO.NFLGameday98Rating,
            createdAmericanFootballPlayerDTO.NFLGameday99Rating,
            createdAmericanFootballPlayerDTO.MaddenNFL2000Rating,
            createdAmericanFootballPlayerDTO.MaddenNFL2001Rating,
            createdAmericanFootballPlayerDTO.MaddenNFL2002Rating,
            createdAmericanFootballPlayerDTO.MaddenNFL2003Rating,
            createdAmericanFootballPlayerDTO.MaddenNFL2004Rating,
            createdAmericanFootballPlayerDTO.MaddenNFL2005Rating,
            createdAmericanFootballPlayerDTO.MaddenNFL06Rating,
            createdAmericanFootballPlayerDTO.MaddenNFL07Rating,
            createdAmericanFootballPlayerDTO.MaddenNFL08Rating,
            createdAmericanFootballPlayerDTO.MaddenNFL09Rating,
            createdAmericanFootballPlayerDTO.MaddenNFL10Rating,
            createdAmericanFootballPlayerDTO.MaddenNFL11Rating,
            createdAmericanFootballPlayerDTO.MaddenNFL12Rating,
            createdAmericanFootballPlayerDTO.MaddenNFL13Rating,
            createdAmericanFootballPlayerDTO.MaddenNFL14Rating,
            createdAmericanFootballPlayerDTO.MaddenNFL15Rating,
            createdAmericanFootballPlayerDTO.MaddenNFL16Rating,
            createdAmericanFootballPlayerDTO.MaddenNFL17Rating,
            createdAmericanFootballPlayerDTO.MaddenNFL18Rating,
            createdAmericanFootballPlayerDTO.MaddenNFL19Rating,
            createdAmericanFootballPlayerDTO.MaddenNFL20Rating,
            createdAmericanFootballPlayerDTO.MaddenNFL21Rating,
            createdAmericanFootballPlayerDTO.MaddenNFL22Rating,
            createdAmericanFootballPlayerDTO.MaddenNFL23Rating,
            createdAmericanFootballPlayerDTO.MaddenNFL24Rating,
            createdAmericanFootballPlayerDTO.MaddenNFL25Rating,
            createdAmericanFootballPlayerDTO.MaddenNFL26Rating);


        AmericanFootballPlayer americanFootballPlayer = AmericanFootballPlayerDTO.ToDomain(americanFootballPlayerDto);

        AmericanFootballPlayer americanFootballPlayerSaved = await _americanFootballPlayerRepository.Add(americanFootballPlayer);

        AmericanFootballPlayerDTO afpDto = AmericanFootballPlayerDTO.ToDTO(americanFootballPlayerSaved);
        return afpDto;
    }

    public async Task<AmericanFootballPlayerDTO> UpdateAmericanFootballPlayer(Guid playerId, UpdateAmericanFootballPlayerDTO updateAmericanFootballPlayerDTO,
        List<string> errorMessages)
    {
        bool bExists = await _americanFootballPlayerRepository.AmericanFootballPlayerExists(playerId);

        if (!bExists)
        {
            errorMessages.Add("An american football player with the entered ID does not exist");
            return null;
        }
        

        AmericanFootballPlayerDTO americanFootballPlayerDto = new AmericanFootballPlayerDTO(
            playerId,
            updateAmericanFootballPlayerDTO.PlayerName,
            updateAmericanFootballPlayerDTO.NFLGameday98Rating,
            updateAmericanFootballPlayerDTO.NFLGameday99Rating,
            updateAmericanFootballPlayerDTO.MaddenNFL2000Rating,
            updateAmericanFootballPlayerDTO.MaddenNFL2001Rating,
            updateAmericanFootballPlayerDTO.MaddenNFL2002Rating,
            updateAmericanFootballPlayerDTO.MaddenNFL2003Rating,
            updateAmericanFootballPlayerDTO.MaddenNFL2004Rating,
            updateAmericanFootballPlayerDTO.MaddenNFL2005Rating,
            updateAmericanFootballPlayerDTO.MaddenNFL06Rating,
            updateAmericanFootballPlayerDTO.MaddenNFL07Rating,
            updateAmericanFootballPlayerDTO.MaddenNFL08Rating,
            updateAmericanFootballPlayerDTO.MaddenNFL09Rating,
            updateAmericanFootballPlayerDTO.MaddenNFL10Rating,
            updateAmericanFootballPlayerDTO.MaddenNFL11Rating,
            updateAmericanFootballPlayerDTO.MaddenNFL12Rating,
            updateAmericanFootballPlayerDTO.MaddenNFL13Rating,
            updateAmericanFootballPlayerDTO.MaddenNFL14Rating,
            updateAmericanFootballPlayerDTO.MaddenNFL15Rating,
            updateAmericanFootballPlayerDTO.MaddenNFL16Rating,
            updateAmericanFootballPlayerDTO.MaddenNFL17Rating,
            updateAmericanFootballPlayerDTO.MaddenNFL18Rating,
            updateAmericanFootballPlayerDTO.MaddenNFL19Rating,
            updateAmericanFootballPlayerDTO.MaddenNFL20Rating,
            updateAmericanFootballPlayerDTO.MaddenNFL21Rating,
            updateAmericanFootballPlayerDTO.MaddenNFL22Rating,
            updateAmericanFootballPlayerDTO.MaddenNFL23Rating,
            updateAmericanFootballPlayerDTO.MaddenNFL24Rating,
            updateAmericanFootballPlayerDTO.MaddenNFL25Rating,
            updateAmericanFootballPlayerDTO.MaddenNFL26Rating);

        AmericanFootballPlayer americanFootballPlayer = AmericanFootballPlayerDTO.ToDomain(americanFootballPlayerDto);

        AmericanFootballPlayer updatedAmericanFootballPlayer = await _americanFootballPlayerRepository.Update(americanFootballPlayer, errorMessages);

        AmericanFootballPlayerDTO americanFootballPlayerDTO = AmericanFootballPlayerDTO.ToDTO(updatedAmericanFootballPlayer);
        return americanFootballPlayerDTO;
    }
}