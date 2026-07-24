namespace Domain.Model.AmericanFootball.AmericanFootballPlayer;
using System.ComponentModel.DataAnnotations;
using Domain.Model.Interface;


public class AmericanFootballPlayer : IAmericanFootballPlayer
{


    [Key] private Guid playerId;

    [Required] private string _strName;

    private AmericanFootballPlayerRating? _ratingNFLGAMEDAY98;
    private AmericanFootballPlayerRating? _ratingNFLGAMEDAY99;
    private AmericanFootballPlayerRating? _ratingMADDENNFL2000;
    private AmericanFootballPlayerRating? _ratingMADDENNFL2001;
    private AmericanFootballPlayerRating? _ratingMADDENNFL2002;
    private AmericanFootballPlayerRating? _ratingMADDENNFL2003;
    private AmericanFootballPlayerRating? _ratingMADDENNFL2004;
    private AmericanFootballPlayerRating? _ratingMADDENNFL2005;
    private AmericanFootballPlayerRating? _ratingMADDENNFL06;
    private AmericanFootballPlayerRating? _ratingMADDENNFL07;
    private AmericanFootballPlayerRating? _ratingMADDENNFL08;
    private AmericanFootballPlayerRating? _ratingMADDENNFL09;
    private AmericanFootballPlayerRating? _ratingMADDENNFL10;
    private AmericanFootballPlayerRating? _ratingMADDENNFL11;
    private AmericanFootballPlayerRating? _ratingMADDENNFL12;
    private AmericanFootballPlayerRating? _ratingMADDENNFL13;
    private AmericanFootballPlayerRating? _ratingMADDENNFL14;
    private AmericanFootballPlayerRating? _ratingMADDENNFL15;
    private AmericanFootballPlayerRating? _ratingMADDENNFL16;
    private AmericanFootballPlayerRating? _ratingMADDENNFL17;
    private AmericanFootballPlayerRating? _ratingMADDENNFL18;
    private AmericanFootballPlayerRating? _ratingMADDENNFL19;
    private AmericanFootballPlayerRating? _ratingMADDENNFL20;
    private AmericanFootballPlayerRating? _ratingMADDENNFL21;
    private AmericanFootballPlayerRating? _ratingMADDENNFL22;
    private AmericanFootballPlayerRating? _ratingMADDENNFL23;
    private AmericanFootballPlayerRating? _ratingMADDENNFL24;
    private AmericanFootballPlayerRating? _ratingMADDENNFL25;
    private AmericanFootballPlayerRating? _ratingMADDENNFL26;

    public Guid PlayerId
    {
        get { return playerId; }
        set { playerId = value; }
    }

    public string PlayerName
    {
        get { return _strName; }
    }

    public AmericanFootballPlayerRating? NFLGameday98Rating
    {
        get { return _ratingNFLGAMEDAY98; }
    }

    public AmericanFootballPlayerRating? NFLGameday99Rating
    {
        get { return _ratingNFLGAMEDAY99; }
    }

    public AmericanFootballPlayerRating? MaddenNFL2000Rating
    {
        get { return _ratingMADDENNFL2000; }
    }

    public AmericanFootballPlayerRating? MaddenNFL2001Rating
    {
        get { return _ratingMADDENNFL2001; }
    }

    public AmericanFootballPlayerRating? MaddenNFL2002Rating
    {
        get { return _ratingMADDENNFL2002; }
    }

    public AmericanFootballPlayerRating? MaddenNFL2003Rating
    {
        get { return _ratingMADDENNFL2003; }
    }

    public AmericanFootballPlayerRating? MaddenNFL2004Rating
    {
        get { return _ratingMADDENNFL2004; }
    }

    public AmericanFootballPlayerRating? MaddenNFL2005Rating
    {
        get { return _ratingMADDENNFL2005; }
    }

    public AmericanFootballPlayerRating? MaddenNFL06Rating
    {
        get { return _ratingMADDENNFL06; }
    }

