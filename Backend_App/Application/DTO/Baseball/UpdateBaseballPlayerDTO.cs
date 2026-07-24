namespace Application.DTO.Baseball;


using Domain.Model.Baseball;
using Domain.Model.Baseball.BaseballPlayer;

public class UpdateBaseballPlayerDTO
{

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
    
    public UpdateBaseballPlayerDTO()
    {
    }

    public UpdateBaseballPlayerDTO(
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
}