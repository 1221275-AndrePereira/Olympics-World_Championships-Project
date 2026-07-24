using DataModel.Model;

namespace DataModel.Mapper;

using Domain.Factory.Interface;
using Domain.Model.Basketball.BasketballPlayer;

public class BasketballPlayerMapper
{
    private IBasketballPlayerFactory _basketballPlayerFactory;

    public BasketballPlayerMapper(IBasketballPlayerFactory basketballPlayerFactory)
    {
        _basketballPlayerFactory = basketballPlayerFactory;
    }

    public BasketballPlayer ToDomain(BasketballPlayerDataModel basketballPlayerDm)
    {

        
        BasketballPlayer basketballPlayer = _basketballPlayerFactory.newBasketballPlayer(basketballPlayerDm.PlayerId,
            basketballPlayerDm.PlayerName,
            basketballPlayerDm.Country,
            basketballPlayerDm.NBALive95Rating,
            basketballPlayerDm.NBALive96Rating,
            basketballPlayerDm.NBALive97Rating,
            basketballPlayerDm.NBALive98Rating,
            basketballPlayerDm.NBALive99Rating,
            basketballPlayerDm.NBA2KRating,
            basketballPlayerDm.NBA2K1Rating,
            basketballPlayerDm.NBA2K2Rating,
            basketballPlayerDm.NBA2K3Rating,
            basketballPlayerDm.NBA2K4Rating,
            basketballPlayerDm.NBA2K5Rating,
            basketballPlayerDm.NBA2K6Rating,
            basketballPlayerDm.NBA2K7Rating,
            basketballPlayerDm.NBA2K8Rating,
            basketballPlayerDm.NBA2K9Rating,
            basketballPlayerDm.NBA2K10Rating,
            basketballPlayerDm.NBA2K11Rating,
            basketballPlayerDm.NBA2K12Rating,
            basketballPlayerDm.NBA2K13Rating,
            basketballPlayerDm.NBA2K14Rating,
            basketballPlayerDm.NBA2K15Rating,
            basketballPlayerDm.NBA2K16Rating,
            basketballPlayerDm.NBA2K17Rating,
            basketballPlayerDm.NBA2K18Rating,
            basketballPlayerDm.NBA2K19Rating,
            basketballPlayerDm.NBA2K20Rating,
            basketballPlayerDm.NBA2K21Rating,
            basketballPlayerDm.NBA2K22Rating,
            basketballPlayerDm.NBA2K23Rating,
            basketballPlayerDm.NBA2K24Rating,
            basketballPlayerDm.NBA2K25Rating,
            basketballPlayerDm.NBA2K26Rating);
        return basketballPlayer;
    }

    public IEnumerable<BasketballPlayer> ToDomain(IEnumerable<BasketballPlayerDataModel> basketballPlayerDm)
    {
        List<BasketballPlayer> basketballPlayersDomain = new List<BasketballPlayer>();

        foreach (BasketballPlayerDataModel basketballPlayerDataModel in basketballPlayerDm)
        {
            BasketballPlayer basketballPlayerDomain = ToDomain(basketballPlayerDataModel);

            basketballPlayersDomain.Add(basketballPlayerDomain);
        }

        return basketballPlayersDomain;
    }

    public BasketballPlayerDataModel ToDataModel(BasketballPlayer basketballPlayerDm)
    {
        BasketballPlayerDataModel basketballPlayerDataModel = new BasketballPlayerDataModel(basketballPlayerDm);

        return basketballPlayerDataModel;
    }

    public bool UpdateDataModel(BasketballPlayerDataModel basketballPlayerDataModel, BasketballPlayer basketballPlayerDomain)
    {
        basketballPlayerDataModel.PlayerName = basketballPlayerDomain.PlayerName;
        basketballPlayerDataModel.Country = basketballPlayerDomain.Country;
        basketballPlayerDataModel.NBALive95Rating = basketballPlayerDomain.NBALive95Rating;
        basketballPlayerDataModel.NBALive96Rating = basketballPlayerDomain.NBALive96Rating;
        basketballPlayerDataModel.NBALive97Rating = basketballPlayerDomain.NBALive97Rating;
        basketballPlayerDataModel.NBALive98Rating = basketballPlayerDomain.NBALive98Rating;
        basketballPlayerDataModel.NBALive99Rating = basketballPlayerDomain.NBALive99Rating;
        basketballPlayerDataModel.NBA2KRating = basketballPlayerDomain.NBA2KRating;
        basketballPlayerDataModel.NBA2K1Rating = basketballPlayerDomain.NBA2K1Rating;
        basketballPlayerDataModel.NBA2K2Rating = basketballPlayerDomain.NBA2K2Rating;
        basketballPlayerDataModel.NBA2K3Rating = basketballPlayerDomain.NBA2K3Rating;
        basketballPlayerDataModel.NBA2K4Rating = basketballPlayerDomain.NBA2K4Rating;
        basketballPlayerDataModel.NBA2K5Rating = basketballPlayerDomain.NBA2K5Rating;
        basketballPlayerDataModel.NBA2K6Rating = basketballPlayerDomain.NBA2K6Rating;
        basketballPlayerDataModel.NBA2K7Rating = basketballPlayerDomain.NBA2K7Rating;
        basketballPlayerDataModel.NBA2K8Rating = basketballPlayerDomain.NBA2K8Rating;
        basketballPlayerDataModel.NBA2K9Rating = basketballPlayerDomain.NBA2K9Rating;
        basketballPlayerDataModel.NBA2K10Rating = basketballPlayerDomain.NBA2K10Rating;
        basketballPlayerDataModel.NBA2K11Rating = basketballPlayerDomain.NBA2K11Rating;
        basketballPlayerDataModel.NBA2K12Rating = basketballPlayerDomain.NBA2K12Rating;
        basketballPlayerDataModel.NBA2K13Rating = basketballPlayerDomain.NBA2K13Rating;
        basketballPlayerDataModel.NBA2K14Rating = basketballPlayerDomain.NBA2K14Rating;
        basketballPlayerDataModel.NBA2K15Rating = basketballPlayerDomain.NBA2K15Rating;
        basketballPlayerDataModel.NBA2K16Rating = basketballPlayerDomain.NBA2K16Rating;
        basketballPlayerDataModel.NBA2K17Rating = basketballPlayerDomain.NBA2K17Rating;
        basketballPlayerDataModel.NBA2K18Rating = basketballPlayerDomain.NBA2K18Rating;
        basketballPlayerDataModel.NBA2K19Rating = basketballPlayerDomain.NBA2K19Rating;
        basketballPlayerDataModel.NBA2K20Rating = basketballPlayerDomain.NBA2K20Rating;
        basketballPlayerDataModel.NBA2K21Rating = basketballPlayerDomain.NBA2K21Rating;
        basketballPlayerDataModel.NBA2K22Rating = basketballPlayerDomain.NBA2K22Rating;
        basketballPlayerDataModel.NBA2K23Rating = basketballPlayerDomain.NBA2K23Rating;
        basketballPlayerDataModel.NBA2K24Rating = basketballPlayerDomain.NBA2K24Rating;
        basketballPlayerDataModel.NBA2K25Rating = basketballPlayerDomain.NBA2K25Rating;
        basketballPlayerDataModel.NBA2K26Rating = basketballPlayerDomain.NBA2K26Rating;

        return true;
    }
}