    public AmericanFootballPlayerRating? MaddenNFL07Rating
    {
        get { return _ratingMADDENNFL07; }
    }

    public AmericanFootballPlayerRating? MaddenNFL08Rating
    {
        get { return _ratingMADDENNFL08; }
    }

    public AmericanFootballPlayerRating? MaddenNFL09Rating
    {
        get { return _ratingMADDENNFL09; }
    }

    public AmericanFootballPlayerRating? MaddenNFL10Rating
    {
        get { return _ratingMADDENNFL10; }
    }

    public AmericanFootballPlayerRating? MaddenNFL11Rating
    {
        get { return _ratingMADDENNFL11; }
    }

    public AmericanFootballPlayerRating? MaddenNFL12Rating
    {
        get { return _ratingMADDENNFL12; }
    }

    public AmericanFootballPlayerRating? MaddenNFL13Rating
    {
        get { return _ratingMADDENNFL13; }
    }

    public AmericanFootballPlayerRating? MaddenNFL14Rating
    {
        get { return _ratingMADDENNFL14; }
    }

    public AmericanFootballPlayerRating? MaddenNFL15Rating
    {
        get { return _ratingMADDENNFL15; }
    }

    public AmericanFootballPlayerRating? MaddenNFL16Rating
    {
        get { return _ratingMADDENNFL16; }
    }

    public AmericanFootballPlayerRating? MaddenNFL17Rating
    {
        get { return _ratingMADDENNFL17; }
    }

    public AmericanFootballPlayerRating? MaddenNFL18Rating
    {
        get { return _ratingMADDENNFL18; }
    }

    public AmericanFootballPlayerRating? MaddenNFL19Rating
    {
        get { return _ratingMADDENNFL19; }
    }

    public AmericanFootballPlayerRating? MaddenNFL20Rating
    {
        get { return _ratingMADDENNFL20; }
    }

    public AmericanFootballPlayerRating? MaddenNFL21Rating
    {
        get { return _ratingMADDENNFL21; }
    }

    public AmericanFootballPlayerRating? MaddenNFL22Rating
    {
        get { return _ratingMADDENNFL22; }
    }

    public AmericanFootballPlayerRating? MaddenNFL23Rating
    {
        get { return _ratingMADDENNFL23; }
    }

    public AmericanFootballPlayerRating? MaddenNFL24Rating
    {
        get { return _ratingMADDENNFL24; }
    }

    public AmericanFootballPlayerRating? MaddenNFL25Rating
    {
        get { return _ratingMADDENNFL25; }
    }

    public AmericanFootballPlayerRating? MaddenNFL26Rating
    {
        get { return _ratingMADDENNFL26; }
    }


    // ----------------------------------------Constructor-----------------------------------------
    public AmericanFootballPlayer()
    {
    }

