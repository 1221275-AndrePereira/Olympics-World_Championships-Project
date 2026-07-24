using Domain.Factory.Interface;

namespace Domain.Factory.HandballPlayerFactory;

using Domain.Model.Handball;
using Domain.Model.Handball.HandballPlayer;
using Domain.Model.Interface;

public class HandballPlayerFactory : IHandballPlayerFactory
{
    public HandballPlayer newHandballPlayer(
        Guid id,
        string playerName,
        string country,
        HandballPlayerRating? ratingHandball17,
        HandballPlayerRating? ratingHandball21)
    {
        return new HandballPlayer(
        id,
        playerName,
        country,
        ratingHandball17,
        ratingHandball21);
    }
}