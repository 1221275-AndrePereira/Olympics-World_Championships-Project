namespace Domain.Model.Basketball.BasketballPlayer;
using System.ComponentModel.DataAnnotations;
using Domain.Model.Interface;


public class BasketballPlayer : IBasketballPlayer
{


    [Key] private Guid playerId;

    [Required] private string _strName;


    [Required] private string _strCountry;

    private BasketballPlayerRating? _ratingNBALIVE95;
    private BasketballPlayerRating? _ratingNBALIVE96;
    private BasketballPlayerRating? _ratingNBALIVE97;
    private BasketballPlayerRating? _ratingNBALIVE98;
    private BasketballPlayerRating? _ratingNBALIVE99;
    private BasketballPlayerRating? _ratingNBA2K;
    private BasketballPlayerRating? _ratingNBA2K1;
    private BasketballPlayerRating? _ratingNBA2K2;
    private BasketballPlayerRating? _ratingNBA2K3;
    private BasketballPlayerRating? _ratingNBA2K4;
    private BasketballPlayerRating? _ratingNBA2K5;
    private BasketballPlayerRating? _ratingNBA2K6;
    private BasketballPlayerRating? _ratingNBA2K7;
    private BasketballPlayerRating? _ratingNBA2K8;
    private BasketballPlayerRating? _ratingNBA2K9;
    private BasketballPlayerRating? _ratingNBA2K10;
    private BasketballPlayerRating? _ratingNBA2K11;
    private BasketballPlayerRating? _ratingNBA2K12;
    private BasketballPlayerRating? _ratingNBA2K13;
    private BasketballPlayerRating? _ratingNBA2K14;
    private BasketballPlayerRating? _ratingNBA2K15;
    private BasketballPlayerRating? _ratingNBA2K16;
    private BasketballPlayerRating? _ratingNBA2K17;
    private BasketballPlayerRating? _ratingNBA2K18;
    private BasketballPlayerRating? _ratingNBA2K19;
    private BasketballPlayerRating? _ratingNBA2K20;
    private BasketballPlayerRating? _ratingNBA2K21;
    private BasketballPlayerRating? _ratingNBA2K22;
    private BasketballPlayerRating? _ratingNBA2K23;
    private BasketballPlayerRating? _ratingNBA2K24;
    private BasketballPlayerRating? _ratingNBA2K25;
    private BasketballPlayerRating? _ratingNBA2K26;

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

    public BasketballPlayerRating? NBALive95Rating
    {
        get { return _ratingNBALIVE95; }
    }

    public BasketballPlayerRating? NBALive96Rating
    {
        get { return _ratingNBALIVE96; }
    }

    public BasketballPlayerRating? NBALive97Rating
    {
        get { return _ratingNBALIVE97; }
    }

    public BasketballPlayerRating? NBALive98Rating
    {
        get { return _ratingNBALIVE98; }
    }

    public BasketballPlayerRating? NBALive99Rating
    {
        get { return _ratingNBALIVE99; }
    }

    public BasketballPlayerRating? NBA2KRating
    {
        get { return _ratingNBA2K; }
    }

    public BasketballPlayerRating? NBA2K1Rating
    {
        get { return _ratingNBA2K1; }
    }

    public BasketballPlayerRating? NBA2K2Rating
    {
        get { return _ratingNBA2K2; }
    }

    public BasketballPlayerRating? NBA2K3Rating
    {
        get { return _ratingNBA2K3; }
    }

    public BasketballPlayerRating? NBA2K4Rating
    {
        get { return _ratingNBA2K4; }
    }

    public BasketballPlayerRating? NBA2K5Rating
    {
        get { return _ratingNBA2K5; }
    }

    public BasketballPlayerRating? NBA2K6Rating
    {
        get { return _ratingNBA2K6; }
    }

    public BasketballPlayerRating? NBA2K7Rating
    {
        get { return _ratingNBA2K7; }
    }

    public BasketballPlayerRating? NBA2K8Rating
    {
        get { return _ratingNBA2K8; }
    }

    public BasketballPlayerRating? NBA2K9Rating
    {
        get { return _ratingNBA2K9; }
    }

    public BasketballPlayerRating? NBA2K10Rating
    {
        get { return _ratingNBA2K10; }
    }

    public BasketballPlayerRating? NBA2K11Rating
    {
        get { return _ratingNBA2K11; }
    }

    public BasketballPlayerRating? NBA2K12Rating
    {
        get { return _ratingNBA2K12; }
    }

    public BasketballPlayerRating? NBA2K13Rating
    {
        get { return _ratingNBA2K13; }
    }

