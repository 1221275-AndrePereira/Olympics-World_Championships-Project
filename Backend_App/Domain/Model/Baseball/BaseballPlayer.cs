namespace Domain.Model.Baseball.BaseballPlayer;
using System.ComponentModel.DataAnnotations;
using Domain.Model.Interface;


public class BaseballPlayer : IBaseballPlayer
{


    [Key] private Guid playerId;

    [Required] private string _strName;


    [Required] private string _strCountry;

    private BaseballPlayerRating? _ratingMLBTRIPLEPLAY99;
    private BaseballPlayerRating? _ratingMLBTRIPLEPLAY2000;
    private BaseballPlayerRating? _ratingMLBTRIPLEPLAY2001;
    private BaseballPlayerRating? _ratingMLBTRIPLEPLAYBASEBALL;
    private BaseballPlayerRating? _ratingMLBTRIPLEPLAY2002;
    private BaseballPlayerRating? _ratingMLB2004;
    private BaseballPlayerRating? _ratingMLBESPN;
    private BaseballPlayerRating? _ratingMLB2K5;
    private BaseballPlayerRating? _ratingMLB2K6;
    private BaseballPlayerRating? _ratingMLB2K7;
    private BaseballPlayerRating? _ratingMLB2K8;
    private BaseballPlayerRating? _ratingMLB2K9;
    private BaseballPlayerRating? _ratingMLB2K10;
    private BaseballPlayerRating? _ratingMLB2K11;
    private BaseballPlayerRating? _ratingMLB2K12;
    private BaseballPlayerRating? _ratingMLBTHESHOW13;
    private BaseballPlayerRating? _ratingMLBTHESHOW14;
    private BaseballPlayerRating? _ratingMLBTHESHOW15;
    private BaseballPlayerRating? _ratingMLBTHESHOW16;
    private BaseballPlayerRating? _ratingMLBTHESHOW17;
    private BaseballPlayerRating? _ratingMLBTHESHOW18;
    private BaseballPlayerRating? _ratingMLBTHESHOW19;
    private BaseballPlayerRating? _ratingMLBTHESHOW20;
    private BaseballPlayerRating? _ratingMLBTHESHOW21;
    private BaseballPlayerRating? _ratingMLBTHESHOW22;
    private BaseballPlayerRating? _ratingMLBTHESHOW23;
    private BaseballPlayerRating? _ratingMLBTHESHOW24;
    private BaseballPlayerRating? _ratingMLBTHESHOW25;

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

    public BaseballPlayerRating? MLBTriplePlay99Rating
    {
        get { return _ratingMLBTRIPLEPLAY99; }
    }

    public BaseballPlayerRating? MLBTriplePlay2000Rating
    {
        get { return _ratingMLBTRIPLEPLAY2000; }
    }

    public BaseballPlayerRating? MLBTriplePlay2001Rating
    {
        get { return _ratingMLBTRIPLEPLAY2001; }
    }

    public BaseballPlayerRating? MLBTriplePlayBaseballRating
    {
        get { return _ratingMLBTRIPLEPLAYBASEBALL; }
    }

    public BaseballPlayerRating? MLBTriplePlay2002Rating
    {
        get { return _ratingMLBTRIPLEPLAY2002; }
    }

    public BaseballPlayerRating? MLB2004Rating
    {
        get { return _ratingMLB2004; }
    }

    public BaseballPlayerRating? MLBESPNRating
    {
        get { return _ratingMLBESPN; }
    }

    public BaseballPlayerRating? MLB2K5Rating
    {
        get { return _ratingMLB2K5; }
    }

    public BaseballPlayerRating? MLB2K6Rating
    {
        get { return _ratingMLB2K6; }
    }

    public BaseballPlayerRating? MLB2K7Rating
    {
        get { return _ratingMLB2K7; }
    }

    public BaseballPlayerRating? MLB2K8Rating
    {
        get { return _ratingMLB2K8; }
    }

    public BaseballPlayerRating? MLB2K9Rating
    {
        get { return _ratingMLB2K9; }
    }

    public BaseballPlayerRating? MLB2K10Rating
    {
        get { return _ratingMLB2K10; }
    }

    public BaseballPlayerRating? MLB2K11Rating
    {
        get { return _ratingMLB2K11; }
    }

    public BaseballPlayerRating? MLB2K12Rating
    {
        get { return _ratingMLB2K12; }
    }

    public BaseballPlayerRating? MLBTheShow13Rating
    {
        get { return _ratingMLBTHESHOW13; }
    }

