namespace Domain.Model.AmericanFootball;
using System.ComponentModel.DataAnnotations;


public class AmericanFootballPlayerRating
{


    [Required] public double _overallRating;

    [Required] public string _strTeam;
    [Required] public string _strPosition;

    public double OverallRating
    {
        get { return _overallRating; }
        set { _overallRating = value; }
    }


    public string Team
    {
        get { return _strTeam; }
        set { _strTeam = value; }
    }


    public string Position
    {
        get { return _strPosition; }
        set { _strPosition = value; }
    }

    // ----------------------------------------Constructor-----------------------------------------
    public AmericanFootballPlayerRating()
    {
    }

    public AmericanFootballPlayerRating(
        double rating,
        string team,
        string position)
    {
        
            _overallRating = rating;
            _strTeam = team;
            _strPosition = position;
        
    }




    // ----------------------------------------Getters-----------------------------------------
    public double GetOverallRating()
    {
        return _overallRating;
    }

    public string GetTeam()
    {
        return _strTeam;
    }


    public string GetPosition()
    {
        return _strPosition;
    }


    // ----------------------------------------Setters-----------------------------------------

    public void SetRating(double rating)
    {
        _overallRating = rating;
    }


    public void SetTeam(string team)
    {
        _strTeam = team;
    }


    public void SetPosition(string position)
    {
        _strPosition = position;
    }


}