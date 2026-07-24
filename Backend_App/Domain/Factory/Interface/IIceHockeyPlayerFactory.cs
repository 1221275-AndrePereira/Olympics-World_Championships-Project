namespace Domain.Factory.Interface;

using Domain.Model;
using Domain.Model.IceHockey;
using Domain.Model.IceHockey.IceHockeyPlayer;

public interface IIceHockeyPlayerFactory
{
    IceHockeyPlayer newIceHockeyPlayer(
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
        IceHockeyPlayerRating? ratingNHL26);
}