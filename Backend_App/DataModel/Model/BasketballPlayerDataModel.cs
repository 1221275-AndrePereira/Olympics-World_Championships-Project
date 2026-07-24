using Domain.Model;
using Domain.Model.Basketball;
using Domain.Model.Basketball.BasketballPlayer;

namespace DataModel.Model;

public class BasketballPlayerDataModel
{
    public Guid PlayerId{ get; set; }

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

    public BasketballPlayerDataModel()
    {
    }

    public BasketballPlayerDataModel(BasketballPlayer basketballPlayer)
    {
        PlayerId = basketballPlayer.PlayerId;
        PlayerName = basketballPlayer.GetPlayerName();
        Country = basketballPlayer.GetCountry();
        NBALive95Rating = basketballPlayer.GetNBALive95Rating();
        NBALive96Rating = basketballPlayer.GetNBALive96Rating();
        NBALive97Rating = basketballPlayer.GetNBALive97Rating();
        NBALive98Rating = basketballPlayer.GetNBALive98Rating();
        NBALive99Rating = basketballPlayer.GetNBALive99Rating();
        NBA2KRating = basketballPlayer.GetNBA2KRating();
        NBA2K1Rating = basketballPlayer.GetNBA2K1Rating();
        NBA2K2Rating = basketballPlayer.GetNBA2K2Rating();
        NBA2K3Rating = basketballPlayer.GetNBA2K3Rating();
        NBA2K4Rating = basketballPlayer.GetNBA2K4Rating();
        NBA2K5Rating = basketballPlayer.GetNBA2K5Rating();
        NBA2K6Rating = basketballPlayer.GetNBA2K6Rating();
        NBA2K7Rating = basketballPlayer.GetNBA2K7Rating();
        NBA2K8Rating = basketballPlayer.GetNBA2K8Rating();
        NBA2K9Rating = basketballPlayer.GetNBA2K9Rating();
        NBA2K10Rating = basketballPlayer.GetNBA2K10Rating();
        NBA2K11Rating = basketballPlayer.GetNBA2K11Rating();
        NBA2K12Rating = basketballPlayer.GetNBA2K12Rating();
        NBA2K13Rating = basketballPlayer.GetNBA2K13Rating();
        NBA2K14Rating = basketballPlayer.GetNBA2K14Rating();
        NBA2K15Rating = basketballPlayer.GetNBA2K15Rating();
        NBA2K16Rating = basketballPlayer.GetNBA2K16Rating();
        NBA2K17Rating = basketballPlayer.GetNBA2K17Rating();
        NBA2K18Rating = basketballPlayer.GetNBA2K18Rating();
        NBA2K19Rating = basketballPlayer.GetNBA2K19Rating();
        NBA2K20Rating = basketballPlayer.GetNBA2K20Rating();
        NBA2K21Rating = basketballPlayer.GetNBA2K21Rating();
        NBA2K22Rating = basketballPlayer.GetNBA2K22Rating();
        NBA2K23Rating = basketballPlayer.GetNBA2K23Rating();
        NBA2K24Rating = basketballPlayer.GetNBA2K24Rating();
        NBA2K25Rating = basketballPlayer.GetNBA2K25Rating();
        NBA2K26Rating = basketballPlayer.GetNBA2K26Rating();
    }
}