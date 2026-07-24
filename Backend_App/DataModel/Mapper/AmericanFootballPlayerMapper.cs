using DataModel.Model;

namespace DataModel.Mapper;

using Domain.Factory.Interface;
using Domain.Model.AmericanFootball.AmericanFootballPlayer;

public class AmericanFootballPlayerMapper
{
    private IAmericanFootballPlayerFactory _americanFootballPlayerFactory;

    public AmericanFootballPlayerMapper(IAmericanFootballPlayerFactory americanFootballPlayerFactory)
    {
        _americanFootballPlayerFactory = americanFootballPlayerFactory;
    }

    public AmericanFootballPlayer ToDomain(AmericanFootballPlayerDataModel americanFootballPlayerDm)
    {

        
        AmericanFootballPlayer americanFootballPlayer = _americanFootballPlayerFactory.newAmericanFootballPlayer(americanFootballPlayerDm.PlayerId,
            americanFootballPlayerDm.PlayerName,
            americanFootballPlayerDm.NFLGameday98Rating,
            americanFootballPlayerDm.NFLGameday99Rating,
            americanFootballPlayerDm.MaddenNFL2000Rating,
            americanFootballPlayerDm.MaddenNFL2001Rating,
            americanFootballPlayerDm.MaddenNFL2002Rating,
            americanFootballPlayerDm.MaddenNFL2003Rating,
            americanFootballPlayerDm.MaddenNFL2004Rating,
            americanFootballPlayerDm.MaddenNFL2005Rating,
            americanFootballPlayerDm.MaddenNFL06Rating,
            americanFootballPlayerDm.MaddenNFL07Rating,
            americanFootballPlayerDm.MaddenNFL08Rating,
            americanFootballPlayerDm.MaddenNFL09Rating,
            americanFootballPlayerDm.MaddenNFL10Rating,
            americanFootballPlayerDm.MaddenNFL11Rating,
            americanFootballPlayerDm.MaddenNFL12Rating,
            americanFootballPlayerDm.MaddenNFL13Rating,
            americanFootballPlayerDm.MaddenNFL14Rating,
            americanFootballPlayerDm.MaddenNFL15Rating,
            americanFootballPlayerDm.MaddenNFL16Rating,
            americanFootballPlayerDm.MaddenNFL17Rating,
            americanFootballPlayerDm.MaddenNFL18Rating,
            americanFootballPlayerDm.MaddenNFL19Rating,
            americanFootballPlayerDm.MaddenNFL20Rating,
            americanFootballPlayerDm.MaddenNFL21Rating,
            americanFootballPlayerDm.MaddenNFL22Rating,
            americanFootballPlayerDm.MaddenNFL23Rating,
            americanFootballPlayerDm.MaddenNFL24Rating,
            americanFootballPlayerDm.MaddenNFL25Rating,
            americanFootballPlayerDm.MaddenNFL26Rating);
        return americanFootballPlayer;
    }

    public IEnumerable<AmericanFootballPlayer> ToDomain(IEnumerable<AmericanFootballPlayerDataModel> americanFootballPlayerDm)
    {
        List<AmericanFootballPlayer> americanFootballPlayersDomain = new List<AmericanFootballPlayer>();

        foreach (AmericanFootballPlayerDataModel americanFootballPlayerDataModel in americanFootballPlayerDm)
        {
            AmericanFootballPlayer americanFootballPlayerDomain = ToDomain(americanFootballPlayerDataModel);

            americanFootballPlayersDomain.Add(americanFootballPlayerDomain);
        }

        return americanFootballPlayersDomain;
    }

    public AmericanFootballPlayerDataModel ToDataModel(AmericanFootballPlayer americanFootballPlayerDm)
    {
        AmericanFootballPlayerDataModel americanFootballPlayerDataModel = new AmericanFootballPlayerDataModel(americanFootballPlayerDm);

        return americanFootballPlayerDataModel;
    }

