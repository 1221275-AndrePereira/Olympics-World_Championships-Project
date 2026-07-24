namespace Domain.Factory.Interface;

using Domain.Model;
using Domain.Model.AmericanFootball;
using Domain.Model.AmericanFootball.AmericanFootballPlayer;

public interface IAmericanFootballPlayerFactory
{
    AmericanFootballPlayer newAmericanFootballPlayer(
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
        AmericanFootballPlayerRating? ratingMaddenNFL26);



}