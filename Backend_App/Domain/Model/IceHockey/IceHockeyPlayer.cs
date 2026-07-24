namespace Domain.Model.IceHockey.IceHockeyPlayer;
using System.ComponentModel.DataAnnotations;
using Domain.Model.Interface;


public class IceHockeyPlayer : IIceHockeyPlayer
{


    [Key] private Guid playerId;

    [Required] private string _strName;


    [Required] private string _strCountry;

    private IceHockeyPlayerRating? _ratingNHL93;
    private IceHockeyPlayerRating? _ratingNHL94;
    private IceHockeyPlayerRating? _ratingNHL95;
    private IceHockeyPlayerRating? _ratingNHL96;
    private IceHockeyPlayerRating? _ratingNHL97;
    private IceHockeyPlayerRating? _ratingNHL98;
    private IceHockeyPlayerRating? _ratingNHL99;
    private IceHockeyPlayerRating? _ratingNHL2000;
    private IceHockeyPlayerRating? _ratingNHL2001;
    private IceHockeyPlayerRating? _ratingNHL2002;
    private IceHockeyPlayerRating? _ratingNHL2003;
    private IceHockeyPlayerRating? _ratingNHL2004;
    private IceHockeyPlayerRating? _ratingNHL2005;
    private IceHockeyPlayerRating? _ratingNHL06;
    private IceHockeyPlayerRating? _ratingNHL07;
    private IceHockeyPlayerRating? _ratingNHL08;
    private IceHockeyPlayerRating? _ratingNHL09;
    private IceHockeyPlayerRating? _ratingNHL10;
    private IceHockeyPlayerRating? _ratingNHL11;
    private IceHockeyPlayerRating? _ratingNHL12;
    private IceHockeyPlayerRating? _ratingNHL13;
    private IceHockeyPlayerRating? _ratingNHL14;
    private IceHockeyPlayerRating? _ratingNHL15;
    private IceHockeyPlayerRating? _ratingNHL16;
    private IceHockeyPlayerRating? _ratingNHL17;
    private IceHockeyPlayerRating? _ratingNHL18;
    private IceHockeyPlayerRating? _ratingNHL19;
    private IceHockeyPlayerRating? _ratingNHL20;
    private IceHockeyPlayerRating? _ratingNHL21;
    private IceHockeyPlayerRating? _ratingNHL22;
    private IceHockeyPlayerRating? _ratingNHL23;
    private IceHockeyPlayerRating? _ratingNHL24;
    private IceHockeyPlayerRating? _ratingNHL25;
    private IceHockeyPlayerRating? _ratingNHL26;

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

    public IceHockeyPlayerRating? NHL93Rating
    {
        get { return _ratingNHL93; }
    }

    public IceHockeyPlayerRating? NHL94Rating
    {
        get { return _ratingNHL94; }
    }

    public IceHockeyPlayerRating? NHL95Rating
    {
        get { return _ratingNHL95; }
    }

    public IceHockeyPlayerRating? NHL96Rating
    {
        get { return _ratingNHL96; }
    }

    public IceHockeyPlayerRating? NHL97Rating
    {
        get { return _ratingNHL97; }
    }

    public IceHockeyPlayerRating? NHL98Rating
    {
        get { return _ratingNHL98; }
    }

    public IceHockeyPlayerRating? NHL99Rating
    {
        get { return _ratingNHL99; }
    }

    public IceHockeyPlayerRating? NHL2000Rating
    {
        get { return _ratingNHL2000; }
    }

    public IceHockeyPlayerRating? NHL2001Rating
    {
        get { return _ratingNHL2001; }
    }

    public IceHockeyPlayerRating? NHL2002Rating
    {
        get { return _ratingNHL2002; }
    }

    public IceHockeyPlayerRating? NHL2003Rating
    {
        get { return _ratingNHL2003; }
    }

    public IceHockeyPlayerRating? NHL2004Rating
    {
        get { return _ratingNHL2004; }
    }

    public IceHockeyPlayerRating? NHL2005Rating
    {
        get { return _ratingNHL2005; }
    }

