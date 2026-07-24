namespace Domain.Factory.Interface;

using Domain.Model;
using Domain.Model.Basketball;
using Domain.Model.Basketball.BasketballPlayer;

public interface IBasketballPlayerFactory
{
    BasketballPlayer newBasketballPlayer(
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
        BasketballPlayerRating? ratingNBA2K26);



}