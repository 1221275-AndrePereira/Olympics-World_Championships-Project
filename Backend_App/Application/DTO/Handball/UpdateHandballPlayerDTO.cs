namespace Application.DTO.Handball;


using Domain.Model.Handball;
using Domain.Model.Handball.HandballPlayer;

public class UpdateHandballPlayerDTO
{

    public string PlayerName{ get; set; }

    public string Country{ get; set; }

    public HandballPlayerRating? Handball17Rating{ get; set; }
    public HandballPlayerRating? Handball21Rating{ get; set; }

    public UpdateHandballPlayerDTO()
    {
    }

    public UpdateHandballPlayerDTO(
        string playerName,
        string country,
        HandballPlayerRating? handball17Rating,
        HandballPlayerRating? handball21Rating
    )
    {
        PlayerName = playerName;
        Country = country;
        Handball17Rating = handball17Rating;
        Handball21Rating = handball21Rating;
    }
}