    public AmericanFootballPlayer(
        Guid id,
        string playerName,
        AmericanFootballPlayerRating? ratingNFLGameday98 = null,
        AmericanFootballPlayerRating? ratingNFLGameday99 = null,
        AmericanFootballPlayerRating? ratingMaddenNFL2000 = null,
        AmericanFootballPlayerRating? ratingMaddenNFL2001 = null,
        AmericanFootballPlayerRating? ratingMaddenNFL2002 = null,
        AmericanFootballPlayerRating? ratingMaddenNFL2003 = null,
        AmericanFootballPlayerRating? ratingMaddenNFL2004 = null,
        AmericanFootballPlayerRating? ratingMaddenNFL2005 = null,
        AmericanFootballPlayerRating? ratingMaddenNFL06 = null,
        AmericanFootballPlayerRating? ratingMaddenNFL07 = null,
        AmericanFootballPlayerRating? ratingMaddenNFL08 = null,
        AmericanFootballPlayerRating? ratingMaddenNFL09 = null,
        AmericanFootballPlayerRating? ratingMaddenNFL10 = null,
        AmericanFootballPlayerRating? ratingMaddenNFL11 = null,
        AmericanFootballPlayerRating? ratingMaddenNFL12 = null,
        AmericanFootballPlayerRating? ratingMaddenNFL13 = null,
        AmericanFootballPlayerRating? ratingMaddenNFL14 = null,
        AmericanFootballPlayerRating? ratingMaddenNFL15 = null,
        AmericanFootballPlayerRating? ratingMaddenNFL16 = null,
        AmericanFootballPlayerRating? ratingMaddenNFL17 = null,
        AmericanFootballPlayerRating? ratingMaddenNFL18 = null,
        AmericanFootballPlayerRating? ratingMaddenNFL19 = null,
        AmericanFootballPlayerRating? ratingMaddenNFL20 = null,
        AmericanFootballPlayerRating? ratingMaddenNFL21 = null,
        AmericanFootballPlayerRating? ratingMaddenNFL22 = null,
        AmericanFootballPlayerRating? ratingMaddenNFL23 = null,
        AmericanFootballPlayerRating? ratingMaddenNFL24 = null,
        AmericanFootballPlayerRating? ratingMaddenNFL25 = null,
        AmericanFootballPlayerRating? ratingMaddenNFL26 = null)
    {
            playerId = id;
            _strName = playerName;
            _ratingNFLGAMEDAY98 = ratingNFLGameday98;
            _ratingNFLGAMEDAY99 = ratingNFLGameday99;
            _ratingMADDENNFL2000 = ratingMaddenNFL2000;
            _ratingMADDENNFL2001 = ratingMaddenNFL2001;
            _ratingMADDENNFL2002 = ratingMaddenNFL2002;
            _ratingMADDENNFL2003 = ratingMaddenNFL2003;
            _ratingMADDENNFL2004 = ratingMaddenNFL2004;
            _ratingMADDENNFL2005 = ratingMaddenNFL2005;
            _ratingMADDENNFL06 = ratingMaddenNFL06;
            _ratingMADDENNFL07 = ratingMaddenNFL07;
            _ratingMADDENNFL08 = ratingMaddenNFL08;
            _ratingMADDENNFL09 = ratingMaddenNFL09;
            _ratingMADDENNFL10 = ratingMaddenNFL10;
            _ratingMADDENNFL11 = ratingMaddenNFL11;
            _ratingMADDENNFL12 = ratingMaddenNFL12;
            _ratingMADDENNFL13 = ratingMaddenNFL13;
            _ratingMADDENNFL14 = ratingMaddenNFL14;
            _ratingMADDENNFL15 = ratingMaddenNFL15;
            _ratingMADDENNFL16 = ratingMaddenNFL16;
            _ratingMADDENNFL17 = ratingMaddenNFL17;
            _ratingMADDENNFL18 = ratingMaddenNFL18;
            _ratingMADDENNFL19 = ratingMaddenNFL19;
            _ratingMADDENNFL20 = ratingMaddenNFL20;
            _ratingMADDENNFL21 = ratingMaddenNFL21;
            _ratingMADDENNFL22 = ratingMaddenNFL22;
            _ratingMADDENNFL23 = ratingMaddenNFL23;
            _ratingMADDENNFL24 = ratingMaddenNFL24;
            _ratingMADDENNFL25 = ratingMaddenNFL25;
            _ratingMADDENNFL26 = ratingMaddenNFL26;
        
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

    public AmericanFootballPlayerRating? GetNFLGameday98Rating()
    {
        return _ratingNFLGAMEDAY98;
    }

    public AmericanFootballPlayerRating? GetNFLGameday99Rating()
    {
        return _ratingNFLGAMEDAY99;
    }

    public AmericanFootballPlayerRating? GetMaddenNFL2000Rating()
    {
        return _ratingMADDENNFL2000;
    }

    public AmericanFootballPlayerRating? GetMaddenNFL2001Rating()
    {
        return _ratingMADDENNFL2001;
    }

    public AmericanFootballPlayerRating? GetMaddenNFL2002Rating()
    {
        return _ratingMADDENNFL2002;
    }

    public AmericanFootballPlayerRating? GetMaddenNFL2003Rating()
    {
        return _ratingMADDENNFL2003;
    }

    public AmericanFootballPlayerRating? GetMaddenNFL2004Rating()
    {
        return _ratingMADDENNFL2004;
    }

    public AmericanFootballPlayerRating? GetMaddenNFL2005Rating()
    {
        return _ratingMADDENNFL2005;
    }

    public AmericanFootballPlayerRating? GetMaddenNFL06Rating()
    {
        return _ratingMADDENNFL06;
    }

    public AmericanFootballPlayerRating? GetMaddenNFL07Rating()
    {
        return _ratingMADDENNFL07;
    }

    public AmericanFootballPlayerRating? GetMaddenNFL08Rating()
    {
        return _ratingMADDENNFL08;
    }

    public AmericanFootballPlayerRating? GetMaddenNFL09Rating()
    {
        return _ratingMADDENNFL09;
    }

    public AmericanFootballPlayerRating? GetMaddenNFL10Rating()
    {
        return _ratingMADDENNFL10;
    }

    public AmericanFootballPlayerRating? GetMaddenNFL11Rating()
    {
        return _ratingMADDENNFL11;
    }

    public AmericanFootballPlayerRating? GetMaddenNFL12Rating()
    {
        return _ratingMADDENNFL12;
    }

    public AmericanFootballPlayerRating? GetMaddenNFL13Rating()
    {
        return _ratingMADDENNFL13;
    }

    public AmericanFootballPlayerRating? GetMaddenNFL14Rating()
    {
        return _ratingMADDENNFL14;
    }

    public AmericanFootballPlayerRating? GetMaddenNFL15Rating()
    {
        return _ratingMADDENNFL15;
    }

    public AmericanFootballPlayerRating? GetMaddenNFL16Rating()
    {
        return _ratingMADDENNFL16;
    }

    public AmericanFootballPlayerRating? GetMaddenNFL17Rating()
    {
        return _ratingMADDENNFL17;
    }

    public AmericanFootballPlayerRating? GetMaddenNFL18Rating()
    {
        return _ratingMADDENNFL18;
    }

    public AmericanFootballPlayerRating? GetMaddenNFL19Rating()
    {
        return _ratingMADDENNFL19;
    }

    public AmericanFootballPlayerRating? GetMaddenNFL20Rating()
    {
        return _ratingMADDENNFL20;
    }

    public AmericanFootballPlayerRating? GetMaddenNFL21Rating()
    {
        return _ratingMADDENNFL21;
    }

    public AmericanFootballPlayerRating? GetMaddenNFL22Rating()
    {
        return _ratingMADDENNFL22;
    }

    public AmericanFootballPlayerRating? GetMaddenNFL23Rating()
    {
        return _ratingMADDENNFL23;
    }

    public AmericanFootballPlayerRating? GetMaddenNFL24Rating()
    {
        return _ratingMADDENNFL24;
    }

    public AmericanFootballPlayerRating? GetMaddenNFL25Rating()
    {
        return _ratingMADDENNFL25;
    }

    public AmericanFootballPlayerRating? GetMaddenNFL26Rating()
    {
        return _ratingMADDENNFL26;
    }


    // ----------------------------------------Setters-----------------------------------------

    public void SetPlayerName(string playerName)
    {
        _strName = playerName;
    }

    public void SetNFLGameday98Rating(AmericanFootballPlayerRating rating)
    {
        _ratingNFLGAMEDAY98 = rating;
    }

    public void SetNFLGameday99Rating(AmericanFootballPlayerRating rating)
    {
        _ratingNFLGAMEDAY99 = rating;
    }

    public void SetMaddenNFL2000Rating(AmericanFootballPlayerRating rating)
    {
        _ratingMADDENNFL2000 = rating;
    }

    public void SetMaddenNFL2001Rating(AmericanFootballPlayerRating rating)
    {
        _ratingMADDENNFL2001 = rating;
    }

    public void SetMaddenNFL2002Rating(AmericanFootballPlayerRating rating)
    {
        _ratingMADDENNFL2002 = rating;
    }

    public void SetMaddenNFL2003Rating(AmericanFootballPlayerRating rating)
    {
        _ratingMADDENNFL2003 = rating;
    }

    public void SetMaddenNFL2004Rating(AmericanFootballPlayerRating rating)
    {
        _ratingMADDENNFL2004 = rating;
    }

    public void SetMaddenNFL2005Rating(AmericanFootballPlayerRating rating)
    {
        _ratingMADDENNFL2005 = rating;
    }

    public void SetMaddenNFL06Rating(AmericanFootballPlayerRating rating)
    {
        _ratingMADDENNFL06 = rating;
    }

    public void SetMaddenNFL07Rating(AmericanFootballPlayerRating rating)
    {
        _ratingMADDENNFL07 = rating;
    }

    public void SetMaddenNFL08Rating(AmericanFootballPlayerRating rating)
    {
        _ratingMADDENNFL08 = rating;
    }

    public void SetMaddenNFL09Rating(AmericanFootballPlayerRating rating)
    {
        _ratingMADDENNFL09 = rating;
    }

    public void SetMaddenNFL10Rating(AmericanFootballPlayerRating rating)
    {
        _ratingMADDENNFL10 = rating;
    }

    public void SetMaddenNFL11Rating(AmericanFootballPlayerRating rating)
    {
        _ratingMADDENNFL11 = rating;
    }

    public void SetMaddenNFL12Rating(AmericanFootballPlayerRating rating)
    {
        _ratingMADDENNFL12 = rating;
    }

    public void SetMaddenNFL13Rating(AmericanFootballPlayerRating rating)
    {
        _ratingMADDENNFL13 = rating;
    }

    public void SetMaddenNFL14Rating(AmericanFootballPlayerRating rating)
    {
        _ratingMADDENNFL14 = rating;
    }

    public void SetMaddenNFL15Rating(AmericanFootballPlayerRating rating)
    {
        _ratingMADDENNFL15 = rating;
    }

    public void SetMaddenNFL16Rating(AmericanFootballPlayerRating rating)
    {
        _ratingMADDENNFL16 = rating;
    }

    public void SetMaddenNFL17Rating(AmericanFootballPlayerRating rating)
    {
        _ratingMADDENNFL17 = rating;
    }

    public void SetMaddenNFL18Rating(AmericanFootballPlayerRating rating)
    {
        _ratingMADDENNFL18 = rating;
    }

    public void SetMaddenNFL19Rating(AmericanFootballPlayerRating rating)
    {
        _ratingMADDENNFL19 = rating;
    }

    public void SetMaddenNFL20Rating(AmericanFootballPlayerRating rating)
    {
        _ratingMADDENNFL20 = rating;
    }

    public void SetMaddenNFL21Rating(AmericanFootballPlayerRating rating)
    {
        _ratingMADDENNFL21 = rating;
    }

    public void SetMaddenNFL22Rating(AmericanFootballPlayerRating rating)
    {
        _ratingMADDENNFL22 = rating;
    }

    public void SetMaddenNFL23Rating(AmericanFootballPlayerRating rating)
    {
        _ratingMADDENNFL23 = rating;
    }

    public void SetMaddenNFL24Rating(AmericanFootballPlayerRating rating)
    {
        _ratingMADDENNFL24 = rating;
    }

    public void SetMaddenNFL25Rating(AmericanFootballPlayerRating rating)
    {
        _ratingMADDENNFL25 = rating;
    }

    public void SetMaddenNFL26Rating(AmericanFootballPlayerRating rating)
    {
        _ratingMADDENNFL26 = rating;
    }


}