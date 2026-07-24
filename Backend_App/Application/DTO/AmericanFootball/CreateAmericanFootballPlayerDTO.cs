namespace Application.DTO.AmericanFootball;


using Domain.Model.AmericanFootball;
using Domain.Model.AmericanFootball.AmericanFootballPlayer;

public class CreateAmericanFootballPlayerDTO
{

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

    public CreateAmericanFootballPlayerDTO()
    {
    }

    public CreateAmericanFootballPlayerDTO(
        string playerName,
        AmericanFootballPlayerRating? ratingNFLGameday98,
        AmericanFootballPlayerRating? ratingNFLGameday99,
        AmericanFootballPlayerRating? ratingMaddenNFL2000,
        AmericanFootballPlayerRating? ratingMaddenNFL2001,
        AmericanFootballPlayerRating? ratingMaddenNFL2002,
        AmericanFootballPlayerRating? ratingMaddenNFL2003,
        AmericanFootballPlayerRating? ratingMaddenNFL2004,
        AmericanFootballPlayerRating? ratingMaddenNFL2005,
        AmericanFootballPlayerRating? ratingMaddenNFL06,
        AmericanFootballPlayerRating? ratingMaddenNFL07,
        AmericanFootballPlayerRating? ratingMaddenNFL08,
        AmericanFootballPlayerRating? ratingMaddenNFL09,
        AmericanFootballPlayerRating? ratingMaddenNFL10,
        AmericanFootballPlayerRating? ratingMaddenNFL11,
        AmericanFootballPlayerRating? ratingMaddenNFL12,
        AmericanFootballPlayerRating? ratingMaddenNFL13,
        AmericanFootballPlayerRating? ratingMaddenNFL14,
        AmericanFootballPlayerRating? ratingMaddenNFL15,
        AmericanFootballPlayerRating? ratingMaddenNFL16,
        AmericanFootballPlayerRating? ratingMaddenNFL17,
        AmericanFootballPlayerRating? ratingMaddenNFL18,
        AmericanFootballPlayerRating? ratingMaddenNFL19,
        AmericanFootballPlayerRating? ratingMaddenNFL20,
        AmericanFootballPlayerRating? ratingMaddenNFL21,
        AmericanFootballPlayerRating? ratingMaddenNFL22,
        AmericanFootballPlayerRating? ratingMaddenNFL23,
        AmericanFootballPlayerRating? ratingMaddenNFL24,
        AmericanFootballPlayerRating? ratingMaddenNFL25,
        AmericanFootballPlayerRating? ratingMaddenNFL26
    )
    {
        PlayerName = playerName;
        NFLGameday98Rating = ratingNFLGameday98;
        NFLGameday99Rating = ratingNFLGameday99;
        MaddenNFL2000Rating = ratingMaddenNFL2000;
        MaddenNFL2001Rating = ratingMaddenNFL2001;
        MaddenNFL2002Rating = ratingMaddenNFL2002;
        MaddenNFL2003Rating = ratingMaddenNFL2003;
        MaddenNFL2004Rating = ratingMaddenNFL2004;
        MaddenNFL2005Rating = ratingMaddenNFL2005;
        MaddenNFL06Rating = ratingMaddenNFL06;
        MaddenNFL07Rating = ratingMaddenNFL07;
        MaddenNFL08Rating = ratingMaddenNFL08;
        MaddenNFL09Rating = ratingMaddenNFL09;
        MaddenNFL10Rating = ratingMaddenNFL10;
        MaddenNFL11Rating = ratingMaddenNFL11;
        MaddenNFL12Rating = ratingMaddenNFL12;
        MaddenNFL13Rating = ratingMaddenNFL13;
        MaddenNFL14Rating = ratingMaddenNFL14;
        MaddenNFL15Rating = ratingMaddenNFL15;
        MaddenNFL16Rating = ratingMaddenNFL16;
        MaddenNFL17Rating = ratingMaddenNFL17;
        MaddenNFL18Rating = ratingMaddenNFL18;
        MaddenNFL19Rating = ratingMaddenNFL19;
        MaddenNFL20Rating = ratingMaddenNFL20;
        MaddenNFL21Rating = ratingMaddenNFL21;
        MaddenNFL22Rating = ratingMaddenNFL22;
        MaddenNFL23Rating = ratingMaddenNFL23;
        MaddenNFL24Rating = ratingMaddenNFL24;
        MaddenNFL25Rating = ratingMaddenNFL25;
        MaddenNFL26Rating = ratingMaddenNFL26;
    }
}