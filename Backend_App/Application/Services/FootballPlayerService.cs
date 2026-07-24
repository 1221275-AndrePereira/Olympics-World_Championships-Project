using Application.DTO;
using Application.DTO.Football;
using Domain.IRepository;
using Domain.Model.Football.FootballPlayer;
using Domain.Model.Football;

namespace Application.Services;

public class FootballPlayerService
{
    private readonly IFootballPlayerRepository _footballPlayerRepository;

    public FootballPlayerService(IFootballPlayerRepository footballPlayerRepository)
    {
        _footballPlayerRepository = footballPlayerRepository;
    }
    
    public async Task<IEnumerable<FootballPlayerDTO>> GetAllFootballPlayers()
    {
        IEnumerable<FootballPlayer> footballPlayers = await _footballPlayerRepository.GetFootballPlayersAsync();
        IEnumerable<FootballPlayerDTO> footballPlayersDto = FootballPlayerDTO.ToDTO(footballPlayers);

        return footballPlayersDto;
    }

    public async Task<FootballPlayerDTO> GetFootballPlayerByName(string playerName)
    {
        FootballPlayer footballPlayer = await _footballPlayerRepository.GetFootballPlayerByPlayerNameAsync(playerName);

        FootballPlayerDTO footballPlayerDto = FootballPlayerDTO.ToDTO(footballPlayer);
        return footballPlayerDto;
    }

    public async Task<FootballPlayerDTO> GetFootballPlayerByCountry(string country)
    {
        FootballPlayer footballPlayer = await _footballPlayerRepository.GetFootballPlayerByCountryAsync(country);

        FootballPlayerDTO footballPlayerDto = FootballPlayerDTO.ToDTO(footballPlayer);
        return footballPlayerDto;
    }

    public async Task<IEnumerable<FootballPlayerDTO>> GetFootballPlayersByGame(string game)
    {
        IEnumerable<FootballPlayer> footballPlayers = await _footballPlayerRepository.GetFootballPlayersByGameAsync(game);
        IEnumerable<FootballPlayerDTO> footballPlayersDto = FootballPlayerDTO.ToDTO(footballPlayers);

        return footballPlayersDto;
    }

    public async Task<IEnumerable<FootballPlayerDTO>> GetFootballPlayersByFilter(FootballPlayerFilterDTO filter)
    {
        IEnumerable<FootballPlayer> footballPlayers = await _footballPlayerRepository.GetFootballPlayerByFilterAsync(
            filter?.PlayerName,
            filter?.Country);
        return FootballPlayerDTO.ToDTO(footballPlayers);
    }


    public async Task<FootballPlayerDTO> AddFootballPlayer(CreateFootballPlayerDTO createdFootballPlayerDTO,
        List<string> errorMessages)
    {

        Guid id = Guid.NewGuid();

        FootballPlayerDTO footballPlayerDto = new FootballPlayerDTO(
            id,
            createdFootballPlayerDTO.PlayerName,
            createdFootballPlayerDTO.Country,
            createdFootballPlayerDTO.FIFA96Rating,
            createdFootballPlayerDTO.FIFA97Rating,
            createdFootballPlayerDTO.FIFA98Rating,
            createdFootballPlayerDTO.FIFA99Rating,
            createdFootballPlayerDTO.FIFA2000Rating,
            createdFootballPlayerDTO.FIFA2001Rating,
            createdFootballPlayerDTO.FIFA2002Rating,
            createdFootballPlayerDTO.FIFA2003Rating,
            createdFootballPlayerDTO.FIFA2004Rating,
            createdFootballPlayerDTO.FIFA2005Rating,
            createdFootballPlayerDTO.FIFA06Rating,
            createdFootballPlayerDTO.FIFA07Rating,
            createdFootballPlayerDTO.FIFA08Rating,
            createdFootballPlayerDTO.FIFA09Rating,
            createdFootballPlayerDTO.FIFA10Rating,
            createdFootballPlayerDTO.FIFA11Rating,
            createdFootballPlayerDTO.FIFA12Rating,
            createdFootballPlayerDTO.FIFA13Rating,
            createdFootballPlayerDTO.FIFA14Rating,
            createdFootballPlayerDTO.FIFA15Rating,
            createdFootballPlayerDTO.FIFA16Rating,
            createdFootballPlayerDTO.FIFA17Rating,
            createdFootballPlayerDTO.FIFA18Rating,
            createdFootballPlayerDTO.FIFA19Rating,
            createdFootballPlayerDTO.FIFA20Rating,
            createdFootballPlayerDTO.FIFA21Rating,
            createdFootballPlayerDTO.FIFA22Rating,
            createdFootballPlayerDTO.FIFA23Rating,
            createdFootballPlayerDTO.EAFC24Rating,
            createdFootballPlayerDTO.EAFC25Rating,
            createdFootballPlayerDTO.EAFC26Rating);


        FootballPlayer footballPlayer = FootballPlayerDTO.ToDomain(footballPlayerDto);

        FootballPlayer footballPlayerSaved = await _footballPlayerRepository.Add(footballPlayer);

        FootballPlayerDTO fpDto = FootballPlayerDTO.ToDTO(footballPlayerSaved);
        return fpDto;
    }

