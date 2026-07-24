using Application.DTO;
using Application.DTO.Baseball;
using Domain.IRepository;
using Domain.Model.Baseball.BaseballPlayer;
using Domain.Model.Baseball;

namespace Application.Services;

public class BaseballPlayerService
{
    private readonly IBaseballPlayerRepository _baseballPlayerRepository;

    public BaseballPlayerService(IBaseballPlayerRepository baseballPlayerRepository)
    {
        _baseballPlayerRepository = baseballPlayerRepository;
    }
    
    public async Task<IEnumerable<BaseballPlayerDTO>> GetAllBaseballPlayers()
    {
        IEnumerable<BaseballPlayer> baseballPlayers = await _baseballPlayerRepository.GetBaseballPlayersAsync();
        IEnumerable<BaseballPlayerDTO> baseballPlayersDto = BaseballPlayerDTO.ToDTO(baseballPlayers);

        return baseballPlayersDto;
    }

    public async Task<BaseballPlayerDTO> GetBaseballPlayerByName(string playerName)
    {
        BaseballPlayer baseballPlayer = await _baseballPlayerRepository.GetBaseballPlayerByPlayerNameAsync(playerName);

        BaseballPlayerDTO baseballPlayerDto = BaseballPlayerDTO.ToDTO(baseballPlayer);
        return baseballPlayerDto;
    }

    public async Task<BaseballPlayerDTO> GetBaseballPlayerByCountry(string country)
    {
        BaseballPlayer baseballPlayer = await _baseballPlayerRepository.GetBaseballPlayerByCountryAsync(country);

        BaseballPlayerDTO baseballPlayerDto = BaseballPlayerDTO.ToDTO(baseballPlayer);
        return baseballPlayerDto;
    }

    public async Task<IEnumerable<BaseballPlayerDTO>> GetBaseballPlayersByGame(string game)
    {
        IEnumerable<BaseballPlayer> baseballPlayers = await _baseballPlayerRepository.GetBaseballPlayersByGameAsync(game);
        IEnumerable<BaseballPlayerDTO> baseballPlayersDto = BaseballPlayerDTO.ToDTO(baseballPlayers);

        return baseballPlayersDto;
    }

    public async Task<IEnumerable<BaseballPlayerDTO>> GetBaseballPlayersByFilter(BaseballPlayerFilterDTO filter)
    {
        IEnumerable<BaseballPlayer> baseballPlayers = await _baseballPlayerRepository.GetBaseballPlayerByFilterAsync(
            filter?.PlayerName,
            filter?.Country);
        return BaseballPlayerDTO.ToDTO(baseballPlayers);
    }


    public async Task<BaseballPlayerDTO> AddBaseballPlayer(CreateBaseballPlayerDTO createdBaseballPlayerDTO,
        List<string> errorMessages)
    {

        Guid id = Guid.NewGuid();

        BaseballPlayerDTO baseballPlayerDto = new BaseballPlayerDTO(
            id,
            createdBaseballPlayerDTO.PlayerName,
            createdBaseballPlayerDTO.Country,
            createdBaseballPlayerDTO.MLBTriplePlay99Rating,
            createdBaseballPlayerDTO.MLBTriplePlay2000Rating,
            createdBaseballPlayerDTO.MLBTriplePlay2001Rating,
            createdBaseballPlayerDTO.MLBTriplePlayBaseballRating,
            createdBaseballPlayerDTO.MLBTriplePlay2002Rating,
            createdBaseballPlayerDTO.MLB2004Rating,
            createdBaseballPlayerDTO.MLBESPNRating,
            createdBaseballPlayerDTO.MLB2K5Rating,
            createdBaseballPlayerDTO.MLB2K6Rating,
            createdBaseballPlayerDTO.MLB2K7Rating,
            createdBaseballPlayerDTO.MLB2K8Rating,
            createdBaseballPlayerDTO.MLB2K9Rating,
            createdBaseballPlayerDTO.MLB2K10Rating,
            createdBaseballPlayerDTO.MLB2K11Rating,
            createdBaseballPlayerDTO.MLB2K12Rating,
            createdBaseballPlayerDTO.MLBTheShow13Rating,
            createdBaseballPlayerDTO.MLBTheShow14Rating,
            createdBaseballPlayerDTO.MLBTheShow15Rating,
            createdBaseballPlayerDTO.MLBTheShow16Rating,
            createdBaseballPlayerDTO.MLBTheShow17Rating,
            createdBaseballPlayerDTO.MLBTheShow18Rating,
            createdBaseballPlayerDTO.MLBTheShow19Rating,
            createdBaseballPlayerDTO.MLBTheShow20Rating,
            createdBaseballPlayerDTO.MLBTheShow21Rating,
            createdBaseballPlayerDTO.MLBTheShow22Rating,
            createdBaseballPlayerDTO.MLBTheShow23Rating,
            createdBaseballPlayerDTO.MLBTheShow24Rating,
            createdBaseballPlayerDTO.MLBTheShow25Rating);


        BaseballPlayer baseballPlayer = BaseballPlayerDTO.ToDomain(baseballPlayerDto);

        BaseballPlayer baseballPlayerSaved = await _baseballPlayerRepository.Add(baseballPlayer);

        BaseballPlayerDTO bpDto = BaseballPlayerDTO.ToDTO(baseballPlayerSaved);
        return bpDto;
    }

