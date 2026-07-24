using Domain.Model;
using Domain.Model.AmericanFootball;
using Domain.Model.AmericanFootball.AmericanFootballPlayer;
using Microsoft.Identity.Client;

namespace DataModel.Model;

public class AmericanFootballPlayerDataModel
{
    public Guid PlayerId{ get; set; }

    public string PlayerName{ get; set; }

    public AmericanFootballPlayerRating? NFLGameday98Rating { get; set; }
    public AmericanFootballPlayerRating? NFLGameday99Rating { get; set; }
    public AmericanFootballPlayerRating? MaddenNFL2000Rating { get; set; }
    public AmericanFootballPlayerRating? MaddenNFL2001Rating { get; set; }
    public AmericanFootballPlayerRating? MaddenNFL2002Rating { get; set; }
    public AmericanFootballPlayerRating? MaddenNFL2003Rating { get; set; }
    public AmericanFootballPlayerRating? MaddenNFL2004Rating { get; set; }
    public AmericanFootballPlayerRating? MaddenNFL2005Rating { get; set; }
    public AmericanFootballPlayerRating? MaddenNFL06Rating { get; set; }
    public AmericanFootballPlayerRating? MaddenNFL07Rating { get; set; }
    public AmericanFootballPlayerRating? MaddenNFL08Rating { get; set; }
    public AmericanFootballPlayerRating? MaddenNFL09Rating { get; set; }
    public AmericanFootballPlayerRating? MaddenNFL10Rating { get; set; }
    public AmericanFootballPlayerRating? MaddenNFL11Rating { get; set; }
    public AmericanFootballPlayerRating? MaddenNFL12Rating { get; set; }
    public AmericanFootballPlayerRating? MaddenNFL13Rating { get; set; }
    public AmericanFootballPlayerRating? MaddenNFL14Rating { get; set; }
    public AmericanFootballPlayerRating? MaddenNFL15Rating { get; set; }
    public AmericanFootballPlayerRating? MaddenNFL16Rating { get; set; }
    public AmericanFootballPlayerRating? MaddenNFL17Rating { get; set; }
    public AmericanFootballPlayerRating? MaddenNFL18Rating { get; set; }
    public AmericanFootballPlayerRating? MaddenNFL19Rating { get; set; }
    public AmericanFootballPlayerRating? MaddenNFL20Rating { get; set; }
    public AmericanFootballPlayerRating? MaddenNFL21Rating { get; set; }
    public AmericanFootballPlayerRating? MaddenNFL22Rating { get; set; }
    public AmericanFootballPlayerRating? MaddenNFL23Rating { get; set; }
    public AmericanFootballPlayerRating? MaddenNFL24Rating { get; set; }
    public AmericanFootballPlayerRating? MaddenNFL25Rating { get; set; }
    public AmericanFootballPlayerRating? MaddenNFL26Rating { get; set; }

    public AmericanFootballPlayerDataModel()
    {
    }

    public AmericanFootballPlayerDataModel(AmericanFootballPlayer americanFootballPlayer)
    {
        PlayerId = americanFootballPlayer.PlayerId;
        PlayerName = americanFootballPlayer.GetPlayerName();
        NFLGameday98Rating = americanFootballPlayer.GetNFLGameday98Rating();
        NFLGameday99Rating = americanFootballPlayer.GetNFLGameday99Rating();
        MaddenNFL2000Rating = americanFootballPlayer.GetMaddenNFL2000Rating();
        MaddenNFL2001Rating = americanFootballPlayer.GetMaddenNFL2001Rating();
        MaddenNFL2002Rating = americanFootballPlayer.GetMaddenNFL2002Rating();
        MaddenNFL2003Rating = americanFootballPlayer.GetMaddenNFL2003Rating();
        MaddenNFL2004Rating = americanFootballPlayer.GetMaddenNFL2004Rating();
        MaddenNFL2005Rating = americanFootballPlayer.GetMaddenNFL2005Rating();
        MaddenNFL06Rating = americanFootballPlayer.GetMaddenNFL06Rating();
        MaddenNFL07Rating = americanFootballPlayer.GetMaddenNFL07Rating();
        MaddenNFL08Rating = americanFootballPlayer.GetMaddenNFL08Rating();
        MaddenNFL09Rating = americanFootballPlayer.GetMaddenNFL09Rating();
        MaddenNFL10Rating = americanFootballPlayer.GetMaddenNFL10Rating();
        MaddenNFL11Rating = americanFootballPlayer.GetMaddenNFL11Rating();
        MaddenNFL12Rating = americanFootballPlayer.GetMaddenNFL12Rating();
        MaddenNFL13Rating = americanFootballPlayer.GetMaddenNFL13Rating();
        MaddenNFL14Rating = americanFootballPlayer.GetMaddenNFL14Rating();
        MaddenNFL15Rating = americanFootballPlayer.GetMaddenNFL15Rating();
        MaddenNFL16Rating = americanFootballPlayer.GetMaddenNFL16Rating();
        MaddenNFL17Rating = americanFootballPlayer.GetMaddenNFL17Rating();
        MaddenNFL18Rating = americanFootballPlayer.GetMaddenNFL18Rating();
        MaddenNFL19Rating = americanFootballPlayer.GetMaddenNFL19Rating();
        MaddenNFL20Rating = americanFootballPlayer.GetMaddenNFL20Rating();
        MaddenNFL21Rating = americanFootballPlayer.GetMaddenNFL21Rating();
        MaddenNFL22Rating = americanFootballPlayer.GetMaddenNFL22Rating();
        MaddenNFL23Rating = americanFootballPlayer.GetMaddenNFL23Rating();
        MaddenNFL24Rating = americanFootballPlayer.GetMaddenNFL24Rating();
        MaddenNFL25Rating = americanFootballPlayer.GetMaddenNFL25Rating();
        MaddenNFL26Rating = americanFootballPlayer.GetMaddenNFL26Rating();
    }
}