using Domain.Factory.Interface;

namespace Domain.Factory.IceHockeyPlayerFactory;

using Domain.Model.IceHockey;
using Domain.Model.IceHockey.IceHockeyPlayer;
using Domain.Model.Interface;

public class IceHockeyPlayerFactory : IIceHockeyPlayerFactory
{
    public IceHockeyPlayer newIceHockeyPlayer(
        Guid id,
        string playerName,
        string country,
        IceHockeyPlayerRating? ratingNHL93,
        IceHockeyPlayerRating? ratingNHL94,
        IceHockeyPlayerRating? ratingNHL95,
        IceHockeyPlayerRating? ratingNHL96,
        IceHockeyPlayerRating? ratingNHL97,
        IceHockeyPlayerRating? ratingNHL98,
        IceHockeyPlayerRating? ratingNHL99,
        IceHockeyPlayerRating? ratingNHL2000,
        IceHockeyPlayerRating? ratingNHL2001,
        IceHockeyPlayerRating? ratingNHL2002,
        IceHockeyPlayerRating? ratingNHL2003,
        IceHockeyPlayerRating? ratingNHL2004,
        IceHockeyPlayerRating? ratingNHL2005,
        IceHockeyPlayerRating? ratingNHL06,
        IceHockeyPlayerRating? ratingNHL07,
        IceHockeyPlayerRating? ratingNHL08,
        IceHockeyPlayerRating? ratingNHL09,
        IceHockeyPlayerRating? ratingNHL10,
        IceHockeyPlayerRating? ratingNHL11,
        IceHockeyPlayerRating? ratingNHL12,
        IceHockeyPlayerRating? ratingNHL13,
        IceHockeyPlayerRating? ratingNHL14,
        IceHockeyPlayerRating? ratingNHL15,
        IceHockeyPlayerRating? ratingNHL16,
        IceHockeyPlayerRating? ratingNHL17,
        IceHockeyPlayerRating? ratingNHL18,
        IceHockeyPlayerRating? ratingNHL19,
        IceHockeyPlayerRating? ratingNHL20,
        IceHockeyPlayerRating? ratingNHL21,
        IceHockeyPlayerRating? ratingNHL22,
        IceHockeyPlayerRating? ratingNHL23,
        IceHockeyPlayerRating? ratingNHL24,
        IceHockeyPlayerRating? ratingNHL25,
        IceHockeyPlayerRating? ratingNHL26)
    {
        return new IceHockeyPlayer(
        id,
        playerName,
        country,
        ratingNHL93,
        ratingNHL94,
        ratingNHL95,
        ratingNHL96,
        ratingNHL97,
        ratingNHL98,
        ratingNHL99,
        ratingNHL2000,
        ratingNHL2001,
        ratingNHL2002,
        ratingNHL2003,
        ratingNHL2004,
        ratingNHL2005,
        ratingNHL06,
        ratingNHL07,
        ratingNHL08,
        ratingNHL09,
        ratingNHL10,
        ratingNHL11,
        ratingNHL12,
        ratingNHL13,
        ratingNHL14,
        ratingNHL15,
        ratingNHL16,
        ratingNHL17,
        ratingNHL18,
        ratingNHL19,
        ratingNHL20,
        ratingNHL21,
        ratingNHL22,
        ratingNHL23,
        ratingNHL24,
        ratingNHL25,
        ratingNHL26);
    }
}