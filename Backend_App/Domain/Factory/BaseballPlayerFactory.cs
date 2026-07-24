using Domain.Factory.Interface;

namespace Domain.Factory.BaseballPlayerFactory;

using Domain.Model.Baseball;
using Domain.Model.Baseball.BaseballPlayer;
using Domain.Model.Interface;

public class BaseballPlayerFactory : IBaseballPlayerFactory
{
    public BaseballPlayer newBaseballPlayer(
        Guid id,
        string playerName,
        string country,
        BaseballPlayerRating? ratingMLBTriplePlay99,
        BaseballPlayerRating? ratingMLBTriplePlay2000,
        BaseballPlayerRating? ratingMLBTriplePlay2001,
        BaseballPlayerRating? ratingMLBTriplePlayBaseball,
        BaseballPlayerRating? ratingMLBTriplePlay2002,
        BaseballPlayerRating? ratingMLB2004,
        BaseballPlayerRating? ratingMLBESPN,
        BaseballPlayerRating? ratingMLB2K5,
        BaseballPlayerRating? ratingMLB2K6,
        BaseballPlayerRating? ratingMLB2K7,
        BaseballPlayerRating? ratingMLB2K8,
        BaseballPlayerRating? ratingMLB2K9,
        BaseballPlayerRating? ratingMLB2K10,
        BaseballPlayerRating? ratingMLB2K11,
        BaseballPlayerRating? ratingMLB2K12,
        BaseballPlayerRating? ratingMLBTheShow13,
        BaseballPlayerRating? ratingMLBTheShow14,
        BaseballPlayerRating? ratingMLBTheShow15,
        BaseballPlayerRating? ratingMLBTheShow16,
        BaseballPlayerRating? ratingMLBTheShow17,
        BaseballPlayerRating? ratingMLBTheShow18,
        BaseballPlayerRating? ratingMLBTheShow19,
        BaseballPlayerRating? ratingMLBTheShow20,
        BaseballPlayerRating? ratingMLBTheShow21,
        BaseballPlayerRating? ratingMLBTheShow22,
        BaseballPlayerRating? ratingMLBTheShow23,
        BaseballPlayerRating? ratingMLBTheShow24,
        BaseballPlayerRating? ratingMLBTheShow25)
    {
        return new BaseballPlayer(
        id,
        playerName,
        country,
        ratingMLBTriplePlay99,
        ratingMLBTriplePlay2000,
        ratingMLBTriplePlay2001,
        ratingMLBTriplePlayBaseball,
        ratingMLBTriplePlay2002,
        ratingMLB2004,
        ratingMLBESPN,
        ratingMLB2K5,
        ratingMLB2K6,
        ratingMLB2K7,
        ratingMLB2K8,
        ratingMLB2K9,
        ratingMLB2K10,
        ratingMLB2K11,
        ratingMLB2K12,
        ratingMLBTheShow13,
        ratingMLBTheShow14,
        ratingMLBTheShow15,
        ratingMLBTheShow16,
        ratingMLBTheShow17,
        ratingMLBTheShow18,
        ratingMLBTheShow19,
        ratingMLBTheShow20,
        ratingMLBTheShow21,
        ratingMLBTheShow22,
        ratingMLBTheShow23,
        ratingMLBTheShow24,
        ratingMLBTheShow25);
    }
}