namespace Domain.Factory.Interface;

using Domain.Model;
using Domain.Model.Handball;
using Domain.Model.Handball.HandballPlayer;

public interface IHandballPlayerFactory
{
    HandballPlayer newHandballPlayer(
        Guid id,
        string playerName,
        string country,
        HandballPlayerRating? ratingHandball17,
        HandballPlayerRating? ratingHandball21);
}