    public BaseballPlayerRating? MLBTheShow14Rating
    {
        get { return _ratingMLBTHESHOW14; }
    }

    public BaseballPlayerRating? MLBTheShow15Rating
    {
        get { return _ratingMLBTHESHOW15; }
    }

    public BaseballPlayerRating? MLBTheShow16Rating
    {
        get { return _ratingMLBTHESHOW16; }
    }

    public BaseballPlayerRating? MLBTheShow17Rating
    {
        get { return _ratingMLBTHESHOW17; }
    }

    public BaseballPlayerRating? MLBTheShow18Rating
    {
        get { return _ratingMLBTHESHOW18; }
    }

    public BaseballPlayerRating? MLBTheShow19Rating
    {
        get { return _ratingMLBTHESHOW19; }
    }

    public BaseballPlayerRating? MLBTheShow20Rating
    {
        get { return _ratingMLBTHESHOW20; }
    }

    public BaseballPlayerRating? MLBTheShow21Rating
    {
        get { return _ratingMLBTHESHOW21; }
    }

    public BaseballPlayerRating? MLBTheShow22Rating
    {
        get { return _ratingMLBTHESHOW22; }
    }

    public BaseballPlayerRating? MLBTheShow23Rating
    {
        get { return _ratingMLBTHESHOW23; }
    }

    public BaseballPlayerRating? MLBTheShow24Rating
    {
        get { return _ratingMLBTHESHOW24; }
    }

    public BaseballPlayerRating? MLBTheShow25Rating
    {
        get { return _ratingMLBTHESHOW25; }
    }


    // ----------------------------------------Constructor-----------------------------------------
    public BaseballPlayer()
    {
    }