    public BasketballPlayerRating? NBA2K14Rating
    {
        get { return _ratingNBA2K14; }
    }

    public BasketballPlayerRating? NBA2K15Rating
    {
        get { return _ratingNBA2K15; }
    }

    public BasketballPlayerRating? NBA2K16Rating
    {
        get { return _ratingNBA2K16; }
    }

    public BasketballPlayerRating? NBA2K17Rating
    {
        get { return _ratingNBA2K17; }
    }

    public BasketballPlayerRating? NBA2K18Rating
    {
        get { return _ratingNBA2K18; }
    }

    public BasketballPlayerRating? NBA2K19Rating
    {
        get { return _ratingNBA2K19; }
    }

    public BasketballPlayerRating? NBA2K20Rating
    {
        get { return _ratingNBA2K20; }
    }

    public BasketballPlayerRating? NBA2K21Rating
    {
        get { return _ratingNBA2K21; }
    }

    public BasketballPlayerRating? NBA2K22Rating
    {
        get { return _ratingNBA2K22; }
    }

    public BasketballPlayerRating? NBA2K23Rating
    {
        get { return _ratingNBA2K23; }
    }

    public BasketballPlayerRating? NBA2K24Rating
    {
        get { return _ratingNBA2K24; }
    }

    public BasketballPlayerRating? NBA2K25Rating
    {
        get { return _ratingNBA2K25; }
    }

    public BasketballPlayerRating? NBA2K26Rating
    {
        get { return _ratingNBA2K26; }
    }


    // ----------------------------------------Constructor-----------------------------------------
    public BasketballPlayer()
    {
    }

