namespace Application.DTO.Basketball;


using Domain.Model.Basketball;
using Domain.Model.Basketball.BasketballPlayer;

public class UpdateBasketballPlayerDTO
{

    public string PlayerName{ get; set; }

    public string Country{ get; set; }

    public BasketballPlayerRating? NBALive95Rating { get; set; }
    public BasketballPlayerRating? NBALive96Rating { get; set; }
    public BasketballPlayerRating? NBALive97Rating { get; set; }
    public BasketballPlayerRating? NBALive98Rating { get; set; }
    public BasketballPlayerRating? NBALive99Rating { get; set; }
    public BasketballPlayerRating? NBA2KRating { get; set; }
    public BasketballPlayerRating? NBA2K1Rating { get; set; }
    public BasketballPlayerRating? NBA2K2Rating { get; set; }
    public BasketballPlayerRating? NBA2K3Rating { get; set; }
    public BasketballPlayerRating? NBA2K4Rating { get; set; }
    public BasketballPlayerRating? NBA2K5Rating { get; set; }
    public BasketballPlayerRating? NBA2K6Rating { get; set; }
    public BasketballPlayerRating? NBA2K7Rating { get; set; }
    public BasketballPlayerRating? NBA2K8Rating { get; set; }
    public BasketballPlayerRating? NBA2K9Rating { get; set; }
    public BasketballPlayerRating? NBA2K10Rating { get; set; }
    public BasketballPlayerRating? NBA2K11Rating { get; set; }
    public BasketballPlayerRating? NBA2K12Rating { get; set; }
    public BasketballPlayerRating? NBA2K13Rating { get; set; }
    public BasketballPlayerRating? NBA2K14Rating { get; set; }
    public BasketballPlayerRating? NBA2K15Rating { get; set; }
    public BasketballPlayerRating? NBA2K16Rating { get; set; }
    public BasketballPlayerRating? NBA2K17Rating { get; set; }
    public BasketballPlayerRating? NBA2K18Rating { get; set; }
    public BasketballPlayerRating? NBA2K19Rating { get; set; }
    public BasketballPlayerRating? NBA2K20Rating { get; set; }
    public BasketballPlayerRating? NBA2K21Rating { get; set; }
    public BasketballPlayerRating? NBA2K22Rating { get; set; }
    public BasketballPlayerRating? NBA2K23Rating { get; set; }
    public BasketballPlayerRating? NBA2K24Rating { get; set; }
    public BasketballPlayerRating? NBA2K25Rating { get; set; }
    public BasketballPlayerRating? NBA2K26Rating { get; set; }

    public UpdateBasketballPlayerDTO()
    {
    }

    public UpdateBasketballPlayerDTO(
        string playerName,
        string country,
        BasketballPlayerRating? ratingNBALive95,
        BasketballPlayerRating? ratingNBALive96,
        BasketballPlayerRating? ratingNBALive97,
        BasketballPlayerRating? ratingNBALive98,
        BasketballPlayerRating? ratingNBALive99,
        BasketballPlayerRating? ratingNBA2K,
        BasketballPlayerRating? ratingNBA2K1,
        BasketballPlayerRating? ratingNBA2K2,
        BasketballPlayerRating? ratingNBA2K3,
        BasketballPlayerRating? ratingNBA2K4,
        BasketballPlayerRating? ratingNBA2K5,
        BasketballPlayerRating? ratingNBA2K6,
        BasketballPlayerRating? ratingNBA2K7,
        BasketballPlayerRating? ratingNBA2K8,
        BasketballPlayerRating? ratingNBA2K9,
        BasketballPlayerRating? ratingNBA2K10,
        BasketballPlayerRating? ratingNBA2K11,
        BasketballPlayerRating? ratingNBA2K12,
        BasketballPlayerRating? ratingNBA2K13,
        BasketballPlayerRating? ratingNBA2K14,
        BasketballPlayerRating? ratingNBA2K15,
        BasketballPlayerRating? ratingNBA2K16,
        BasketballPlayerRating? ratingNBA2K17,
        BasketballPlayerRating? ratingNBA2K18,
        BasketballPlayerRating? ratingNBA2K19,
        BasketballPlayerRating? ratingNBA2K20,
        BasketballPlayerRating? ratingNBA2K21,
        BasketballPlayerRating? ratingNBA2K22,
        BasketballPlayerRating? ratingNBA2K23,
        BasketballPlayerRating? ratingNBA2K24,
        BasketballPlayerRating? ratingNBA2K25,
        BasketballPlayerRating? ratingNBA2K26
    )
    {
        PlayerName = playerName;
        Country = country;
        NBALive95Rating = ratingNBALive95;
        NBALive96Rating = ratingNBALive96;
        NBALive97Rating = ratingNBALive97;
        NBALive98Rating = ratingNBALive98;
        NBALive99Rating = ratingNBALive99;
        NBA2KRating = ratingNBA2K;
        NBA2K1Rating = ratingNBA2K1;
        NBA2K2Rating = ratingNBA2K2;
        NBA2K3Rating = ratingNBA2K3;
        NBA2K4Rating = ratingNBA2K4;
        NBA2K5Rating = ratingNBA2K5;
        NBA2K6Rating = ratingNBA2K6;
        NBA2K7Rating = ratingNBA2K7;
        NBA2K8Rating = ratingNBA2K8;
        NBA2K9Rating = ratingNBA2K9;
        NBA2K10Rating = ratingNBA2K10;
        NBA2K11Rating = ratingNBA2K11;
        NBA2K12Rating = ratingNBA2K12;
        NBA2K13Rating = ratingNBA2K13;
        NBA2K14Rating = ratingNBA2K14;
        NBA2K15Rating = ratingNBA2K15;
        NBA2K16Rating = ratingNBA2K16;
        NBA2K17Rating = ratingNBA2K17;
        NBA2K18Rating = ratingNBA2K18;
        NBA2K19Rating = ratingNBA2K19;
        NBA2K20Rating = ratingNBA2K20;
        NBA2K21Rating = ratingNBA2K21;
        NBA2K22Rating = ratingNBA2K22;
        NBA2K23Rating = ratingNBA2K23;
        NBA2K24Rating = ratingNBA2K24;
        NBA2K25Rating = ratingNBA2K25;
        NBA2K26Rating = ratingNBA2K26;
    }
}