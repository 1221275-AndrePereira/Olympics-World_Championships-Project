using Domain.Model;
using Domain.Model.Baseball;
using Domain.Model.Baseball.BaseballPlayer;

namespace DataModel.Model;

public class BaseballPlayerDataModel
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

    public BaseballPlayerDataModel()
    {
    }

    public BaseballPlayerDataModel(BaseballPlayer baseballPlayer)
    {
        PlayerId = baseballPlayer.PlayerId;
        PlayerName = baseballPlayer.GetPlayerName();
        Country = baseballPlayer.GetCountry();
        MLBTriplePlay99Rating = baseballPlayer.GetMLBTriplePlay99Rating();
        MLBTriplePlay2000Rating = baseballPlayer.GetMLBTriplePlay2000Rating();
        MLBTriplePlay2001Rating = baseballPlayer.GetMLBTriplePlay2001Rating();
        MLBTriplePlayBaseballRating = baseballPlayer.GetMLBTriplePlayBaseballRating();
        MLBTriplePlay2002Rating = baseballPlayer.GetMLBTriplePlay2002Rating();
        MLB2004Rating = baseballPlayer.GetMLB2004Rating();
        MLBESPNRating = baseballPlayer.GetMLBESPNRating();
        MLB2K5Rating = baseballPlayer.GetMLB2K5Rating();
        MLB2K6Rating = baseballPlayer.GetMLB2K6Rating();
        MLB2K7Rating = baseballPlayer.GetMLB2K7Rating();
        MLB2K8Rating = baseballPlayer.GetMLB2K8Rating();
        MLB2K9Rating = baseballPlayer.GetMLB2K9Rating();
        MLB2K10Rating = baseballPlayer.GetMLB2K10Rating();
        MLB2K11Rating = baseballPlayer.GetMLB2K11Rating();
        MLB2K12Rating = baseballPlayer.GetMLB2K12Rating();
        MLBTheShow13Rating = baseballPlayer.GetMLBTheShow13Rating();
        MLBTheShow14Rating = baseballPlayer.GetMLBTheShow14Rating();
        MLBTheShow15Rating = baseballPlayer.GetMLBTheShow15Rating();
        MLBTheShow16Rating = baseballPlayer.GetMLBTheShow16Rating();
        MLBTheShow17Rating = baseballPlayer.GetMLBTheShow17Rating();
        MLBTheShow18Rating = baseballPlayer.GetMLBTheShow18Rating();
        MLBTheShow19Rating = baseballPlayer.GetMLBTheShow19Rating();
        MLBTheShow20Rating = baseballPlayer.GetMLBTheShow20Rating();
        MLBTheShow21Rating = baseballPlayer.GetMLBTheShow21Rating();
        MLBTheShow22Rating = baseballPlayer.GetMLBTheShow22Rating();
        MLBTheShow23Rating = baseballPlayer.GetMLBTheShow23Rating();
        MLBTheShow24Rating = baseballPlayer.GetMLBTheShow24Rating();
        MLBTheShow25Rating = baseballPlayer.GetMLBTheShow25Rating();
    }
}