namespace Domain.Model.Handball;
using System.ComponentModel.DataAnnotations;


public class HandballPlayerRating
{


    [Required] public double _overallRating;

    [Required] public string _strClub;
    [Required] public string _strPosition;

    public double OverallRating
    {
        get { return _overallRating; }
        set { _overallRating = value; }
    }


    public string Club
    {
        get { return _strClub; }
        set { _strClub = value; }
    }


    public string Position
    {
        get { return _strPosition; }
        set { _strPosition = value; }
    }

    // ----------------------------------------Constructor-----------------------------------------
    public HandballPlayerRating()
    {
    }

    public HandballPlayerRating(
        double rating,
        string club,
        string position)
    {
        
            _overallRating = rating;
            _strClub = club;
            _strPosition = position;
        
    }




    // ----------------------------------------Getters-----------------------------------------
    public double GetOverallRating()
    {
        return _overallRating;
    }

    public string GetClub()
    {
        return _strClub;
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


    public void SetClub(string club)
    {
        _strClub = club;
    }


    public void SetPosition(string position)
    {
        _strPosition = position;
    }


}