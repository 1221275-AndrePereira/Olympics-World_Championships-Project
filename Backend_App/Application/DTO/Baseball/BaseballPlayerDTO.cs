namespace Application.DTO.Baseball;


using Domain.Model.Baseball;
using Domain.Model.Baseball.BaseballPlayer;

public class BaseballPlayerDTO
{

    public Guid PlayerId{ get; set; }

    public string PlayerName{ get; set; }

    public string Country{ get; set; }

    public BaseballPlayerRating? MLBTriplePlay99Rating { get; set; }
    public BaseballPlayerRating? MLBTriplePlay2000Rating { get; set; }
    public BaseballPlayerRating? MLBTriplePlay2001Rating { get; set; }
    public BaseballPlayerRating? MLBTriplePlayBaseballRating { get; set; }
    public BaseballPlayerRating? MLBTriplePlay2002Rating { get; set; }
    public BaseballPlayerRating? MLB2004Rating { get; set; }
    public BaseballPlayerRating? MLBESPNRating { get; set; }
    public BaseballPlayerRating? MLB2K5Rating { get; set; }
    public BaseballPlayerRating? MLB2K6Rating { get; set; }
    public BaseballPlayerRating? MLB2K7Rating { get; set; }
    public BaseballPlayerRating? MLB2K8Rating { get; set; }
    public BaseballPlayerRating? MLB2K9Rating { get; set; }
    public BaseballPlayerRating? MLB2K10Rating { get; set; }
    public BaseballPlayerRating? MLB2K11Rating { get; set; }
    public BaseballPlayerRating? MLB2K12Rating { get; set; }
    public BaseballPlayerRating? MLBTheShow13Rating { get; set; }
    public BaseballPlayerRating? MLBTheShow14Rating { get; set; }
    public BaseballPlayerRating? MLBTheShow15Rating { get; set; }
    public BaseballPlayerRating? MLBTheShow16Rating { get; set; }
    public BaseballPlayerRating? MLBTheShow17Rating { get; set; }
    public BaseballPlayerRating? MLBTheShow18Rating { get; set; }
    public BaseballPlayerRating? MLBTheShow19Rating { get; set; }
    public BaseballPlayerRating? MLBTheShow20Rating { get; set; }
    public BaseballPlayerRating? MLBTheShow21Rating { get; set; }
    public BaseballPlayerRating? MLBTheShow22Rating { get; set; }
    public BaseballPlayerRating? MLBTheShow23Rating { get; set; }
    public BaseballPlayerRating? MLBTheShow24Rating { get; set; }
    public BaseballPlayerRating? MLBTheShow25Rating { get; set; }

    public BaseballPlayerDTO()
    {
    }

    public BaseballPlayerDTO(
        Guid id,
        string playerName,
        string country,
        BaseballPlayerRating? ratingMLBTriplePlay99,
        BaseballPlayerRating? ratingMLBTriplePlay2000,
        BaseballPlayerRating? ratingMLBTriplePlay2001,
        BaseballPlayerRating? ratingMLBTriplePlayBaseball,
        BaseballPlayerRating? ratingMLBTriplePlay2002,
        BaseballPlayerRating? ratingMLB2004,
        BaseballPlayerRating? ratingMLBESPN,
        BaseballPlayerRating? ratingMLB2K5,
        BaseballPlayerRating? ratingMLB2K6,
        BaseballPlayerRating? ratingMLB2K7,
        BaseballPlayerRating? ratingMLB2K8,
        BaseballPlayerRating? ratingMLB2K9,
        BaseballPlayerRating? ratingMLB2K10,
        BaseballPlayerRating? ratingMLB2K11,
        BaseballPlayerRating? ratingMLB2K12,
        BaseballPlayerRating? ratingMLBTheShow13,
        BaseballPlayerRating? ratingMLBTheShow14,
        BaseballPlayerRating? ratingMLBTheShow15,
        BaseballPlayerRating? ratingMLBTheShow16,
        BaseballPlayerRating? ratingMLBTheShow17,
        BaseballPlayerRating? ratingMLBTheShow18,
        BaseballPlayerRating? ratingMLBTheShow19,
        BaseballPlayerRating? ratingMLBTheShow20,
        BaseballPlayerRating? ratingMLBTheShow21,
        BaseballPlayerRating? ratingMLBTheShow22,
        BaseballPlayerRating? ratingMLBTheShow23,
        BaseballPlayerRating? ratingMLBTheShow24,
        BaseballPlayerRating? ratingMLBTheShow25
    )
    {
        PlayerId = id;
        PlayerName = playerName;
        Country = country;
        MLBTriplePlay99Rating = ratingMLBTriplePlay99;
        MLBTriplePlay2000Rating = ratingMLBTriplePlay2000;
        MLBTriplePlay2001Rating = ratingMLBTriplePlay2001;
        MLBTriplePlayBaseballRating = ratingMLBTriplePlayBaseball;
        MLBTriplePlay2002Rating = ratingMLBTriplePlay2002;
        MLB2004Rating = ratingMLB2004;
        MLBESPNRating = ratingMLBESPN;
        MLB2K5Rating = ratingMLB2K5;
        MLB2K6Rating = ratingMLB2K6;
        MLB2K7Rating = ratingMLB2K7;
        MLB2K8Rating = ratingMLB2K8;
        MLB2K9Rating = ratingMLB2K9;
        MLB2K10Rating = ratingMLB2K10;
        MLB2K11Rating = ratingMLB2K11;
        MLB2K12Rating = ratingMLB2K12;
        MLBTheShow13Rating = ratingMLBTheShow13;
        MLBTheShow14Rating = ratingMLBTheShow14;
        MLBTheShow15Rating = ratingMLBTheShow15;
        MLBTheShow16Rating = ratingMLBTheShow16;
        MLBTheShow17Rating = ratingMLBTheShow17;
        MLBTheShow18Rating = ratingMLBTheShow18;
        MLBTheShow19Rating = ratingMLBTheShow19;
        MLBTheShow20Rating = ratingMLBTheShow20;
        MLBTheShow21Rating = ratingMLBTheShow21;
        MLBTheShow22Rating = ratingMLBTheShow22;
        MLBTheShow23Rating = ratingMLBTheShow23;
        MLBTheShow24Rating = ratingMLBTheShow24;
        MLBTheShow25Rating = ratingMLBTheShow25;
    }

