namespace Domain.Factory.Interface;

using Domain.Model;
using Domain.Model.Baseball;
using Domain.Model.Baseball.BaseballPlayer;

public interface IBaseballPlayerFactory
{
    BaseballPlayer newBaseballPlayer(
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
        BaseballPlayerRating? ratingMLBTheShow25);



}