    public IceHockeyPlayerRating? NHL06Rating
    {
        get { return _ratingNHL06; }
    }

    public IceHockeyPlayerRating? NHL07Rating
    {
        get { return _ratingNHL07; }
    }

    public IceHockeyPlayerRating? NHL08Rating
    {
        get { return _ratingNHL08; }
    }

    public IceHockeyPlayerRating? NHL09Rating
    {
        get { return _ratingNHL09; }
    }

    public IceHockeyPlayerRating? NHL10Rating
    {
        get { return _ratingNHL10; }
    }

    public IceHockeyPlayerRating? NHL11Rating
    {
        get { return _ratingNHL11; }
    }

    public IceHockeyPlayerRating? NHL12Rating
    {
        get { return _ratingNHL12; }
    }

    public IceHockeyPlayerRating? NHL13Rating
    {
        get { return _ratingNHL13; }
    }

    public IceHockeyPlayerRating? NHL14Rating
    {
        get { return _ratingNHL14; }
    }

    public IceHockeyPlayerRating? NHL15Rating
    {
        get { return _ratingNHL15; }
    }

    public IceHockeyPlayerRating? NHL16Rating
    {
        get { return _ratingNHL16; }
    }

    public IceHockeyPlayerRating? NHL17Rating
    {
        get { return _ratingNHL17; }
    }

    public IceHockeyPlayerRating? NHL18Rating
    {
        get { return _ratingNHL18; }
    }

    public IceHockeyPlayerRating? NHL19Rating
    {
        get { return _ratingNHL19; }
    }

    public IceHockeyPlayerRating? NHL20Rating
    {
        get { return _ratingNHL20; }
    }

    public IceHockeyPlayerRating? NHL21Rating
    {
        get { return _ratingNHL21; }
    }

    public IceHockeyPlayerRating? NHL22Rating
    {
        get { return _ratingNHL22; }
    }

    public IceHockeyPlayerRating? NHL23Rating
    {
        get { return _ratingNHL23; }
    }

    public IceHockeyPlayerRating? NHL24Rating
    {
        get { return _ratingNHL24; }
    }

    public IceHockeyPlayerRating? NHL25Rating
    {
        get { return _ratingNHL25; }
    }

    public IceHockeyPlayerRating? NHL26Rating
    {
        get { return _ratingNHL26; }
    }



    // ----------------------------------------Constructor-----------------------------------------
    public IceHockeyPlayer()
    {
    }

