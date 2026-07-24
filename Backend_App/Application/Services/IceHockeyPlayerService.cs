using Application.DTO;
using Application.DTO.IceHockey;
using Domain.IRepository;
using Domain.Model.IceHockey.IceHockeyPlayer;
using Domain.Model.IceHockey;

namespace Application.Services;

public class IceHockeyPlayerService
{
    private readonly IIceHockeyPlayerRepository _iceHockeyPlayerRepository;

    public IceHockeyPlayerService(IIceHockeyPlayerRepository iceHockeyPlayerRepository)
    {
        _iceHockeyPlayerRepository = iceHockeyPlayerRepository;
    }
    
    public async Task<IEnumerable<IceHockeyPlayerDTO>> GetAllIceHockeyPlayers()
    {
        IEnumerable<IceHockeyPlayer> iceHockeyPlayers = await _iceHockeyPlayerRepository.GetIceHockeyPlayersAsync();
        IEnumerable<IceHockeyPlayerDTO> iceHockeyPlayersDto = IceHockeyPlayerDTO.ToDTO(iceHockeyPlayers);

        return iceHockeyPlayersDto;
    }

    public async Task<IceHockeyPlayerDTO> GetIceHockeyPlayerByName(string playerName)
    {
        IceHockeyPlayer iceHockeyPlayer = await _iceHockeyPlayerRepository.GetIceHockeyPlayerByPlayerNameAsync(playerName);

        IceHockeyPlayerDTO iceHockeyPlayerDto = IceHockeyPlayerDTO.ToDTO(iceHockeyPlayer);
        return iceHockeyPlayerDto;
    }

    public async Task<IceHockeyPlayerDTO> GetIceHockeyPlayerByCountry(string country)
    {
        IceHockeyPlayer iceHockeyPlayer = await _iceHockeyPlayerRepository.GetIceHockeyPlayerByCountryAsync(country);

        IceHockeyPlayerDTO iceHockeyPlayerDto = IceHockeyPlayerDTO.ToDTO(iceHockeyPlayer);
        return iceHockeyPlayerDto;
    }

    public async Task<IEnumerable<IceHockeyPlayerDTO>> GetIceHockeyPlayersByGame(string game)
    {
        IEnumerable<IceHockeyPlayer> iceHockeyPlayers = await _iceHockeyPlayerRepository.GetIceHockeyPlayersByGameAsync(game);
        IEnumerable<IceHockeyPlayerDTO> iceHockeyPlayersDto = IceHockeyPlayerDTO.ToDTO(iceHockeyPlayers);

        return iceHockeyPlayersDto;
    }

    public async Task<IEnumerable<IceHockeyPlayerDTO>> GetIceHockeyPlayersByFilter(IceHockeyPlayerFilterDTO filter)
    {
        IEnumerable<IceHockeyPlayer> iceHockeyPlayers = await _iceHockeyPlayerRepository.GetIceHockeyPlayerByFilterAsync(
            filter?.PlayerName,
            filter?.Country);
        return IceHockeyPlayerDTO.ToDTO(iceHockeyPlayers);
    }


    public async Task<IceHockeyPlayerDTO> AddIceHockeyPlayer(CreateIceHockeyPlayerDTO createdIceHockeyPlayerDTO,
        List<string> errorMessages)
    {

        Guid id = Guid.NewGuid();

        IceHockeyPlayerDTO iceHockeyPlayerDto = new IceHockeyPlayerDTO(
            id,
            createdIceHockeyPlayerDTO.PlayerName,
            createdIceHockeyPlayerDTO.Country,
            createdIceHockeyPlayerDTO.NHL93Rating,
            createdIceHockeyPlayerDTO.NHL94Rating,
            createdIceHockeyPlayerDTO.NHL95Rating,
            createdIceHockeyPlayerDTO.NHL96Rating,
            createdIceHockeyPlayerDTO.NHL97Rating,
            createdIceHockeyPlayerDTO.NHL98Rating,
            createdIceHockeyPlayerDTO.NHL99Rating,
            createdIceHockeyPlayerDTO.NHL2000Rating,
            createdIceHockeyPlayerDTO.NHL2001Rating,
            createdIceHockeyPlayerDTO.NHL2002Rating,
            createdIceHockeyPlayerDTO.NHL2003Rating,
            createdIceHockeyPlayerDTO.NHL2004Rating,
            createdIceHockeyPlayerDTO.NHL2005Rating,
            createdIceHockeyPlayerDTO.NHL06Rating,
            createdIceHockeyPlayerDTO.NHL07Rating,
            createdIceHockeyPlayerDTO.NHL08Rating,
            createdIceHockeyPlayerDTO.NHL09Rating,
            createdIceHockeyPlayerDTO.NHL10Rating,
            createdIceHockeyPlayerDTO.NHL11Rating,
            createdIceHockeyPlayerDTO.NHL12Rating,
            createdIceHockeyPlayerDTO.NHL13Rating,
            createdIceHockeyPlayerDTO.NHL14Rating,
            createdIceHockeyPlayerDTO.NHL15Rating,
            createdIceHockeyPlayerDTO.NHL16Rating,
            createdIceHockeyPlayerDTO.NHL17Rating,
            createdIceHockeyPlayerDTO.NHL18Rating,
            createdIceHockeyPlayerDTO.NHL19Rating,
            createdIceHockeyPlayerDTO.NHL20Rating,
            createdIceHockeyPlayerDTO.NHL21Rating,
            createdIceHockeyPlayerDTO.NHL22Rating,
            createdIceHockeyPlayerDTO.NHL23Rating,
            createdIceHockeyPlayerDTO.NHL24Rating,
            createdIceHockeyPlayerDTO.NHL25Rating,
            createdIceHockeyPlayerDTO.NHL26Rating);


        IceHockeyPlayer iceHockeyPlayer = IceHockeyPlayerDTO.ToDomain(iceHockeyPlayerDto);

        IceHockeyPlayer iceHockeyPlayerSaved = await _iceHockeyPlayerRepository.Add(iceHockeyPlayer);

        IceHockeyPlayerDTO ihpDto = IceHockeyPlayerDTO.ToDTO(iceHockeyPlayerSaved);
        return ihpDto;
    }

