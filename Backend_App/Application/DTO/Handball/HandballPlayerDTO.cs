namespace Application.DTO.Handball;


using Domain.Model.Handball;
using Domain.Model.Handball.HandballPlayer;

public class HandballPlayerDTO
{

    public Guid PlayerId{ get; set; }

    public string PlayerName{ get; set; }

    public string Country{ get; set; }

    public HandballPlayerRating? Handball17Rating{ get; set; }
    public HandballPlayerRating? Handball21Rating{ get; set; }

    public HandballPlayerDTO()
    {
    }

    public HandballPlayerDTO(
        Guid id,
        string playerName,
        string country,
        HandballPlayerRating? handball17Rating,
        HandballPlayerRating? handball21Rating
    )
    {
        PlayerId = id;
        PlayerName = playerName;
        Country = country;
        Handball17Rating = handball17Rating;
        Handball21Rating = handball21Rating;
    }

    static public HandballPlayerDTO ToDTO(HandballPlayer handballPlayer)
    {

        HandballPlayerDTO handballPlayerDTO = new HandballPlayerDTO(handballPlayer.PlayerId,
            handballPlayer.PlayerName,
            handballPlayer.Country,
            handballPlayer.Handball17Rating,
            handballPlayer.Handball21Rating);
        return handballPlayerDTO;
    }

    static public IEnumerable<HandballPlayerDTO> ToDTO(IEnumerable<HandballPlayer> handballPlayers)
    {
        List<HandballPlayerDTO> handballPlayerDTOs = new List<HandballPlayerDTO>();

        foreach (HandballPlayer handballPlayer in handballPlayers)
        {
            HandballPlayerDTO handballPlayerDTO = HandballPlayerDTO.ToDTO(handballPlayer);
            handballPlayerDTOs.Add(handballPlayerDTO);
        }

        return handballPlayerDTOs;
    }

    static public HandballPlayer ToDomain(HandballPlayerDTO handballPlayerDTO)
    {

        HandballPlayer handballPlayer = new HandballPlayer(handballPlayerDTO.PlayerId,
            handballPlayerDTO.PlayerName,
            handballPlayerDTO.Country,
            handballPlayerDTO.Handball17Rating,
            handballPlayerDTO.Handball21Rating);
        return handballPlayer;
    }
}