    public IceHockeyPlayer(
        Guid id,
        string playerName,
        string country,
        IceHockeyPlayerRating? ratingNHL93 = null,
        IceHockeyPlayerRating? ratingNHL94 = null,
        IceHockeyPlayerRating? ratingNHL95 = null,
        IceHockeyPlayerRating? ratingNHL96 = null,
        IceHockeyPlayerRating? ratingNHL97 = null,
        IceHockeyPlayerRating? ratingNHL98 = null,
        IceHockeyPlayerRating? ratingNHL99 = null,
        IceHockeyPlayerRating? ratingNHL2000 = null,
        IceHockeyPlayerRating? ratingNHL2001 = null,
        IceHockeyPlayerRating? ratingNHL2002 = null,
        IceHockeyPlayerRating? ratingNHL2003 = null,
        IceHockeyPlayerRating? ratingNHL2004 = null,
        IceHockeyPlayerRating? ratingNHL2005 = null,
        IceHockeyPlayerRating? ratingNHL06 = null,
        IceHockeyPlayerRating? ratingNHL07 = null,
        IceHockeyPlayerRating? ratingNHL08 = null,
        IceHockeyPlayerRating? ratingNHL09 = null,
        IceHockeyPlayerRating? ratingNHL10 = null,
        IceHockeyPlayerRating? ratingNHL11 = null,
        IceHockeyPlayerRating? ratingNHL12 = null,
        IceHockeyPlayerRating? ratingNHL13 = null,
        IceHockeyPlayerRating? ratingNHL14 = null,
        IceHockeyPlayerRating? ratingNHL15 = null,
        IceHockeyPlayerRating? ratingNHL16 = null,
        IceHockeyPlayerRating? ratingNHL17 = null,
        IceHockeyPlayerRating? ratingNHL18 = null,
        IceHockeyPlayerRating? ratingNHL19 = null,
        IceHockeyPlayerRating? ratingNHL20 = null,
        IceHockeyPlayerRating? ratingNHL21 = null,
        IceHockeyPlayerRating? ratingNHL22 = null,
        IceHockeyPlayerRating? ratingNHL23 = null,
        IceHockeyPlayerRating? ratingNHL24 = null,
        IceHockeyPlayerRating? ratingNHL25 = null,
        IceHockeyPlayerRating? ratingNHL26 = null)
    {
            playerId = id;
            _strName = playerName;
            _strCountry = country;
            _ratingNHL93 = ratingNHL93;
            _ratingNHL94 = ratingNHL94;
            _ratingNHL95 = ratingNHL95;
            _ratingNHL96 = ratingNHL96;
            _ratingNHL97 = ratingNHL97;
            _ratingNHL98 = ratingNHL98;
            _ratingNHL99 = ratingNHL99;
            _ratingNHL2000 = ratingNHL2000;
            _ratingNHL2001 = ratingNHL2001;
            _ratingNHL2002 = ratingNHL2002;
            _ratingNHL2003 = ratingNHL2003;
            _ratingNHL2004 = ratingNHL2004;
            _ratingNHL2005 = ratingNHL2005;
            _ratingNHL06 = ratingNHL06;
            _ratingNHL07 = ratingNHL07;
            _ratingNHL08 = ratingNHL08;
            _ratingNHL09 = ratingNHL09;
            _ratingNHL10 = ratingNHL10;
            _ratingNHL11 = ratingNHL11;
            _ratingNHL12 = ratingNHL12;
            _ratingNHL13 = ratingNHL13;
            _ratingNHL14 = ratingNHL14;
            _ratingNHL15 = ratingNHL15;
            _ratingNHL16 = ratingNHL16;
            _ratingNHL17 = ratingNHL17;
            _ratingNHL18 = ratingNHL18;
            _ratingNHL19 = ratingNHL19;
            _ratingNHL20 = ratingNHL20;
            _ratingNHL21 = ratingNHL21;
            _ratingNHL22 = ratingNHL22;
            _ratingNHL23 = ratingNHL23;
            _ratingNHL24 = ratingNHL24;
            _ratingNHL25 = ratingNHL25;
            _ratingNHL26 = ratingNHL26;
        
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

    public IceHockeyPlayerRating? GetNHL93Rating()
    {
        return _ratingNHL93;
    }

    public IceHockeyPlayerRating? GetNHL94Rating()
    {
        return _ratingNHL94;
    }

    public IceHockeyPlayerRating? GetNHL95Rating()
    {
        return _ratingNHL95;
    }

    public IceHockeyPlayerRating? GetNHL96Rating()
    {
        return _ratingNHL96;
    }

    public IceHockeyPlayerRating? GetNHL97Rating()
    {
        return _ratingNHL97;
    }

    public IceHockeyPlayerRating? GetNHL98Rating()
    {
        return _ratingNHL98;
    }

    public IceHockeyPlayerRating? GetNHL99Rating()
    {
        return _ratingNHL99;
    }

    public IceHockeyPlayerRating? GetNHL2000Rating()
    {
        return _ratingNHL2000;
    }

    public IceHockeyPlayerRating? GetNHL2001Rating()
    {
        return _ratingNHL2001;
    }

    public IceHockeyPlayerRating? GetNHL2002Rating()
    {
        return _ratingNHL2002;
    }

    public IceHockeyPlayerRating? GetNHL2003Rating()
    {
        return _ratingNHL2003;
    }

    public IceHockeyPlayerRating? GetNHL2004Rating()
    {
        return _ratingNHL2004;
    }

    public IceHockeyPlayerRating? GetNHL2005Rating()
    {
        return _ratingNHL2005;
    }

    public IceHockeyPlayerRating? GetNHL06Rating()
    {
        return _ratingNHL06;
    }

    public IceHockeyPlayerRating? GetNHL07Rating()
    {
        return _ratingNHL07;
    }

    public IceHockeyPlayerRating? GetNHL08Rating()
    {
        return _ratingNHL08;
    }

    public IceHockeyPlayerRating? GetNHL09Rating()
    {
        return _ratingNHL09;
    }

    public IceHockeyPlayerRating? GetNHL10Rating()
    {
        return _ratingNHL10;
    }

    public IceHockeyPlayerRating? GetNHL11Rating()
    {
        return _ratingNHL11;
    }

    public IceHockeyPlayerRating? GetNHL12Rating()
    {
        return _ratingNHL12;
    }

    public IceHockeyPlayerRating? GetNHL13Rating()
    {
        return _ratingNHL13;
    }

    public IceHockeyPlayerRating? GetNHL14Rating()
    {
        return _ratingNHL14;
    }

    public IceHockeyPlayerRating? GetNHL15Rating()
    {
        return _ratingNHL15;
    }

    public IceHockeyPlayerRating? GetNHL16Rating()
    {
        return _ratingNHL16;
    }

    public IceHockeyPlayerRating? GetNHL17Rating()
    {
        return _ratingNHL17;
    }

    public IceHockeyPlayerRating? GetNHL18Rating()
    {
        return _ratingNHL18;
    }

    public IceHockeyPlayerRating? GetNHL19Rating()
    {
        return _ratingNHL19;
    }

    public IceHockeyPlayerRating? GetNHL20Rating()
    {
        return _ratingNHL20;
    }

    public IceHockeyPlayerRating? GetNHL21Rating()
    {
        return _ratingNHL21;
    }

    public IceHockeyPlayerRating? GetNHL22Rating()
    {
        return _ratingNHL22;
    }

    public IceHockeyPlayerRating? GetNHL23Rating()
    {
        return _ratingNHL23;
    }

    public IceHockeyPlayerRating? GetNHL24Rating()
    {
        return _ratingNHL24;
    }

    public IceHockeyPlayerRating? GetNHL25Rating()
    {
        return _ratingNHL25;
    }

    public IceHockeyPlayerRating? GetNHL26Rating()
    {
        return _ratingNHL26;
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

    public void SetNHL93Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL93 = rating;
    }

    public void SetNHL94Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL94 = rating;
    }

