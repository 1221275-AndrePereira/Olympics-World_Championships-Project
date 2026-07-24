using Domain.Model.Football;

namespace Domain.Model.Interface;

public interface IFootballPlayer
{
    Guid GetPlayerId();
    string GetCountry();
    
    FootballPlayerRating? GetFIFA96Rating();
    FootballPlayerRating? GetFIFA97Rating();
    FootballPlayerRating? GetFIFA98Rating();
    FootballPlayerRating? GetFIFA99Rating();
    FootballPlayerRating? GetFIFA2000Rating();
    FootballPlayerRating? GetFIFA2001Rating();
    FootballPlayerRating? GetFIFA2002Rating();
    FootballPlayerRating? GetFIFA2003Rating();
    FootballPlayerRating? GetFIFA2004Rating();
    FootballPlayerRating? GetFIFA2005Rating();
    FootballPlayerRating? GetFIFA06Rating();
    FootballPlayerRating? GetFIFA07Rating();
    FootballPlayerRating? GetFIFA08Rating();
    FootballPlayerRating? GetFIFA09Rating();
    FootballPlayerRating? GetFIFA10Rating();
    FootballPlayerRating? GetFIFA11Rating();
    FootballPlayerRating? GetFIFA12Rating();
    FootballPlayerRating? GetFIFA13Rating();
    FootballPlayerRating? GetFIFA14Rating();
    FootballPlayerRating? GetFIFA15Rating();
    FootballPlayerRating? GetFIFA16Rating();
    FootballPlayerRating? GetFIFA17Rating();
    FootballPlayerRating? GetFIFA18Rating();
    FootballPlayerRating? GetFIFA19Rating();
    FootballPlayerRating? GetFIFA20Rating();
    FootballPlayerRating? GetFIFA21Rating();
    FootballPlayerRating? GetFIFA22Rating();
    FootballPlayerRating? GetFIFA23Rating();
    FootballPlayerRating? GetEAFC24Rating();
    FootballPlayerRating? GetEAFC25Rating();
    FootballPlayerRating? GetEAFC26Rating();

}