    public BaseballPlayer(
        Guid id,
        string playerName,
        string country,
        BaseballPlayerRating? ratingMLBTriplePlay99 = null,
        BaseballPlayerRating? ratingMLBTriplePlay2000 = null,
        BaseballPlayerRating? ratingMLBTriplePlay2001 = null,
        BaseballPlayerRating? ratingMLBTriplePlayBaseball = null,
        BaseballPlayerRating? ratingMLBTriplePlay2002 = null,
        BaseballPlayerRating? ratingMLB2004 = null,
        BaseballPlayerRating? ratingMLBESPN = null,
        BaseballPlayerRating? ratingMLB2K5 = null,
        BaseballPlayerRating? ratingMLB2K6 = null,
        BaseballPlayerRating? ratingMLB2K7 = null,
        BaseballPlayerRating? ratingMLB2K8 = null,
        BaseballPlayerRating? ratingMLB2K9 = null,
        BaseballPlayerRating? ratingMLB2K10 = null,
        BaseballPlayerRating? ratingMLB2K11 = null,
        BaseballPlayerRating? ratingMLB2K12 = null,
        BaseballPlayerRating? ratingMLBTheShow13 = null,
        BaseballPlayerRating? ratingMLBTheShow14 = null,
        BaseballPlayerRating? ratingMLBTheShow15 = null,
        BaseballPlayerRating? ratingMLBTheShow16 = null,
        BaseballPlayerRating? ratingMLBTheShow17 = null,
        BaseballPlayerRating? ratingMLBTheShow18 = null,
        BaseballPlayerRating? ratingMLBTheShow19 = null,
        BaseballPlayerRating? ratingMLBTheShow20 = null,
        BaseballPlayerRating? ratingMLBTheShow21 = null,
        BaseballPlayerRating? ratingMLBTheShow22 = null,
        BaseballPlayerRating? ratingMLBTheShow23 = null,
        BaseballPlayerRating? ratingMLBTheShow24 = null,
        BaseballPlayerRating? ratingMLBTheShow25 = null)
    {
            playerId = id;
            _strName = playerName;
            _strCountry = country;
            _ratingMLBTRIPLEPLAY99 = ratingMLBTriplePlay99;
            _ratingMLBTRIPLEPLAY2000 = ratingMLBTriplePlay2000;
            _ratingMLBTRIPLEPLAY2001 = ratingMLBTriplePlay2001;
            _ratingMLBTRIPLEPLAYBASEBALL = ratingMLBTriplePlayBaseball;
            _ratingMLBTRIPLEPLAY2002 = ratingMLBTriplePlay2002;
            _ratingMLB2004 = ratingMLB2004;
            _ratingMLBESPN = ratingMLBESPN;
            _ratingMLB2K5 = ratingMLB2K5;
            _ratingMLB2K6 = ratingMLB2K6;
            _ratingMLB2K7 = ratingMLB2K7;
            _ratingMLB2K8 = ratingMLB2K8;
            _ratingMLB2K9 = ratingMLB2K9;
            _ratingMLB2K10 = ratingMLB2K10;
            _ratingMLB2K11 = ratingMLB2K11;
            _ratingMLB2K12 = ratingMLB2K12;
            _ratingMLBTHESHOW13 = ratingMLBTheShow13;
            _ratingMLBTHESHOW14 = ratingMLBTheShow14;
            _ratingMLBTHESHOW15 = ratingMLBTheShow15;
            _ratingMLBTHESHOW16 = ratingMLBTheShow16;
            _ratingMLBTHESHOW17 = ratingMLBTheShow17;
            _ratingMLBTHESHOW18 = ratingMLBTheShow18;
            _ratingMLBTHESHOW19 = ratingMLBTheShow19;
            _ratingMLBTHESHOW20 = ratingMLBTheShow20;
            _ratingMLBTHESHOW21 = ratingMLBTheShow21;
            _ratingMLBTHESHOW22 = ratingMLBTheShow22;
            _ratingMLBTHESHOW23 = ratingMLBTheShow23;
            _ratingMLBTHESHOW24 = ratingMLBTheShow24;
            _ratingMLBTHESHOW25 = ratingMLBTheShow25;
        
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

    public BaseballPlayerRating? GetMLBTriplePlay99Rating()
    {
        return _ratingMLBTRIPLEPLAY99;
    }

    public BaseballPlayerRating? GetMLBTriplePlay2000Rating()
    {
        return _ratingMLBTRIPLEPLAY2000;
    }

    public BaseballPlayerRating? GetMLBTriplePlay2001Rating()
    {
        return _ratingMLBTRIPLEPLAY2001;
    }

    public BaseballPlayerRating? GetMLBTriplePlayBaseballRating()
    {
        return _ratingMLBTRIPLEPLAYBASEBALL;
    }

    public BaseballPlayerRating? GetMLBTriplePlay2002Rating()
    {
        return _ratingMLBTRIPLEPLAY2002;
    }

    public BaseballPlayerRating? GetMLB2004Rating()
    {
        return _ratingMLB2004;
    }

    public BaseballPlayerRating? GetMLBESPNRating()
    {
        return _ratingMLBESPN;
    }

    public BaseballPlayerRating? GetMLB2K5Rating()
    {
        return _ratingMLB2K5;
    }

    public BaseballPlayerRating? GetMLB2K6Rating()
    {
        return _ratingMLB2K6;
    }

    public BaseballPlayerRating? GetMLB2K7Rating()
    {
        return _ratingMLB2K7;
    }

    public BaseballPlayerRating? GetMLB2K8Rating()
    {
        return _ratingMLB2K8;
    }

    public BaseballPlayerRating? GetMLB2K9Rating()
    {
        return _ratingMLB2K9;
    }

    public BaseballPlayerRating? GetMLB2K10Rating()
    {
        return _ratingMLB2K10;
    }

    public BaseballPlayerRating? GetMLB2K11Rating()
    {
        return _ratingMLB2K11;
    }

    public BaseballPlayerRating? GetMLB2K12Rating()
    {
        return _ratingMLB2K12;
    }

    public BaseballPlayerRating? GetMLBTheShow13Rating()
    {
        return _ratingMLBTHESHOW13;
    }

    public BaseballPlayerRating? GetMLBTheShow14Rating()
    {
        return _ratingMLBTHESHOW14;
    }

    public BaseballPlayerRating? GetMLBTheShow15Rating()
    {
        return _ratingMLBTHESHOW15;
    }

    public BaseballPlayerRating? GetMLBTheShow16Rating()
    {
        return _ratingMLBTHESHOW16;
    }

    public BaseballPlayerRating? GetMLBTheShow17Rating()
    {
        return _ratingMLBTHESHOW17;
    }

    public BaseballPlayerRating? GetMLBTheShow18Rating()
    {
        return _ratingMLBTHESHOW18;
    }

    public BaseballPlayerRating? GetMLBTheShow19Rating()
    {
        return _ratingMLBTHESHOW19;
    }

    public BaseballPlayerRating? GetMLBTheShow20Rating()
    {
        return _ratingMLBTHESHOW20;
    }

    public BaseballPlayerRating? GetMLBTheShow21Rating()
    {
        return _ratingMLBTHESHOW21;
    }

    public BaseballPlayerRating? GetMLBTheShow22Rating()
    {
        return _ratingMLBTHESHOW22;
    }

    public BaseballPlayerRating? GetMLBTheShow23Rating()
    {
        return _ratingMLBTHESHOW23;
    }

    public BaseballPlayerRating? GetMLBTheShow24Rating()
    {
        return _ratingMLBTHESHOW24;
    }

    public BaseballPlayerRating? GetMLBTheShow25Rating()
    {
        return _ratingMLBTHESHOW25;
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

    public void SetMLBTriplePlay99Rating(BaseballPlayerRating rating)
    {
        _ratingMLBTRIPLEPLAY99 = rating;
    }

    public void SetMLBTriplePlay2000Rating(BaseballPlayerRating rating)
    {
        _ratingMLBTRIPLEPLAY2000 = rating;
    }

    public void SetMLBTriplePlay2001Rating(BaseballPlayerRating rating)
    {
        _ratingMLBTRIPLEPLAY2001 = rating;
    }

    public void SetTriplePlayBaseballRating(BaseballPlayerRating rating)
    {
        _ratingMLBTRIPLEPLAYBASEBALL = rating;
    }

    public void SetTriplePlay2002Rating(BaseballPlayerRating rating)
    {
        _ratingMLBTRIPLEPLAY2002 = rating;
    }

    public void SetMLB2004Rating(BaseballPlayerRating rating)
    {
        _ratingMLB2004 = rating;
    }

    public void SetMLBESPNRating(BaseballPlayerRating rating)
    {
        _ratingMLBESPN = rating;
    }

    public void SetMLB2K5Rating(BaseballPlayerRating rating)
    {
        _ratingMLB2K5 = rating;
    }

    public void SetMLB2K6Rating(BaseballPlayerRating rating)
    {
        _ratingMLB2K6 = rating;
    }

    public void SetMLB2K7Rating(BaseballPlayerRating rating)
    {
        _ratingMLB2K7 = rating;
    }

    public void SetMLB2K8Rating(BaseballPlayerRating rating)
    {
        _ratingMLB2K8 = rating;
    }

    public void SetMLB2K9Rating(BaseballPlayerRating rating)
    {
        _ratingMLB2K9 = rating;
    }

    public void SetMLB2K10Rating(BaseballPlayerRating rating)
    {
        _ratingMLB2K10 = rating;
    }

    public void SetMLB2K11Rating(BaseballPlayerRating rating)
    {
        _ratingMLB2K11 = rating;
    }

    public void SetMLB2K12Rating(BaseballPlayerRating rating)
    {
        _ratingMLB2K12 = rating;
    }

    public void SetMLBTheShow13Rating(BaseballPlayerRating rating)
    {
        _ratingMLBTHESHOW13 = rating;
    }

    public void SetMLBTheShow14Rating(BaseballPlayerRating rating)
    {
        _ratingMLBTHESHOW14 = rating;
    }

    public void SetMLBTheShow15Rating(BaseballPlayerRating rating)
    {
        _ratingMLBTHESHOW15 = rating;
    }

    public void SetMLBTheShow16Rating(BaseballPlayerRating rating)
    {
        _ratingMLBTHESHOW16 = rating;
    }

    public void SetMLBTheShow17Rating(BaseballPlayerRating rating)
    {
        _ratingMLBTHESHOW17 = rating;
    }

    public void SetMLBTheShow18Rating(BaseballPlayerRating rating)
    {
        _ratingMLBTHESHOW18 = rating;
    }

    public void SetMLBTheShow19Rating(BaseballPlayerRating rating)
    {
        _ratingMLBTHESHOW19 = rating;
    }

    public void SetMLBTheShow20Rating(BaseballPlayerRating rating)
    {
        _ratingMLBTHESHOW20 = rating;
    }

    public void SetMLBTheShow21Rating(BaseballPlayerRating rating)
    {
        _ratingMLBTHESHOW21 = rating;
    }

    public void SetMLBTheShow22Rating(BaseballPlayerRating rating)
    {
        _ratingMLBTHESHOW22 = rating;
    }

    public void SetMLBTheShow23Rating(BaseballPlayerRating rating)
    {
        _ratingMLBTHESHOW23 = rating;
    }

    public void SetMLBTheShow24Rating(BaseballPlayerRating rating)
    {
        _ratingMLBTHESHOW24 = rating;
    }

    public void SetMLBTheShow25Rating(BaseballPlayerRating rating)
    {
        _ratingMLBTHESHOW25 = rating;
    }


}