    public async Task<FootballPlayerDTO> UpdateFootballPlayer(Guid playerId, UpdateFootballPlayerDTO updateFootballPlayerDTO,
        List<string> errorMessages)
    {
        bool bExists = await _footballPlayerRepository.FootballPlayerExists(playerId);

        if (!bExists)
        {
            errorMessages.Add("A football player with the entered ID does not exist");
            return null;
        }
        

        FootballPlayerDTO footballPlayerDto = new FootballPlayerDTO(
            playerId,
            updateFootballPlayerDTO.PlayerName,
            updateFootballPlayerDTO.Country,
            updateFootballPlayerDTO.FIFA96Rating,
            updateFootballPlayerDTO.FIFA97Rating,
            updateFootballPlayerDTO.FIFA98Rating,
            updateFootballPlayerDTO.FIFA99Rating,
            updateFootballPlayerDTO.FIFA2000Rating,
            updateFootballPlayerDTO.FIFA2001Rating,
            updateFootballPlayerDTO.FIFA2002Rating,
            updateFootballPlayerDTO.FIFA2003Rating,
            updateFootballPlayerDTO.FIFA2004Rating,
            updateFootballPlayerDTO.FIFA2005Rating,
            updateFootballPlayerDTO.FIFA06Rating,
            updateFootballPlayerDTO.FIFA07Rating,
            updateFootballPlayerDTO.FIFA08Rating,
            updateFootballPlayerDTO.FIFA09Rating,
            updateFootballPlayerDTO.FIFA10Rating,
            updateFootballPlayerDTO.FIFA11Rating,
            updateFootballPlayerDTO.FIFA12Rating,
            updateFootballPlayerDTO.FIFA13Rating,
            updateFootballPlayerDTO.FIFA14Rating,
            updateFootballPlayerDTO.FIFA15Rating,
            updateFootballPlayerDTO.FIFA16Rating,
            updateFootballPlayerDTO.FIFA17Rating,
            updateFootballPlayerDTO.FIFA18Rating,
            updateFootballPlayerDTO.FIFA19Rating,
            updateFootballPlayerDTO.FIFA20Rating,
            updateFootballPlayerDTO.FIFA21Rating,
            updateFootballPlayerDTO.FIFA22Rating,
            updateFootballPlayerDTO.FIFA23Rating,
            updateFootballPlayerDTO.EAFC24Rating,
            updateFootballPlayerDTO.EAFC25Rating,
            updateFootballPlayerDTO.EAFC26Rating);

        FootballPlayer footballPlayer = FootballPlayerDTO.ToDomain(footballPlayerDto);

        FootballPlayer updatedFootballPlayer = await _footballPlayerRepository.Update(footballPlayer, errorMessages);

        FootballPlayerDTO footballPlayerDTO = FootballPlayerDTO.ToDTO(updatedFootballPlayer);
        return footballPlayerDTO;
    }
}