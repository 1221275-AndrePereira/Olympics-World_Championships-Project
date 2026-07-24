using Domain.Model;
using Domain.Model.IceHockey;
using Domain.Model.IceHockey.IceHockeyPlayer;

namespace DataModel.Model;

public class IceHockeyPlayerDataModel
{
    public Guid PlayerId{ get; set; }

    public string PlayerName{ get; set; }

    public string Country{ get; set; }

    public IceHockeyPlayerRating? NHL93Rating { get; set; }
    public IceHockeyPlayerRating? NHL94Rating { get; set; }
    public IceHockeyPlayerRating? NHL95Rating { get; set; }
    public IceHockeyPlayerRating? NHL96Rating { get; set; }
    public IceHockeyPlayerRating? NHL97Rating { get; set; }
    public IceHockeyPlayerRating? NHL98Rating { get; set; }
    public IceHockeyPlayerRating? NHL99Rating { get; set; }
    public IceHockeyPlayerRating? NHL2000Rating { get; set; }
    public IceHockeyPlayerRating? NHL2001Rating { get; set; }
    public IceHockeyPlayerRating? NHL2002Rating { get; set; }
    public IceHockeyPlayerRating? NHL2003Rating { get; set; }
    public IceHockeyPlayerRating? NHL2004Rating { get; set; }
    public IceHockeyPlayerRating? NHL2005Rating { get; set; }
    public IceHockeyPlayerRating? NHL06Rating { get; set; }
    public IceHockeyPlayerRating? NHL07Rating { get; set; }
    public IceHockeyPlayerRating? NHL08Rating { get; set; }
    public IceHockeyPlayerRating? NHL09Rating { get; set; }
    public IceHockeyPlayerRating? NHL10Rating { get; set; }
    public IceHockeyPlayerRating? NHL11Rating { get; set; }
    public IceHockeyPlayerRating? NHL12Rating { get; set; }
    public IceHockeyPlayerRating? NHL13Rating { get; set; }
    public IceHockeyPlayerRating? NHL14Rating { get; set; }
    public IceHockeyPlayerRating? NHL15Rating { get; set; }
    public IceHockeyPlayerRating? NHL16Rating { get; set; }
    public IceHockeyPlayerRating? NHL17Rating { get; set; }
    public IceHockeyPlayerRating? NHL18Rating { get; set; }
    public IceHockeyPlayerRating? NHL19Rating { get; set; }
    public IceHockeyPlayerRating? NHL20Rating { get; set; }
    public IceHockeyPlayerRating? NHL21Rating { get; set; }
    public IceHockeyPlayerRating? NHL22Rating { get; set; }
    public IceHockeyPlayerRating? NHL23Rating { get; set; }
    public IceHockeyPlayerRating? NHL24Rating { get; set; }
    public IceHockeyPlayerRating? NHL25Rating { get; set; }
    public IceHockeyPlayerRating? NHL26Rating { get; set; }

    public IceHockeyPlayerDataModel()
    {
    }

    public IceHockeyPlayerDataModel(IceHockeyPlayer iceHockeyPlayer)
    {
        PlayerId = iceHockeyPlayer.PlayerId;
        PlayerName = iceHockeyPlayer.GetPlayerName();
        Country = iceHockeyPlayer.GetCountry();
        NHL93Rating = iceHockeyPlayer.GetNHL93Rating();
        NHL94Rating = iceHockeyPlayer.GetNHL94Rating();
        NHL95Rating = iceHockeyPlayer.GetNHL95Rating();
        NHL96Rating = iceHockeyPlayer.GetNHL96Rating();
        NHL97Rating = iceHockeyPlayer.GetNHL97Rating();
        NHL98Rating = iceHockeyPlayer.GetNHL98Rating();
        NHL99Rating = iceHockeyPlayer.GetNHL99Rating();
        NHL2000Rating = iceHockeyPlayer.GetNHL2000Rating();
        NHL2001Rating = iceHockeyPlayer.GetNHL2001Rating();
        NHL2002Rating = iceHockeyPlayer.GetNHL2002Rating();
        NHL2003Rating = iceHockeyPlayer.GetNHL2003Rating();
        NHL2004Rating = iceHockeyPlayer.GetNHL2004Rating();
        NHL2005Rating = iceHockeyPlayer.GetNHL2005Rating();
        NHL06Rating = iceHockeyPlayer.GetNHL06Rating();
        NHL07Rating = iceHockeyPlayer.GetNHL07Rating();
        NHL08Rating = iceHockeyPlayer.GetNHL08Rating();
        NHL09Rating = iceHockeyPlayer.GetNHL09Rating();
        NHL10Rating = iceHockeyPlayer.GetNHL10Rating();
        NHL11Rating = iceHockeyPlayer.GetNHL11Rating();
        NHL12Rating = iceHockeyPlayer.GetNHL12Rating();
        NHL13Rating = iceHockeyPlayer.GetNHL13Rating();
        NHL14Rating = iceHockeyPlayer.GetNHL14Rating();
        NHL15Rating = iceHockeyPlayer.GetNHL15Rating();
        NHL16Rating = iceHockeyPlayer.GetNHL16Rating();
        NHL17Rating = iceHockeyPlayer.GetNHL17Rating();
        NHL18Rating = iceHockeyPlayer.GetNHL18Rating();
        NHL19Rating = iceHockeyPlayer.GetNHL19Rating();
        NHL20Rating = iceHockeyPlayer.GetNHL20Rating();
        NHL21Rating = iceHockeyPlayer.GetNHL21Rating();
        NHL22Rating = iceHockeyPlayer.GetNHL22Rating();
        NHL23Rating = iceHockeyPlayer.GetNHL23Rating();
        NHL24Rating = iceHockeyPlayer.GetNHL24Rating();
        NHL25Rating = iceHockeyPlayer.GetNHL25Rating();
        NHL26Rating = iceHockeyPlayer.GetNHL26Rating();
    }
}