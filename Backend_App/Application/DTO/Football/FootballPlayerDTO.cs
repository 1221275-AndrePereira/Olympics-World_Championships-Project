namespace Application.DTO.Football;


using Domain.Model.Football;
using Domain.Model.Football.FootballPlayer;

public class FootballPlayerDTO
{

    public Guid PlayerId{ get; set; }

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
    public FootballPlayerDTO()
    {
    }

    public FootballPlayerDTO(
        Guid id,
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
        PlayerId = id;
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

    static public FootballPlayerDTO ToDTO(FootballPlayer footballPlayer)
    {

        FootballPlayerDTO footballPlayerDTO = new FootballPlayerDTO(footballPlayer.PlayerId,
            footballPlayer.PlayerName,
            footballPlayer.Country,
            footballPlayer.FIFA96Rating,
            footballPlayer.FIFA97Rating,
            footballPlayer.FIFA98Rating,
            footballPlayer.FIFA99Rating,
            footballPlayer.FIFA2000Rating,
            footballPlayer.FIFA2001Rating,
            footballPlayer.FIFA2002Rating,
            footballPlayer.FIFA2003Rating,
            footballPlayer.FIFA2004Rating,
            footballPlayer.FIFA2005Rating,
            footballPlayer.FIFA06Rating,
            footballPlayer.FIFA07Rating,
            footballPlayer.FIFA08Rating,
            footballPlayer.FIFA09Rating,
            footballPlayer.FIFA10Rating,
            footballPlayer.FIFA11Rating,
            footballPlayer.FIFA12Rating,
            footballPlayer.FIFA13Rating,
            footballPlayer.FIFA14Rating,
            footballPlayer.FIFA15Rating,
            footballPlayer.FIFA16Rating,
            footballPlayer.FIFA17Rating,
            footballPlayer.FIFA18Rating,
            footballPlayer.FIFA19Rating,
            footballPlayer.FIFA20Rating,
            footballPlayer.FIFA21Rating,
            footballPlayer.FIFA22Rating,
            footballPlayer.FIFA23Rating,
            footballPlayer.EAFC24Rating,
            footballPlayer.EAFC25Rating,
            footballPlayer.EAFC26Rating);
        return footballPlayerDTO;
    }

    static public IEnumerable<FootballPlayerDTO> ToDTO(IEnumerable<FootballPlayer> footballPlayers)
    {
        List<FootballPlayerDTO> footballPlayerDTOs = new List<FootballPlayerDTO>();

        foreach (FootballPlayer footballPlayer in footballPlayers)
        {
            FootballPlayerDTO footballPlayerDTO = FootballPlayerDTO.ToDTO(footballPlayer);
            footballPlayerDTOs.Add(footballPlayerDTO);
        }

        return footballPlayerDTOs;
    }

    static public FootballPlayer ToDomain(FootballPlayerDTO footballPlayerDTO)
    {

        FootballPlayer footballPlayer = new FootballPlayer(footballPlayerDTO.PlayerId,
            footballPlayerDTO.PlayerName,
            footballPlayerDTO.Country,
            footballPlayerDTO.FIFA96Rating,
            footballPlayerDTO.FIFA97Rating,
            footballPlayerDTO.FIFA98Rating,
            footballPlayerDTO.FIFA99Rating,
            footballPlayerDTO.FIFA2000Rating,
            footballPlayerDTO.FIFA2001Rating,
            footballPlayerDTO.FIFA2002Rating,
            footballPlayerDTO.FIFA2003Rating,
            footballPlayerDTO.FIFA2004Rating,
            footballPlayerDTO.FIFA2005Rating,
            footballPlayerDTO.FIFA06Rating,
            footballPlayerDTO.FIFA07Rating,
            footballPlayerDTO.FIFA08Rating,
            footballPlayerDTO.FIFA09Rating,
            footballPlayerDTO.FIFA10Rating,
            footballPlayerDTO.FIFA11Rating,
            footballPlayerDTO.FIFA12Rating,
            footballPlayerDTO.FIFA13Rating,
            footballPlayerDTO.FIFA14Rating,
            footballPlayerDTO.FIFA15Rating,
            footballPlayerDTO.FIFA16Rating,
            footballPlayerDTO.FIFA17Rating,
            footballPlayerDTO.FIFA18Rating,
            footballPlayerDTO.FIFA19Rating,
            footballPlayerDTO.FIFA20Rating,
            footballPlayerDTO.FIFA21Rating,
            footballPlayerDTO.FIFA22Rating,
            footballPlayerDTO.FIFA23Rating,
            footballPlayerDTO.EAFC24Rating,
            footballPlayerDTO.EAFC25Rating,
            footballPlayerDTO.EAFC26Rating);
        return footballPlayer;
    }
}