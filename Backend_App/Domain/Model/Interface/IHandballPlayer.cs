using Domain.Model.Handball;

namespace Domain.Model.Interface;

public interface IHandballPlayer
{
    Guid GetPlayerId();
    string GetCountry();
    
    HandballPlayerRating? GetHandball17Rating();
    HandballPlayerRating? GetHandball21Rating();

}