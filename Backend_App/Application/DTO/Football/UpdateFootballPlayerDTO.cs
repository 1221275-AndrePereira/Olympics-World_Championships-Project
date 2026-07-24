namespace Application.DTO.Football;


using Domain.Model.Football;
using Domain.Model.Football.FootballPlayer;

public class UpdateFootballPlayerDTO
{

    public string PlayerName{ get; set; }

    public string Country{ get; set; }

    public FootballPlayerRating? FIFA96Rating{ get; set; }
    public FootballPlayerRating? FIFA97Rating{ get; set; }
    public FootballPlayerRating? FIFA98Rating{ get; set; }
    public FootballPlayerRating? FIFA99Rating{ get; set; }
    public FootballPlayerRating? FIFA2000Rating{ get; set; }
    public FootballPlayerRating? FIFA2001Rating{ get; set; }
    public FootballPlayerRating? FIFA2002Rating{ get; set; }
    public FootballPlayerRating? FIFA2003Rating{ get; set; }
    public FootballPlayerRating? FIFA2004Rating{ get; set; }
    public FootballPlayerRating? FIFA2005Rating{ get; set; }
    public FootballPlayerRating? FIFA06Rating{ get; set; }
    public FootballPlayerRating? FIFA07Rating{ get; set; }
    public FootballPlayerRating? FIFA08Rating{ get; set; }
    public FootballPlayerRating? FIFA09Rating{ get; set; }
    public FootballPlayerRating? FIFA10Rating{ get; set; }
    public FootballPlayerRating? FIFA11Rating{ get; set; }
    public FootballPlayerRating? FIFA12Rating{ get; set; }
    public FootballPlayerRating? FIFA13Rating{ get; set; }
    public FootballPlayerRating? FIFA14Rating{ get; set; }
    public FootballPlayerRating? FIFA15Rating{ get; set; }
    public FootballPlayerRating? FIFA16Rating{ get; set; }
    public FootballPlayerRating? FIFA17Rating{ get; set; }
    public FootballPlayerRating? FIFA18Rating{ get; set; }
    public FootballPlayerRating? FIFA19Rating{ get; set; }
    public FootballPlayerRating? FIFA20Rating{ get; set; }
    public FootballPlayerRating? FIFA21Rating{ get; set; }
    public FootballPlayerRating? FIFA22Rating{ get; set; }
    public FootballPlayerRating? FIFA23Rating{ get; set; }
    public FootballPlayerRating? EAFC24Rating{ get; set; }
    public FootballPlayerRating? EAFC25Rating{ get; set; }
    public FootballPlayerRating? EAFC26Rating{ get; set; }
    public UpdateFootballPlayerDTO()
    {
    }

    public UpdateFootballPlayerDTO(
        string playerName,
        string country,
        FootballPlayerRating? fifa96Rating,
        FootballPlayerRating? fifa97Rating,
        FootballPlayerRating? fifa98Rating,
        FootballPlayerRating? fifa99Rating,
        FootballPlayerRating? fifa2000Rating,
        FootballPlayerRating? fifa2001Rating,
        FootballPlayerRating? fifa2002Rating,
        FootballPlayerRating? fifa2003Rating,
        FootballPlayerRating? fifa2004Rating,
        FootballPlayerRating? fifa2005Rating,
        FootballPlayerRating? fifa06Rating,
        FootballPlayerRating? fifa07Rating,
        FootballPlayerRating? fifa08Rating,
        FootballPlayerRating? fifa09Rating,
        FootballPlayerRating? fifa10Rating,
        FootballPlayerRating? fifa11Rating,
        FootballPlayerRating? fifa12Rating,
        FootballPlayerRating? fifa13Rating,
        FootballPlayerRating? fifa14Rating,
        FootballPlayerRating? fifa15Rating,
        FootballPlayerRating? fifa16Rating,
        FootballPlayerRating? fifa17Rating,
        FootballPlayerRating? fifa18Rating,
        FootballPlayerRating? fifa19Rating,
        FootballPlayerRating? fifa20Rating,
        FootballPlayerRating? fifa21Rating,
        FootballPlayerRating? fifa22Rating,
        FootballPlayerRating? fifa23Rating,
        FootballPlayerRating? eafc24Rating,
        FootballPlayerRating? eafc25Rating,
        FootballPlayerRating? eafc26Rating
    )
    {
        PlayerName = playerName;
        Country = country;
        FIFA96Rating = fifa96Rating;
        FIFA97Rating = fifa97Rating;
        FIFA98Rating = fifa98Rating;
        FIFA99Rating = fifa99Rating;
        FIFA2000Rating = fifa2000Rating;
        FIFA2001Rating = fifa2001Rating;
        FIFA2002Rating = fifa2002Rating;
        FIFA2003Rating = fifa2003Rating;
        FIFA2004Rating = fifa2004Rating;
        FIFA2005Rating = fifa2005Rating;
        FIFA06Rating = fifa06Rating;
        FIFA07Rating = fifa07Rating;
        FIFA08Rating = fifa08Rating;
        FIFA09Rating = fifa09Rating;
        FIFA10Rating = fifa10Rating;
        FIFA11Rating = fifa11Rating;
        FIFA12Rating = fifa12Rating;
        FIFA13Rating = fifa13Rating;
        FIFA14Rating = fifa14Rating;
        FIFA15Rating = fifa15Rating;
        FIFA16Rating = fifa16Rating;
        FIFA17Rating = fifa17Rating;
        FIFA18Rating = fifa18Rating;
        FIFA19Rating = fifa19Rating;
        FIFA20Rating = fifa20Rating;
        FIFA21Rating = fifa21Rating;
        FIFA22Rating = fifa22Rating;
        FIFA23Rating = fifa23Rating;
        EAFC24Rating = eafc24Rating;
        EAFC25Rating = eafc25Rating;
        EAFC26Rating = eafc26Rating;
    }
}