    static public BaseballPlayerDTO ToDTO(BaseballPlayer baseballPlayer)
    {

        BaseballPlayerDTO baseballPlayerDTO = new BaseballPlayerDTO(baseballPlayer.PlayerId,
            baseballPlayer.PlayerName,
            baseballPlayer.Country,
            baseballPlayer.MLBTriplePlay99Rating,
            baseballPlayer.MLBTriplePlay2000Rating,
            baseballPlayer.MLBTriplePlay2001Rating,
            baseballPlayer.MLBTriplePlayBaseballRating,
            baseballPlayer.MLBTriplePlay2002Rating,
            baseballPlayer.MLB2004Rating,
            baseballPlayer.MLBESPNRating,
            baseballPlayer.MLB2K5Rating,
            baseballPlayer.MLB2K6Rating,
            baseballPlayer.MLB2K7Rating,
            baseballPlayer.MLB2K8Rating,
            baseballPlayer.MLB2K9Rating,
            baseballPlayer.MLB2K10Rating,
            baseballPlayer.MLB2K11Rating,
            baseballPlayer.MLB2K12Rating,
            baseballPlayer.MLBTheShow13Rating,
            baseballPlayer.MLBTheShow14Rating,
            baseballPlayer.MLBTheShow15Rating,
            baseballPlayer.MLBTheShow16Rating,
            baseballPlayer.MLBTheShow17Rating,
            baseballPlayer.MLBTheShow18Rating,
            baseballPlayer.MLBTheShow19Rating,
            baseballPlayer.MLBTheShow20Rating,
            baseballPlayer.MLBTheShow21Rating,
            baseballPlayer.MLBTheShow22Rating,
            baseballPlayer.MLBTheShow23Rating,
            baseballPlayer.MLBTheShow24Rating,
            baseballPlayer.MLBTheShow25Rating);
        return baseballPlayerDTO;
    }

    static public IEnumerable<BaseballPlayerDTO> ToDTO(IEnumerable<BaseballPlayer> baseballPlayers)
    {
        List<BaseballPlayerDTO> baseballPlayerDTOs = new List<BaseballPlayerDTO>();

        foreach (BaseballPlayer baseballPlayer in baseballPlayers)
        {
            BaseballPlayerDTO baseballPlayerDTO = BaseballPlayerDTO.ToDTO(baseballPlayer);
            baseballPlayerDTOs.Add(baseballPlayerDTO);
        }

        return baseballPlayerDTOs;
    }

    static public BaseballPlayer ToDomain(BaseballPlayerDTO baseballPlayerDTO)
    {
        BaseballPlayer baseballPlayer = new BaseballPlayer(baseballPlayerDTO.PlayerId,
            baseballPlayerDTO.PlayerName,
            baseballPlayerDTO.Country,
            baseballPlayerDTO.MLBTriplePlay99Rating,
            baseballPlayerDTO.MLBTriplePlay2000Rating,
            baseballPlayerDTO.MLBTriplePlay2001Rating,
            baseballPlayerDTO.MLBTriplePlayBaseballRating,
            baseballPlayerDTO.MLBTriplePlay2002Rating,
            baseballPlayerDTO.MLB2004Rating,
            baseballPlayerDTO.MLBESPNRating,
            baseballPlayerDTO.MLB2K5Rating,
            baseballPlayerDTO.MLB2K6Rating,
            baseballPlayerDTO.MLB2K7Rating,
            baseballPlayerDTO.MLB2K8Rating,
            baseballPlayerDTO.MLB2K9Rating,
            baseballPlayerDTO.MLB2K10Rating,
            baseballPlayerDTO.MLB2K11Rating,
            baseballPlayerDTO.MLB2K12Rating,
            baseballPlayerDTO.MLBTheShow13Rating,
            baseballPlayerDTO.MLBTheShow14Rating,
            baseballPlayerDTO.MLBTheShow15Rating,
            baseballPlayerDTO.MLBTheShow16Rating,
            baseballPlayerDTO.MLBTheShow17Rating,
            baseballPlayerDTO.MLBTheShow18Rating,
            baseballPlayerDTO.MLBTheShow19Rating,
            baseballPlayerDTO.MLBTheShow20Rating,
            baseballPlayerDTO.MLBTheShow21Rating,
            baseballPlayerDTO.MLBTheShow22Rating,
            baseballPlayerDTO.MLBTheShow23Rating,
            baseballPlayerDTO.MLBTheShow24Rating,
            baseballPlayerDTO.MLBTheShow25Rating);
        return baseballPlayer;
    }
}