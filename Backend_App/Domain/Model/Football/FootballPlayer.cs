namespace Domain.Model.Football.FootballPlayer;
using System.ComponentModel.DataAnnotations;
using Domain.Model.Interface;


public class FootballPlayer : IFootballPlayer
{


    [Key] private Guid playerId;

    [Required] private string _strName;


    [Required] private string _strCountry;

    private FootballPlayerRating? _ratingFIFA96;
    private FootballPlayerRating? _ratingFIFA97;
    private FootballPlayerRating? _ratingFIFA98;
    private FootballPlayerRating? _ratingFIFA99;
    private FootballPlayerRating? _ratingFIFA2000;
    private FootballPlayerRating? _ratingFIFA2001;
    private FootballPlayerRating? _ratingFIFA2002;
    private FootballPlayerRating? _ratingFIFA2003;
    private FootballPlayerRating? _ratingFIFA2004;
    private FootballPlayerRating? _ratingFIFA2005;
    private FootballPlayerRating? _ratingFIFA06;
    private FootballPlayerRating? _ratingFIFA07;
    private FootballPlayerRating? _ratingFIFA08;
    private FootballPlayerRating? _ratingFIFA09;
    private FootballPlayerRating? _ratingFIFA10;
    private FootballPlayerRating? _ratingFIFA11;
    private FootballPlayerRating? _ratingFIFA12;
    private FootballPlayerRating? _ratingFIFA13;
    private FootballPlayerRating? _ratingFIFA14;
    private FootballPlayerRating? _ratingFIFA15;
    private FootballPlayerRating? _ratingFIFA16;
    private FootballPlayerRating? _ratingFIFA17;
    private FootballPlayerRating? _ratingFIFA18;
    private FootballPlayerRating? _ratingFIFA19;
    private FootballPlayerRating? _ratingFIFA20;
    private FootballPlayerRating? _ratingFIFA21;
    private FootballPlayerRating? _ratingFIFA22;
    private FootballPlayerRating? _ratingFIFA23;
    private FootballPlayerRating? _ratingEAFC24;
    private FootballPlayerRating? _ratingEAFC25;
    private FootballPlayerRating? _ratingEAFC26;

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

    public FootballPlayerRating? FIFA96Rating
    {
        get { return _ratingFIFA96; }
    }

    public FootballPlayerRating? FIFA97Rating
    {
        get { return _ratingFIFA97; }
    }

    public FootballPlayerRating? FIFA98Rating
    {
        get { return _ratingFIFA98; }
    }

    public FootballPlayerRating? FIFA99Rating
    {
        get { return _ratingFIFA99; }
    }

    public FootballPlayerRating? FIFA2000Rating
    {
        get { return _ratingFIFA2000; }
    }

    public FootballPlayerRating? FIFA2001Rating
    {
        get { return _ratingFIFA2001; }
    }

    public FootballPlayerRating? FIFA2002Rating
    {
        get { return _ratingFIFA2002; }
    }

    public FootballPlayerRating? FIFA2003Rating
    {
        get { return _ratingFIFA2003; }
    }

    public FootballPlayerRating? FIFA2004Rating
    {
        get { return _ratingFIFA2004; }
    }

    public FootballPlayerRating? FIFA2005Rating
    {
        get { return _ratingFIFA2005; }
    }

    public FootballPlayerRating? FIFA06Rating
    {
        get { return _ratingFIFA06; }
    }

    public FootballPlayerRating? FIFA07Rating
    {
        get { return _ratingFIFA07; }
    }

    public FootballPlayerRating? FIFA08Rating
    {
        get { return _ratingFIFA08; }
    }

    public FootballPlayerRating? FIFA09Rating
    {
        get { return _ratingFIFA09; }
    }

    public FootballPlayerRating? FIFA10Rating
    {
        get { return _ratingFIFA10; }
    }

    public FootballPlayerRating? FIFA11Rating
    {
        get { return _ratingFIFA11; }
    }

    public FootballPlayerRating? FIFA12Rating
    {
        get { return _ratingFIFA12; }
    }

    public FootballPlayerRating? FIFA13Rating
    {
        get { return _ratingFIFA13; }
    }

