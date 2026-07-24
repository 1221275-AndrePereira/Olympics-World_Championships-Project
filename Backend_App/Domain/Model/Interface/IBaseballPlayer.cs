using Domain.Model.Baseball;

namespace Domain.Model.Interface;

public interface IBaseballPlayer
{
    Guid GetPlayerId();
    string GetCountry();
    
    BaseballPlayerRating? GetMLBTriplePlay99Rating();
    BaseballPlayerRating? GetMLBTriplePlay2000Rating();
    BaseballPlayerRating? GetMLBTriplePlay2001Rating();
    BaseballPlayerRating? GetMLBTriplePlayBaseballRating();
    BaseballPlayerRating? GetMLBTriplePlay2002Rating();
    BaseballPlayerRating? GetMLB2004Rating();
    BaseballPlayerRating? GetMLB2K5Rating();
    BaseballPlayerRating? GetMLB2K6Rating();
    BaseballPlayerRating? GetMLB2K7Rating();
    BaseballPlayerRating? GetMLB2K8Rating();
    BaseballPlayerRating? GetMLB2K9Rating();
    BaseballPlayerRating? GetMLB2K10Rating();
    BaseballPlayerRating? GetMLB2K11Rating();
    BaseballPlayerRating? GetMLB2K12Rating();
    BaseballPlayerRating? GetMLBTheShow13Rating();
    BaseballPlayerRating? GetMLBTheShow14Rating();
    BaseballPlayerRating? GetMLBTheShow15Rating();
    BaseballPlayerRating? GetMLBTheShow16Rating();
    BaseballPlayerRating? GetMLBTheShow17Rating();
    BaseballPlayerRating? GetMLBTheShow18Rating();
    BaseballPlayerRating? GetMLBTheShow19Rating();
    BaseballPlayerRating? GetMLBTheShow20Rating();
    BaseballPlayerRating? GetMLBTheShow21Rating();
    BaseballPlayerRating? GetMLBTheShow22Rating();
    BaseballPlayerRating? GetMLBTheShow23Rating();
    BaseballPlayerRating? GetMLBTheShow24Rating();
    BaseballPlayerRating? GetMLBTheShow25Rating();

}