    public void SetNHL95Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL95 = rating;
    }

    public void SetNHL96Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL96 = rating;
    }

    public void SetNHL97Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL97 = rating;
    }

    public void SetNHL98Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL98 = rating;
    }

    public void SetNHL99Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL99 = rating;
    }

    public void SetNHL2000Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL2000 = rating;
    }

    public void SetNHL2001Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL2001 = rating;
    }

    public void SetNHL2002Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL2002 = rating;
    }

    public void SetNHL2003Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL2003 = rating;
    }

    public void SetNHL2004Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL2004 = rating;
    }

    public void SetNHL2005Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL2005 = rating;
    }

    public void SetNHL06Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL06 = rating;
    }

    public void SetNHL07Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL07 = rating;
    }

    public void SetNHL08Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL08 = rating;
    }

    public void SetNHL09Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL09 = rating;
    }

    public void SetNHL10Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL10 = rating;
    }

    public void SetNHL11Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL11 = rating;
    }

    public void SetNHL12Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL12 = rating;
    }

    public void SetNHL13Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL13 = rating;
    }

    public void SetNHL14Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL14 = rating;
    }

    public void SetNHL15Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL15 = rating;
    }

    public void SetNHL16Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL16 = rating;
    }

    public void SetNHL17Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL17 = rating;
    }

    public void SetNHL18Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL18 = rating;
    }

    public void SetNHL19Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL19 = rating;
    }

    public void SetNHL20Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL20 = rating;
    }

    public void SetNHL21Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL21 = rating;
    }

    public void SetNHL22Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL22 = rating;
    }

    public void SetNHL23Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL23 = rating;
    }

    public void SetNHL24Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL24 = rating;
    }

    public void SetNHL25Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL25 = rating;
    }

    public void SetNHL26Rating(IceHockeyPlayerRating rating)
    {
        _ratingNHL26 = rating;
    }


}