    public bool UpdateDataModel(AmericanFootballPlayerDataModel americanFootballPlayerDataModel, AmericanFootballPlayer americanFootballPlayerDomain)
    {
        americanFootballPlayerDataModel.PlayerName = americanFootballPlayerDomain.PlayerName;
        americanFootballPlayerDataModel.NFLGameday98Rating = americanFootballPlayerDomain.NFLGameday98Rating;
        americanFootballPlayerDataModel.NFLGameday99Rating = americanFootballPlayerDomain.NFLGameday99Rating;
        americanFootballPlayerDataModel.MaddenNFL2000Rating = americanFootballPlayerDomain.MaddenNFL2000Rating;
        americanFootballPlayerDataModel.MaddenNFL2001Rating = americanFootballPlayerDomain.MaddenNFL2001Rating;
        americanFootballPlayerDataModel.MaddenNFL2002Rating = americanFootballPlayerDomain.MaddenNFL2002Rating;
        americanFootballPlayerDataModel.MaddenNFL2003Rating = americanFootballPlayerDomain.MaddenNFL2003Rating;
        americanFootballPlayerDataModel.MaddenNFL2004Rating = americanFootballPlayerDomain.MaddenNFL2004Rating;
        americanFootballPlayerDataModel.MaddenNFL2005Rating = americanFootballPlayerDomain.MaddenNFL2005Rating;
        americanFootballPlayerDataModel.MaddenNFL06Rating = americanFootballPlayerDomain.MaddenNFL06Rating;
        americanFootballPlayerDataModel.MaddenNFL07Rating = americanFootballPlayerDomain.MaddenNFL07Rating;
        americanFootballPlayerDataModel.MaddenNFL08Rating = americanFootballPlayerDomain.MaddenNFL08Rating;
        americanFootballPlayerDataModel.MaddenNFL09Rating = americanFootballPlayerDomain.MaddenNFL09Rating;
        americanFootballPlayerDataModel.MaddenNFL10Rating = americanFootballPlayerDomain.MaddenNFL10Rating;
        americanFootballPlayerDataModel.MaddenNFL11Rating = americanFootballPlayerDomain.MaddenNFL11Rating;
        americanFootballPlayerDataModel.MaddenNFL12Rating = americanFootballPlayerDomain.MaddenNFL12Rating;
        americanFootballPlayerDataModel.MaddenNFL13Rating = americanFootballPlayerDomain.MaddenNFL13Rating;
        americanFootballPlayerDataModel.MaddenNFL14Rating = americanFootballPlayerDomain.MaddenNFL14Rating;
        americanFootballPlayerDataModel.MaddenNFL15Rating = americanFootballPlayerDomain.MaddenNFL15Rating;
        americanFootballPlayerDataModel.MaddenNFL16Rating = americanFootballPlayerDomain.MaddenNFL16Rating;
        americanFootballPlayerDataModel.MaddenNFL17Rating = americanFootballPlayerDomain.MaddenNFL17Rating;
        americanFootballPlayerDataModel.MaddenNFL18Rating = americanFootballPlayerDomain.MaddenNFL18Rating;
        americanFootballPlayerDataModel.MaddenNFL19Rating = americanFootballPlayerDomain.MaddenNFL19Rating;
        americanFootballPlayerDataModel.MaddenNFL20Rating = americanFootballPlayerDomain.MaddenNFL20Rating;
        americanFootballPlayerDataModel.MaddenNFL21Rating = americanFootballPlayerDomain.MaddenNFL21Rating;
        americanFootballPlayerDataModel.MaddenNFL22Rating = americanFootballPlayerDomain.MaddenNFL22Rating;
        americanFootballPlayerDataModel.MaddenNFL23Rating = americanFootballPlayerDomain.MaddenNFL23Rating;
        americanFootballPlayerDataModel.MaddenNFL24Rating = americanFootballPlayerDomain.MaddenNFL24Rating;
        americanFootballPlayerDataModel.MaddenNFL25Rating = americanFootballPlayerDomain.MaddenNFL25Rating;
        americanFootballPlayerDataModel.MaddenNFL26Rating = americanFootballPlayerDomain.MaddenNFL26Rating;
        return true;
    }
}