    public BasketballPlayer(
        Guid id,
        string playerName,
        string country,
        BasketballPlayerRating? ratingNBALive95 = null,
        BasketballPlayerRating? ratingNBALive96 = null,
        BasketballPlayerRating? ratingNBALive97 = null,
        BasketballPlayerRating? ratingNBALive98 = null,
        BasketballPlayerRating? ratingNBALive99 = null,
        BasketballPlayerRating? ratingNBA2K = null,
        BasketballPlayerRating? ratingNBA2K1 = null,
        BasketballPlayerRating? ratingNBA2K2 = null,
        BasketballPlayerRating? ratingNBA2K3 = null,
        BasketballPlayerRating? ratingNBA2K4 = null,
        BasketballPlayerRating? ratingNBA2K5 = null,
        BasketballPlayerRating? ratingNBA2K6 = null,
        BasketballPlayerRating? ratingNBA2K7 = null,
        BasketballPlayerRating? ratingNBA2K8 = null,
        BasketballPlayerRating? ratingNBA2K9 = null,
        BasketballPlayerRating? ratingNBA2K10 = null,
        BasketballPlayerRating? ratingNBA2K11 = null,
        BasketballPlayerRating? ratingNBA2K12 = null,
        BasketballPlayerRating? ratingNBA2K13 = null,
        BasketballPlayerRating? ratingNBA2K14 = null,
        BasketballPlayerRating? ratingNBA2K15 = null,
        BasketballPlayerRating? ratingNBA2K16 = null,
        BasketballPlayerRating? ratingNBA2K17 = null,
        BasketballPlayerRating? ratingNBA2K18 = null,
        BasketballPlayerRating? ratingNBA2K19 = null,
        BasketballPlayerRating? ratingNBA2K20 = null,
        BasketballPlayerRating? ratingNBA2K21 = null,
        BasketballPlayerRating? ratingNBA2K22 = null,
        BasketballPlayerRating? ratingNBA2K23 = null,
        BasketballPlayerRating? ratingNBA2K24 = null,
        BasketballPlayerRating? ratingNBA2K25 = null,
        BasketballPlayerRating? ratingNBA2K26 = null)
    {
            playerId = id;
            _strName = playerName;
            _strCountry = country;
            _ratingNBALIVE95 = ratingNBALive95;
            _ratingNBALIVE96 = ratingNBALive96;
            _ratingNBALIVE97 = ratingNBALive97;
            _ratingNBALIVE98 = ratingNBALive98;
            _ratingNBALIVE99 = ratingNBALive99;
            _ratingNBA2K = ratingNBA2K;
            _ratingNBA2K1 = ratingNBA2K1;
            _ratingNBA2K2 = ratingNBA2K2;
            _ratingNBA2K3 = ratingNBA2K3;
            _ratingNBA2K4 = ratingNBA2K4;
            _ratingNBA2K5 = ratingNBA2K5;
            _ratingNBA2K6 = ratingNBA2K6;
            _ratingNBA2K7 = ratingNBA2K7;
            _ratingNBA2K8 = ratingNBA2K8;
            _ratingNBA2K9 = ratingNBA2K9;
            _ratingNBA2K10 = ratingNBA2K10;
            _ratingNBA2K11 = ratingNBA2K11;
            _ratingNBA2K12 = ratingNBA2K12;
            _ratingNBA2K13 = ratingNBA2K13;
            _ratingNBA2K14 = ratingNBA2K14;
            _ratingNBA2K15 = ratingNBA2K15;
            _ratingNBA2K16 = ratingNBA2K16;
            _ratingNBA2K17 = ratingNBA2K17;
            _ratingNBA2K18 = ratingNBA2K18;
            _ratingNBA2K19 = ratingNBA2K19;
            _ratingNBA2K20 = ratingNBA2K20;
            _ratingNBA2K21 = ratingNBA2K21;
            _ratingNBA2K22 = ratingNBA2K22;
            _ratingNBA2K23 = ratingNBA2K23;
            _ratingNBA2K24 = ratingNBA2K24;
            _ratingNBA2K25 = ratingNBA2K25;
            _ratingNBA2K26 = ratingNBA2K26;
        
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

    public BasketballPlayerRating? GetNBALive95Rating()
    {
        return _ratingNBALIVE95;
    }

    public BasketballPlayerRating? GetNBALive96Rating()
    {
        return _ratingNBALIVE96;
    }

    public BasketballPlayerRating? GetNBALive97Rating()
    {
        return _ratingNBALIVE97;
    }

    public BasketballPlayerRating? GetNBALive98Rating()
    {
        return _ratingNBALIVE98;
    }

    public BasketballPlayerRating? GetNBALive99Rating()
    {
        return _ratingNBALIVE99;
    }

    public BasketballPlayerRating? GetNBA2KRating()
    {
        return _ratingNBA2K;
    }

    public BasketballPlayerRating? GetNBA2K1Rating()
    {
        return _ratingNBA2K1;
    }

    public BasketballPlayerRating? GetNBA2K2Rating()
    {
        return _ratingNBA2K2;
    }

    public BasketballPlayerRating? GetNBA2K3Rating()
    {
        return _ratingNBA2K3;
    }

    public BasketballPlayerRating? GetNBA2K4Rating()
    {
        return _ratingNBA2K4;
    }

    public BasketballPlayerRating? GetNBA2K5Rating()
    {
        return _ratingNBA2K5;
    }

    public BasketballPlayerRating? GetNBA2K6Rating()
    {
        return _ratingNBA2K6;
    }

    public BasketballPlayerRating? GetNBA2K7Rating()
    {
        return _ratingNBA2K7;
    }

    public BasketballPlayerRating? GetNBA2K8Rating()
    {
        return _ratingNBA2K8;
    }

    public BasketballPlayerRating? GetNBA2K9Rating()
    {
        return _ratingNBA2K9;
    }

    public BasketballPlayerRating? GetNBA2K10Rating()
    {
        return _ratingNBA2K10;
    }

    public BasketballPlayerRating? GetNBA2K11Rating()
    {
        return _ratingNBA2K11;
    }

    public BasketballPlayerRating? GetNBA2K12Rating()
    {
        return _ratingNBA2K12;
    }

    public BasketballPlayerRating? GetNBA2K13Rating()
    {
        return _ratingNBA2K13;
    }

    public BasketballPlayerRating? GetNBA2K14Rating()
    {
        return _ratingNBA2K14;
    }

    public BasketballPlayerRating? GetNBA2K15Rating()
    {
        return _ratingNBA2K15;
    }

    public BasketballPlayerRating? GetNBA2K16Rating()
    {
        return _ratingNBA2K16;
    }

    public BasketballPlayerRating? GetNBA2K17Rating()
    {
        return _ratingNBA2K17;
    }

    public BasketballPlayerRating? GetNBA2K18Rating()
    {
        return _ratingNBA2K18;
    }

    public BasketballPlayerRating? GetNBA2K19Rating()
    {
        return _ratingNBA2K19;
    }

    public BasketballPlayerRating? GetNBA2K20Rating()
    {
        return _ratingNBA2K20;
    }

    public BasketballPlayerRating? GetNBA2K21Rating()
    {
        return _ratingNBA2K21;
    }

    public BasketballPlayerRating? GetNBA2K22Rating()
    {
        return _ratingNBA2K22;
    }

    public BasketballPlayerRating? GetNBA2K23Rating()
    {
        return _ratingNBA2K23;
    }

    public BasketballPlayerRating? GetNBA2K24Rating()
    {
        return _ratingNBA2K24;
    }

    public BasketballPlayerRating? GetNBA2K25Rating()
    {
        return _ratingNBA2K25;
    }

    public BasketballPlayerRating? GetNBA2K26Rating()
    {
        return _ratingNBA2K26;
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

    public void SetNBALive95Rating(BasketballPlayerRating rating)
    {
        _ratingNBALIVE95 = rating;
    }

    public void SetNBALive96Rating(BasketballPlayerRating rating)
    {
        _ratingNBALIVE96 = rating;
    }

    public void SetNBALive97Rating(BasketballPlayerRating rating)
    {
        _ratingNBALIVE97 = rating;
    }

    public void SetNBALive98Rating(BasketballPlayerRating rating)
    {
        _ratingNBALIVE98 = rating;
    }

    public void SetNBALive99Rating(BasketballPlayerRating rating)
    {
        _ratingNBALIVE99 = rating;
    }

    public void SetNBA2KRating(BasketballPlayerRating rating)
    {
        _ratingNBA2K = rating;
    }

    public void SetNBA2K1Rating(BasketballPlayerRating rating)
    {
        _ratingNBA2K1 = rating;
    }

    public void SetNBA2K2Rating(BasketballPlayerRating rating)
    {
        _ratingNBA2K2 = rating;
    }

    public void SetNBA2K3Rating(BasketballPlayerRating rating)
    {
        _ratingNBA2K3 = rating;
    }

    public void SetNBA2K4Rating(BasketballPlayerRating rating)
    {
        _ratingNBA2K4 = rating;
    }

    public void SetNBA2K5Rating(BasketballPlayerRating rating)
    {
        _ratingNBA2K5 = rating;
    }

    public void SetNBA2K6Rating(BasketballPlayerRating rating)
    {
        _ratingNBA2K6 = rating;
    }

    public void SetNBA2K7Rating(BasketballPlayerRating rating)
    {
        _ratingNBA2K7 = rating;
    }

    public void SetNBA2K8Rating(BasketballPlayerRating rating)
    {
        _ratingNBA2K8 = rating;
    }

    public void SetNBA2K9Rating(BasketballPlayerRating rating)
    {
        _ratingNBA2K9 = rating;
    }

    public void SetNBA2K10Rating(BasketballPlayerRating rating)
    {
        _ratingNBA2K10 = rating;
    }

    public void SetNBA2K11Rating(BasketballPlayerRating rating)
    {
        _ratingNBA2K11 = rating;
    }

    public void SetNBA2K12Rating(BasketballPlayerRating rating)
    {
        _ratingNBA2K12 = rating;
    }

    public void SetNBA2K13Rating(BasketballPlayerRating rating)
    {
        _ratingNBA2K13 = rating;
    }

    public void SetNBA2K14Rating(BasketballPlayerRating rating)
    {
        _ratingNBA2K14 = rating;
    }

    public void SetNBA2K15Rating(BasketballPlayerRating rating)
    {
        _ratingNBA2K15 = rating;
    }

    public void SetNBA2K16Rating(BasketballPlayerRating rating)
    {
        _ratingNBA2K16 = rating;
    }

    public void SetNBA2K17Rating(BasketballPlayerRating rating)
    {
        _ratingNBA2K17 = rating;
    }

    public void SetNBA2K18Rating(BasketballPlayerRating rating)
    {
        _ratingNBA2K18 = rating;
    }

    public void SetNBA2K19Rating(BasketballPlayerRating rating)
    {
        _ratingNBA2K19 = rating;
    }

    public void SetNBA2K20Rating(BasketballPlayerRating rating)
    {
        _ratingNBA2K20 = rating;
    }

    public void SetNBA2K21Rating(BasketballPlayerRating rating)
    {
        _ratingNBA2K21 = rating;
    }

    public void SetNBA2K22Rating(BasketballPlayerRating rating)
    {
        _ratingNBA2K22 = rating;
    }

    public void SetNBA2K23Rating(BasketballPlayerRating rating)
    {
        _ratingNBA2K23 = rating;
    }

    public void SetNBA2K24Rating(BasketballPlayerRating rating)
    {
        _ratingNBA2K24 = rating;
    }

    public void SetNBA2K25Rating(BasketballPlayerRating rating)
    {
        _ratingNBA2K25 = rating;
    }

    public void SetNBA2K26Rating(BasketballPlayerRating rating)
    {
        _ratingNBA2K26 = rating;
    }


}