    public async Task<IceHockeyPlayerDTO> UpdateIceHockeyPlayer(Guid playerId, UpdateIceHockeyPlayerDTO updateIceHockeyPlayerDTO,
        List<string> errorMessages)
    {
        bool bExists = await _iceHockeyPlayerRepository.IceHockeyPlayerExists(playerId);

        if (!bExists)
        {
            errorMessages.Add("An ice hockey player with the entered ID does not exist");
            return null;
        }
        

        IceHockeyPlayerDTO iceHockeyPlayerDto = new IceHockeyPlayerDTO(
            playerId,
            updateIceHockeyPlayerDTO.PlayerName,
            updateIceHockeyPlayerDTO.Country,
            updateIceHockeyPlayerDTO.NHL93Rating,
            updateIceHockeyPlayerDTO.NHL94Rating,
            updateIceHockeyPlayerDTO.NHL95Rating,
            updateIceHockeyPlayerDTO.NHL96Rating,
            updateIceHockeyPlayerDTO.NHL97Rating,
            updateIceHockeyPlayerDTO.NHL98Rating,
            updateIceHockeyPlayerDTO.NHL99Rating,
            updateIceHockeyPlayerDTO.NHL2000Rating,
            updateIceHockeyPlayerDTO.NHL2001Rating,
            updateIceHockeyPlayerDTO.NHL2002Rating,
            updateIceHockeyPlayerDTO.NHL2003Rating,
            updateIceHockeyPlayerDTO.NHL2004Rating,
            updateIceHockeyPlayerDTO.NHL2005Rating,
            updateIceHockeyPlayerDTO.NHL06Rating,
            updateIceHockeyPlayerDTO.NHL07Rating,
            updateIceHockeyPlayerDTO.NHL08Rating,
            updateIceHockeyPlayerDTO.NHL09Rating,
            updateIceHockeyPlayerDTO.NHL10Rating,
            updateIceHockeyPlayerDTO.NHL11Rating,
            updateIceHockeyPlayerDTO.NHL12Rating,
            updateIceHockeyPlayerDTO.NHL13Rating,
            updateIceHockeyPlayerDTO.NHL14Rating,
            updateIceHockeyPlayerDTO.NHL15Rating,
            updateIceHockeyPlayerDTO.NHL16Rating,
            updateIceHockeyPlayerDTO.NHL17Rating,
            updateIceHockeyPlayerDTO.NHL18Rating,
            updateIceHockeyPlayerDTO.NHL19Rating,
            updateIceHockeyPlayerDTO.NHL20Rating,
            updateIceHockeyPlayerDTO.NHL21Rating,
            updateIceHockeyPlayerDTO.NHL22Rating,
            updateIceHockeyPlayerDTO.NHL23Rating,
            updateIceHockeyPlayerDTO.NHL24Rating,
            updateIceHockeyPlayerDTO.NHL25Rating,
            updateIceHockeyPlayerDTO.NHL26Rating);

        IceHockeyPlayer iceHockeyPlayer = IceHockeyPlayerDTO.ToDomain(iceHockeyPlayerDto);

        IceHockeyPlayer updatedIceHockeyPlayer = await _iceHockeyPlayerRepository.Update(iceHockeyPlayer, errorMessages);

        IceHockeyPlayerDTO iceHockeyPlayerDTO = IceHockeyPlayerDTO.ToDTO(updatedIceHockeyPlayer);
        return iceHockeyPlayerDTO;
    }
}