    public FootballPlayerRating? FIFA14Rating
    {
        get { return _ratingFIFA14; }
    }

    public FootballPlayerRating? FIFA15Rating
    {
        get { return _ratingFIFA15; }
    }

    public FootballPlayerRating? FIFA16Rating
    {
        get { return _ratingFIFA16; }
    }

    public FootballPlayerRating? FIFA17Rating
    {
        get { return _ratingFIFA17; }
    }

    public FootballPlayerRating? FIFA18Rating
    {
        get { return _ratingFIFA18; }
    }

    public FootballPlayerRating? FIFA19Rating
    {
        get { return _ratingFIFA19; }
    }

    public FootballPlayerRating? FIFA20Rating
    {
        get { return _ratingFIFA20; }
    }

    public FootballPlayerRating? FIFA21Rating
    {
        get { return _ratingFIFA21; }
    }

    public FootballPlayerRating? FIFA22Rating
    {
        get { return _ratingFIFA22; }
    }

    public FootballPlayerRating? FIFA23Rating
    {
        get { return _ratingFIFA23; }
    }

    public FootballPlayerRating? EAFC24Rating
    {
        get { return _ratingEAFC24; }
    }

    public FootballPlayerRating? EAFC25Rating
    {
        get { return _ratingEAFC25; }
    }

    public FootballPlayerRating? EAFC26Rating
    {
        get { return _ratingEAFC26; }
    }


    // ----------------------------------------Constructor-----------------------------------------
    public FootballPlayer()
    {
    }

