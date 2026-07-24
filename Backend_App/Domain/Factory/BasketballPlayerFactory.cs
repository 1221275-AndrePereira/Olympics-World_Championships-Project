using Domain.Factory.Interface;

namespace Domain.Factory.BasketballPlayerFactory;

using Domain.Model.Basketball;
using Domain.Model.Basketball.BasketballPlayer;
using Domain.Model.Interface;

public class BasketballPlayerFactory : IBasketballPlayerFactory
{
    public BasketballPlayer newBasketballPlayer(
        Guid id,
        string playerName,
        string country,
        BasketballPlayerRating? ratingNBALive95,
        BasketballPlayerRating? ratingNBALive96,
        BasketballPlayerRating? ratingNBALive97,
        BasketballPlayerRating? ratingNBALive98,
        BasketballPlayerRating? ratingNBALive99,
        BasketballPlayerRating? ratingNBA2K,
        BasketballPlayerRating? ratingNBA2K1,
        BasketballPlayerRating? ratingNBA2K2,
        BasketballPlayerRating? ratingNBA2K3,
        BasketballPlayerRating? ratingNBA2K4,
        BasketballPlayerRating? ratingNBA2K5,
        BasketballPlayerRating? ratingNBA2K6,
        BasketballPlayerRating? ratingNBA2K7,
        BasketballPlayerRating? ratingNBA2K8,
        BasketballPlayerRating? ratingNBA2K9,
        BasketballPlayerRating? ratingNBA2K10,
        BasketballPlayerRating? ratingNBA2K11,
        BasketballPlayerRating? ratingNBA2K12,
        BasketballPlayerRating? ratingNBA2K13,
        BasketballPlayerRating? ratingNBA2K14,
        BasketballPlayerRating? ratingNBA2K15,
        BasketballPlayerRating? ratingNBA2K16,
        BasketballPlayerRating? ratingNBA2K17,
        BasketballPlayerRating? ratingNBA2K18,
        BasketballPlayerRating? ratingNBA2K19,
        BasketballPlayerRating? ratingNBA2K20,
        BasketballPlayerRating? ratingNBA2K21,
        BasketballPlayerRating? ratingNBA2K22,
        BasketballPlayerRating? ratingNBA2K23,
        BasketballPlayerRating? ratingNBA2K24,
        BasketballPlayerRating? ratingNBA2K25,
        BasketballPlayerRating? ratingNBA2K26)
    {
        return new BasketballPlayer(
        id,
        playerName,
        country,
        ratingNBALive95,
        ratingNBALive96,
        ratingNBALive97,
        ratingNBALive98,
        ratingNBALive99,
        ratingNBA2K,
        ratingNBA2K1,
        ratingNBA2K2,
        ratingNBA2K3,
        ratingNBA2K4,
        ratingNBA2K5,
        ratingNBA2K6,
        ratingNBA2K7,
        ratingNBA2K8,
        ratingNBA2K9,
        ratingNBA2K10,
        ratingNBA2K11,
        ratingNBA2K12,
        ratingNBA2K13,
        ratingNBA2K14,
        ratingNBA2K15,
        ratingNBA2K16,
        ratingNBA2K17,
        ratingNBA2K18,
        ratingNBA2K19,
        ratingNBA2K20,
        ratingNBA2K21,
        ratingNBA2K22,
        ratingNBA2K23,
        ratingNBA2K24,
        ratingNBA2K25,
        ratingNBA2K26);
    }
}