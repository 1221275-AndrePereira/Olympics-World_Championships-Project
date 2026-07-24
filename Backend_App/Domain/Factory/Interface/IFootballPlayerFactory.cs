namespace Domain.Factory.Interface;

using Domain.Model;
using Domain.Model.Football;
using Domain.Model.Football.FootballPlayer;

public interface IFootballPlayerFactory
{
    FootballPlayer newFootballPlayer(
        Guid id,
        string playerName,
        string country,
        FootballPlayerRating? ratingFIFA96,
        FootballPlayerRating? ratingFIFA97,
        FootballPlayerRating? ratingFIFA98,
        FootballPlayerRating? ratingFIFA99,
        FootballPlayerRating? ratingFIFA2000,
        FootballPlayerRating? ratingFIFA2001,
        FootballPlayerRating? ratingFIFA2002,
        FootballPlayerRating? ratingFIFA2003,
        FootballPlayerRating? ratingFIFA2004,
        FootballPlayerRating? ratingFIFA2005,
        FootballPlayerRating? ratingFIFA06,
        FootballPlayerRating? ratingFIFA07,
        FootballPlayerRating? ratingFIFA08,
        FootballPlayerRating? ratingFIFA09,
        FootballPlayerRating? ratingFIFA10,
        FootballPlayerRating? ratingFIFA11,
        FootballPlayerRating? ratingFIFA12,
        FootballPlayerRating? ratingFIFA13,
        FootballPlayerRating? ratingFIFA14,
        FootballPlayerRating? ratingFIFA15,
        FootballPlayerRating? ratingFIFA16,
        FootballPlayerRating? ratingFIFA17,
        FootballPlayerRating? ratingFIFA18,
        FootballPlayerRating? ratingFIFA19,
        FootballPlayerRating? ratingFIFA20,
        FootballPlayerRating? ratingFIFA21,
        FootballPlayerRating? ratingFIFA22,
        FootballPlayerRating? ratingFIFA23,
        FootballPlayerRating? ratingEAFC24,
        FootballPlayerRating? ratingEAFC25,
        FootballPlayerRating? ratingEAFC26);
}