    public FootballPlayer(
        Guid id,
        string playerName,
        string country,
        FootballPlayerRating? ratingFIFA96 = null,
        FootballPlayerRating? ratingFIFA97 = null,
        FootballPlayerRating? ratingFIFA98 = null,
        FootballPlayerRating? ratingFIFA99 = null,
        FootballPlayerRating? ratingFIFA2000 = null,
        FootballPlayerRating? ratingFIFA2001 = null,
        FootballPlayerRating? ratingFIFA2002 = null,
        FootballPlayerRating? ratingFIFA2003 = null,
        FootballPlayerRating? ratingFIFA2004 = null,
        FootballPlayerRating? ratingFIFA2005 = null,
        FootballPlayerRating? ratingFIFA06 = null,
        FootballPlayerRating? ratingFIFA07 = null,
        FootballPlayerRating? ratingFIFA08 = null,
        FootballPlayerRating? ratingFIFA09 = null,
        FootballPlayerRating? ratingFIFA10 = null,
        FootballPlayerRating? ratingFIFA11 = null,
        FootballPlayerRating? ratingFIFA12 = null,
        FootballPlayerRating? ratingFIFA13 = null,
        FootballPlayerRating? ratingFIFA14 = null,
        FootballPlayerRating? ratingFIFA15 = null,
        FootballPlayerRating? ratingFIFA16 = null,
        FootballPlayerRating? ratingFIFA17 = null,
        FootballPlayerRating? ratingFIFA18 = null,
        FootballPlayerRating? ratingFIFA19 = null,
        FootballPlayerRating? ratingFIFA20 = null,
        FootballPlayerRating? ratingFIFA21 = null,
        FootballPlayerRating? ratingFIFA22 = null,
        FootballPlayerRating? ratingFIFA23 = null,
        FootballPlayerRating? ratingEAFC24 = null,
        FootballPlayerRating? ratingEAFC25 = null,
        FootballPlayerRating? ratingEAFC26 = null)
    {
            playerId = id;
            _strName = playerName;
            _strCountry = country;
            _ratingFIFA96 = ratingFIFA96;
            _ratingFIFA97 = ratingFIFA97;
            _ratingFIFA98 = ratingFIFA98;
            _ratingFIFA99 = ratingFIFA99;
            _ratingFIFA2000 = ratingFIFA2000;
            _ratingFIFA2001 = ratingFIFA2001;
            _ratingFIFA2002 = ratingFIFA2002;
            _ratingFIFA2003 = ratingFIFA2003;
            _ratingFIFA2004 = ratingFIFA2004;
            _ratingFIFA2005 = ratingFIFA2005;
            _ratingFIFA06 = ratingFIFA06;
            _ratingFIFA07 = ratingFIFA07;
            _ratingFIFA08 = ratingFIFA08;
            _ratingFIFA09 = ratingFIFA09;
            _ratingFIFA10 = ratingFIFA10;
            _ratingFIFA11 = ratingFIFA11;
            _ratingFIFA12 = ratingFIFA12;
            _ratingFIFA13 = ratingFIFA13;
            _ratingFIFA14 = ratingFIFA14;
            _ratingFIFA15 = ratingFIFA15;
            _ratingFIFA16 = ratingFIFA16;
            _ratingFIFA17 = ratingFIFA17;
            _ratingFIFA18 = ratingFIFA18;
            _ratingFIFA19 = ratingFIFA19;
            _ratingFIFA20 = ratingFIFA20;
            _ratingFIFA21 = ratingFIFA21;
            _ratingFIFA22 = ratingFIFA22;
            _ratingFIFA23 = ratingFIFA23;
            _ratingEAFC24 = ratingEAFC24;
            _ratingEAFC25 = ratingEAFC25;
            _ratingEAFC26 = ratingEAFC26;
        
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

    public FootballPlayerRating? GetFIFA96Rating()
    {
        return _ratingFIFA96;
    }

    public FootballPlayerRating? GetFIFA97Rating()
    {
        return _ratingFIFA97;
    }

    public FootballPlayerRating? GetFIFA98Rating()
    {
        return _ratingFIFA98;
    }

    public FootballPlayerRating? GetFIFA99Rating()
    {
        return _ratingFIFA99;
    }

    public FootballPlayerRating? GetFIFA2000Rating()
    {
        return _ratingFIFA2000;
    }

    public FootballPlayerRating? GetFIFA2001Rating()
    {
        return _ratingFIFA2001;
    }

    public FootballPlayerRating? GetFIFA2002Rating()
    {
        return _ratingFIFA2002;
    }

    public FootballPlayerRating? GetFIFA2003Rating()
    {
        return _ratingFIFA2003;
    }

    public FootballPlayerRating? GetFIFA2004Rating()
    {
        return _ratingFIFA2004;
    }

    public FootballPlayerRating? GetFIFA2005Rating()
    {
        return _ratingFIFA2005;
    }

    public FootballPlayerRating? GetFIFA06Rating()
    {
        return _ratingFIFA06;
    }

    public FootballPlayerRating? GetFIFA07Rating()
    {
        return _ratingFIFA07;
    }

    public FootballPlayerRating? GetFIFA08Rating()
    {
        return _ratingFIFA08;
    }

    public FootballPlayerRating? GetFIFA09Rating()
    {
        return _ratingFIFA09;
    }

    public FootballPlayerRating? GetFIFA10Rating()
    {
        return _ratingFIFA10;
    }

    public FootballPlayerRating? GetFIFA11Rating()
    {
        return _ratingFIFA11;
    }

    public FootballPlayerRating? GetFIFA12Rating()
    {
        return _ratingFIFA12;
    }

    public FootballPlayerRating? GetFIFA13Rating()
    {
        return _ratingFIFA13;
    }

    public FootballPlayerRating? GetFIFA14Rating()
    {
        return _ratingFIFA14;
    }

    public FootballPlayerRating? GetFIFA15Rating()
    {
        return _ratingFIFA15;
    }

    public FootballPlayerRating? GetFIFA16Rating()
    {
        return _ratingFIFA16;
    }

    public FootballPlayerRating? GetFIFA17Rating()
    {
        return _ratingFIFA17;
    }

    public FootballPlayerRating? GetFIFA18Rating()
    {
        return _ratingFIFA18;
    }

    public FootballPlayerRating? GetFIFA19Rating()
    {
        return _ratingFIFA19;
    }

    public FootballPlayerRating? GetFIFA20Rating()
    {
        return _ratingFIFA20;
    }

    public FootballPlayerRating? GetFIFA21Rating()
    {
        return _ratingFIFA21;
    }

    public FootballPlayerRating? GetFIFA22Rating()
    {
        return _ratingFIFA22;
    }

    public FootballPlayerRating? GetFIFA23Rating()
    {
        return _ratingFIFA23;
    }

    public FootballPlayerRating? GetEAFC24Rating()
    {
        return _ratingEAFC24;
    }

    public FootballPlayerRating? GetEAFC25Rating()
    {
        return _ratingEAFC25;
    }

    public FootballPlayerRating? GetEAFC26Rating()
    {
        return _ratingEAFC26;
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

    public void SetFIFA96Rating(FootballPlayerRating rating)
    {
        _ratingFIFA96 = rating;
    }

    public void SetFIFA97Rating(FootballPlayerRating rating)
    {
        _ratingFIFA97 = rating;
    }

    public void SetFIFA98Rating(FootballPlayerRating rating)
    {
        _ratingFIFA98 = rating;
    }

    public void SetFIFA99Rating(FootballPlayerRating rating)
    {
        _ratingFIFA99 = rating;
    }

    public void SetFIFA2000Rating(FootballPlayerRating rating)
    {
        _ratingFIFA2000 = rating;
    }

    public void SetFIFA2001Rating(FootballPlayerRating rating)
    {
        _ratingFIFA2001 = rating;
    }

    public void SetFIFA2002Rating(FootballPlayerRating rating)
    {
        _ratingFIFA2002 = rating;
    }

    public void SetFIFA2003Rating(FootballPlayerRating rating)
    {
        _ratingFIFA2003 = rating;
    }

    public void SetFIFA2004Rating(FootballPlayerRating rating)
    {
        _ratingFIFA2004 = rating;
    }

    public void SetFIFA2005Rating(FootballPlayerRating rating)
    {
        _ratingFIFA2005 = rating;
    }

    public void SetFIFA06Rating(FootballPlayerRating rating)
    {
        _ratingFIFA06 = rating;
    }

    public void SetFIFA07Rating(FootballPlayerRating rating)
    {
        _ratingFIFA07 = rating;
    }

    public void SetFIFA08Rating(FootballPlayerRating rating)
    {
        _ratingFIFA08 = rating;
    }

    public void SetFIFA09Rating(FootballPlayerRating rating)
    {
        _ratingFIFA09 = rating;
    }

    public void SetFIFA10Rating(FootballPlayerRating rating)
    {
        _ratingFIFA10 = rating;
    }

    public void SetFIFA11Rating(FootballPlayerRating rating)
    {
        _ratingFIFA11 = rating;
    }

    public void SetFIFA12Rating(FootballPlayerRating rating)
    {
        _ratingFIFA12 = rating;
    }

    public void SetFIFA13Rating(FootballPlayerRating rating)
    {
        _ratingFIFA13 = rating;
    }

    public void SetFIFA14Rating(FootballPlayerRating rating)
    {
        _ratingFIFA14 = rating;
    }

    public void SetFIFA15Rating(FootballPlayerRating rating)
    {
        _ratingFIFA15 = rating;
    }

    public void SetFIFA16Rating(FootballPlayerRating rating)
    {
        _ratingFIFA16 = rating;
    }

    public void SetFIFA17Rating(FootballPlayerRating rating)
    {
        _ratingFIFA17 = rating;
    }

    public void SetFIFA18Rating(FootballPlayerRating rating)
    {
        _ratingFIFA18 = rating;
    }

    public void SetFIFA19Rating(FootballPlayerRating rating)
    {
        _ratingFIFA19 = rating;
    }

    public void SetFIFA20Rating(FootballPlayerRating rating)
    {
        _ratingFIFA20 = rating;
    }

    public void SetFIFA21Rating(FootballPlayerRating rating)
    {
        _ratingFIFA21 = rating;
    }

    public void SetFIFA22Rating(FootballPlayerRating rating)
    {
        _ratingFIFA22 = rating;
    }

    public void SetFIFA23Rating(FootballPlayerRating rating)
    {
        _ratingFIFA23 = rating;
    }

    public void SetEAFC24Rating(FootballPlayerRating rating)
    {
        _ratingEAFC24 = rating;
    }

    public void SetEAFC25Rating(FootballPlayerRating rating)
    {
        _ratingEAFC25 = rating;
    }

    public void SetEAFC26Rating(FootballPlayerRating rating)
    {
        _ratingEAFC26 = rating;
    }


}