    public async Task<BaseballPlayerDTO> UpdateBaseballPlayer(Guid playerId, UpdateBaseballPlayerDTO updateBaseballPlayerDTO,
        List<string> errorMessages)
    {
        bool bExists = await _baseballPlayerRepository.BaseballPlayerExists(playerId);

        if (!bExists)
        {
            errorMessages.Add("A baseball player with the entered ID does not exist");
            return null;
        }
        

        BaseballPlayerDTO baseballPlayerDto = new BaseballPlayerDTO(
            playerId,
            updateBaseballPlayerDTO.PlayerName,
            updateBaseballPlayerDTO.Country,
            updateBaseballPlayerDTO.MLBTriplePlay99Rating,
            updateBaseballPlayerDTO.MLBTriplePlay2000Rating,
            updateBaseballPlayerDTO.MLBTriplePlay2001Rating,
            updateBaseballPlayerDTO.MLBTriplePlayBaseballRating,
            updateBaseballPlayerDTO.MLBTriplePlay2002Rating,
            updateBaseballPlayerDTO.MLB2004Rating,
            updateBaseballPlayerDTO.MLBESPNRating,
            updateBaseballPlayerDTO.MLB2K5Rating,
            updateBaseballPlayerDTO.MLB2K6Rating,
            updateBaseballPlayerDTO.MLB2K7Rating,
            updateBaseballPlayerDTO.MLB2K8Rating,
            updateBaseballPlayerDTO.MLB2K9Rating,
            updateBaseballPlayerDTO.MLB2K10Rating,
            updateBaseballPlayerDTO.MLB2K11Rating,
            updateBaseballPlayerDTO.MLB2K12Rating,
            updateBaseballPlayerDTO.MLBTheShow13Rating,
            updateBaseballPlayerDTO.MLBTheShow14Rating,
            updateBaseballPlayerDTO.MLBTheShow15Rating,
            updateBaseballPlayerDTO.MLBTheShow16Rating,
            updateBaseballPlayerDTO.MLBTheShow17Rating,
            updateBaseballPlayerDTO.MLBTheShow18Rating,
            updateBaseballPlayerDTO.MLBTheShow19Rating,
            updateBaseballPlayerDTO.MLBTheShow20Rating,
            updateBaseballPlayerDTO.MLBTheShow21Rating,
            updateBaseballPlayerDTO.MLBTheShow22Rating,
            updateBaseballPlayerDTO.MLBTheShow23Rating,
            updateBaseballPlayerDTO.MLBTheShow24Rating,
            updateBaseballPlayerDTO.MLBTheShow25Rating);

        BaseballPlayer baseballPlayer = BaseballPlayerDTO.ToDomain(baseballPlayerDto);

        BaseballPlayer updatedBaseballPlayer = await _baseballPlayerRepository.Update(baseballPlayer, errorMessages);

        BaseballPlayerDTO baseballPlayerDTO = BaseballPlayerDTO.ToDTO(updatedBaseballPlayer);
        return baseballPlayerDTO;
    }
}