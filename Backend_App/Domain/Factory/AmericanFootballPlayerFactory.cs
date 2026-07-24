using Domain.Factory.Interface;

namespace Domain.Factory.AmericanFootballPlayerFactory;

using Domain.Model.AmericanFootball;
using Domain.Model.AmericanFootball.AmericanFootballPlayer;
using Domain.Model.Interface;

public class AmericanFootballPlayerFactory : IAmericanFootballPlayerFactory
{
    public AmericanFootballPlayer newAmericanFootballPlayer(
        Guid id,
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
        AmericanFootballPlayerRating? ratingMaddenNFL26)
    {
        return new AmericanFootballPlayer(
        id,
        playerName,
        ratingNFLGameday98,
        ratingNFLGameday99,
        ratingMaddenNFL2000,
        ratingMaddenNFL2001,
        ratingMaddenNFL2002,
        ratingMaddenNFL2003,
        ratingMaddenNFL2004,
        ratingMaddenNFL2005,
        ratingMaddenNFL06,
        ratingMaddenNFL07,
        ratingMaddenNFL08,
        ratingMaddenNFL09,
        ratingMaddenNFL10,
        ratingMaddenNFL11,
        ratingMaddenNFL12,
        ratingMaddenNFL13,
        ratingMaddenNFL14,
        ratingMaddenNFL15,
        ratingMaddenNFL16,
        ratingMaddenNFL17,
        ratingMaddenNFL18,
        ratingMaddenNFL19,
        ratingMaddenNFL20,
        ratingMaddenNFL21,
        ratingMaddenNFL22,
        ratingMaddenNFL23,
        ratingMaddenNFL24,
        ratingMaddenNFL25,
        ratingMaddenNFL26);
    }
}