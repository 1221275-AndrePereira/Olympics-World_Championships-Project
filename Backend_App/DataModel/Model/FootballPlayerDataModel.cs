using Domain.Model;
using Domain.Model.Football;
using Domain.Model.Football.FootballPlayer;

namespace DataModel.Model;

public class FootballPlayerDataModel
{
    public Guid PlayerId{ get; set; }

    public string PlayerName{ get; set; }

    public string Country{ get; set; }

    public FootballPlayerRating? FIFA96Rating { get; set; }

    public FootballPlayerRating? FIFA97Rating { get; set; }
    public FootballPlayerRating? FIFA98Rating { get; set; }
    public FootballPlayerRating? FIFA99Rating { get; set; }
    public FootballPlayerRating? FIFA2000Rating { get; set; }
    public FootballPlayerRating? FIFA2001Rating { get; set; }
    public FootballPlayerRating? FIFA2002Rating { get; set; }
    public FootballPlayerRating? FIFA2003Rating { get; set; }
    public FootballPlayerRating? FIFA2004Rating { get; set; }
    public FootballPlayerRating? FIFA2005Rating { get; set; }
    public FootballPlayerRating? FIFA06Rating { get; set; }
    public FootballPlayerRating? FIFA07Rating { get; set; }
    public FootballPlayerRating? FIFA08Rating { get; set; }
    public FootballPlayerRating? FIFA09Rating { get; set; }
    public FootballPlayerRating? FIFA10Rating { get; set; }
    public FootballPlayerRating? FIFA11Rating { get; set; }
    public FootballPlayerRating? FIFA12Rating { get; set; }
    public FootballPlayerRating? FIFA13Rating { get; set; }
    public FootballPlayerRating? FIFA14Rating { get; set; }
    public FootballPlayerRating? FIFA15Rating { get; set; }
    public FootballPlayerRating? FIFA16Rating { get; set; }
    public FootballPlayerRating? FIFA17Rating { get; set; }
    public FootballPlayerRating? FIFA18Rating { get; set; }
    public FootballPlayerRating? FIFA19Rating { get; set; }
    public FootballPlayerRating? FIFA20Rating { get; set; }
    public FootballPlayerRating? FIFA21Rating { get; set; }
    public FootballPlayerRating? FIFA22Rating { get; set; }
    public FootballPlayerRating? FIFA23Rating { get; set; }
    public FootballPlayerRating? EAFC24Rating { get; set; }
    public FootballPlayerRating? EAFC25Rating { get; set; }
    public FootballPlayerRating? EAFC26Rating { get; set; }

    public FootballPlayerDataModel()
    {
    }

    public FootballPlayerDataModel(FootballPlayer footballPlayer)
    {
        PlayerId = footballPlayer.PlayerId;
        PlayerName = footballPlayer.GetPlayerName();
        Country = footballPlayer.GetCountry();
        FIFA96Rating = footballPlayer.GetFIFA96Rating();
        FIFA97Rating = footballPlayer.GetFIFA97Rating();
        FIFA98Rating = footballPlayer.GetFIFA98Rating();
        FIFA99Rating = footballPlayer.GetFIFA99Rating();
        FIFA2000Rating = footballPlayer.GetFIFA2000Rating();
        FIFA2001Rating = footballPlayer.GetFIFA2001Rating();
        FIFA2002Rating = footballPlayer.GetFIFA2002Rating();
        FIFA2003Rating = footballPlayer.GetFIFA2003Rating();
        FIFA2004Rating = footballPlayer.GetFIFA2004Rating();
        FIFA2005Rating = footballPlayer.GetFIFA2005Rating();
        FIFA06Rating = footballPlayer.GetFIFA06Rating();
        FIFA07Rating = footballPlayer.GetFIFA07Rating();
        FIFA08Rating = footballPlayer.GetFIFA08Rating();
        FIFA09Rating = footballPlayer.GetFIFA09Rating();
        FIFA10Rating = footballPlayer.GetFIFA10Rating();
        FIFA11Rating = footballPlayer.GetFIFA11Rating();
        FIFA12Rating = footballPlayer.GetFIFA12Rating();
        FIFA13Rating = footballPlayer.GetFIFA13Rating();
        FIFA14Rating = footballPlayer.GetFIFA14Rating();
        FIFA15Rating = footballPlayer.GetFIFA15Rating();
        FIFA16Rating = footballPlayer.GetFIFA16Rating();
        FIFA17Rating = footballPlayer.GetFIFA17Rating();
        FIFA18Rating = footballPlayer.GetFIFA18Rating();
        FIFA19Rating = footballPlayer.GetFIFA19Rating();
        FIFA20Rating = footballPlayer.GetFIFA20Rating();
        FIFA21Rating = footballPlayer.GetFIFA21Rating();
        FIFA22Rating = footballPlayer.GetFIFA22Rating();
        FIFA23Rating = footballPlayer.GetFIFA23Rating();
        EAFC24Rating = footballPlayer.GetEAFC24Rating();
        EAFC25Rating = footballPlayer.GetEAFC25Rating();
        EAFC26Rating = footballPlayer.GetEAFC26Rating();
    }
}