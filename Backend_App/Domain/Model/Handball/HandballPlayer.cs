namespace Domain.Model.Handball.HandballPlayer;
using System.ComponentModel.DataAnnotations;
using Domain.Model.Interface;


public class HandballPlayer : IHandballPlayer
{


    [Key] private Guid playerId;

    [Required] private string _strName;


    [Required] private string _strCountry;

    private HandballPlayerRating? _ratingHandball17;
    private HandballPlayerRating? _ratingHandball21;

    public Guid PlayerId
    {
        get { return playerId; }
        set { playerId = value; }
    }

    public string PlayerName
    {
        get { return _strName; }
    }


    public string Country
    {
        get { return _strCountry; }
    }

    public HandballPlayerRating? Handball17Rating
    {
        get { return _ratingHandball17; }
    }

    public HandballPlayerRating? Handball21Rating
    {
        get { return _ratingHandball21; }
    }


    // ----------------------------------------Constructor-----------------------------------------
    public HandballPlayer()
    {
    }

    public HandballPlayer(
        Guid id,
        string playerName,
        string country,
        HandballPlayerRating? ratingHandball17 = null,
        HandballPlayerRating? ratingHandball21 = null)
    {
            playerId = id;
            _strName = playerName;
            _strCountry = country;
            _ratingHandball17 = ratingHandball17;
            _ratingHandball21 = ratingHandball21;
        
    }




    // ----------------------------------------Getters-----------------------------------------
    public Guid GetPlayerId()
    {
        return playerId;
    }

    public string GetPlayerName()
    {
        return _strName;
    }

    public string GetCountry()
    {
        return _strCountry;
    }

    public HandballPlayerRating? GetHandball17Rating()
    {
        return _ratingHandball17;
    }

    public HandballPlayerRating? GetHandball21Rating()
    {
        return _ratingHandball21;
    }


    // ----------------------------------------Setters-----------------------------------------

    public void SetPlayerName(string playerName)
    {
        _strName = playerName;
    }
    public void SetCountry(string country)
    {
        _strCountry = country;
    }

    public void SetHandball17Rating(HandballPlayerRating rating)
    {
        _ratingHandball17 = rating;
    }

    public void SetHandball21Rating(HandballPlayerRating rating)
    {
        _ratingHandball21 = rating;
    }


}