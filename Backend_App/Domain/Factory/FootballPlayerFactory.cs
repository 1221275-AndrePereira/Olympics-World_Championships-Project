using Domain.Factory.Interface;

namespace Domain.Factory.FootballPlayerFactory;

using Domain.Model.Football;
using Domain.Model.Football.FootballPlayer;
using Domain.Model.Interface;

public class FootballPlayerFactory : IFootballPlayerFactory
{
    public FootballPlayer newFootballPlayer(
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
        FootballPlayerRating? ratingEAFC26)
    {
        return new FootballPlayer(
        id,
        playerName,
        country,
        ratingFIFA96,
        ratingFIFA97,
        ratingFIFA98,
        ratingFIFA99,
        ratingFIFA2000,
        ratingFIFA2001,
        ratingFIFA2002,
        ratingFIFA2003,
        ratingFIFA2004,
        ratingFIFA2005,
        ratingFIFA06,
        ratingFIFA07,
        ratingFIFA08,
        ratingFIFA09,
        ratingFIFA10,
        ratingFIFA11,
        ratingFIFA12,
        ratingFIFA13,
        ratingFIFA14,
        ratingFIFA15,
        ratingFIFA16,
        ratingFIFA17,
        ratingFIFA18,
        ratingFIFA19,
        ratingFIFA20,
        ratingFIFA21,
        ratingFIFA22,
        ratingFIFA23,
        ratingEAFC24,
        ratingEAFC25,
        ratingEAFC26);
    }
}