using Domain.Model;
using Domain.Model.Handball;
using Domain.Model.Handball.HandballPlayer;

namespace DataModel.Model;

public class HandballPlayerDataModel
{
    public Guid PlayerId{ get; set; }

    public string PlayerName{ get; set; }

    public string Country{ get; set; }

    public HandballPlayerRating? Handball17Rating { get; set; }

    public HandballPlayerRating? Handball21Rating { get; set; }

    public HandballPlayerDataModel()
    {
    }

    public HandballPlayerDataModel(HandballPlayer handballPlayer)
    {
        PlayerId = handballPlayer.PlayerId;
        PlayerName = handballPlayer.GetPlayerName();
        Country = handballPlayer.GetCountry();
        Handball17Rating = handballPlayer.GetHandball17Rating();
        Handball21Rating = handballPlayer.GetHandball21Rating();
    }
}