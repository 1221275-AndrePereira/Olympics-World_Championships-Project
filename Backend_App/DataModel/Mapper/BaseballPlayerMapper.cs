using DataModel.Model;

namespace DataModel.Mapper;

using Domain.Factory.Interface;
using Domain.Model.Baseball.BaseballPlayer;

public class BaseballPlayerMapper
{
    private IBaseballPlayerFactory _baseballPlayerFactory;

    public BaseballPlayerMapper(IBaseballPlayerFactory baseballPlayerFactory)
    {
        _baseballPlayerFactory = baseballPlayerFactory;
    }

    public BaseballPlayer ToDomain(BaseballPlayerDataModel baseballPlayerDm)
    {

        
        BaseballPlayer baseballPlayer = _baseballPlayerFactory.newBaseballPlayer(baseballPlayerDm.PlayerId,
            baseballPlayerDm.PlayerName,
            baseballPlayerDm.Country,
            baseballPlayerDm.MLBTriplePlay99Rating,
            baseballPlayerDm.MLBTriplePlay2000Rating,
            baseballPlayerDm.MLBTriplePlay2001Rating,
            baseballPlayerDm.MLBTriplePlayBaseballRating,
            baseballPlayerDm.MLBTriplePlay2002Rating,
            baseballPlayerDm.MLB2004Rating,
            baseballPlayerDm.MLBESPNRating,
            baseballPlayerDm.MLB2K5Rating,
            baseballPlayerDm.MLB2K6Rating,
            baseballPlayerDm.MLB2K7Rating,
            baseballPlayerDm.MLB2K8Rating,
            baseballPlayerDm.MLB2K9Rating,
            baseballPlayerDm.MLB2K10Rating,
            baseballPlayerDm.MLB2K11Rating,
            baseballPlayerDm.MLB2K12Rating,
            baseballPlayerDm.MLBTheShow13Rating,
            baseballPlayerDm.MLBTheShow14Rating,
            baseballPlayerDm.MLBTheShow15Rating,
            baseballPlayerDm.MLBTheShow16Rating,
            baseballPlayerDm.MLBTheShow17Rating,
            baseballPlayerDm.MLBTheShow18Rating,
            baseballPlayerDm.MLBTheShow19Rating,
            baseballPlayerDm.MLBTheShow20Rating,
            baseballPlayerDm.MLBTheShow21Rating,
            baseballPlayerDm.MLBTheShow22Rating,
            baseballPlayerDm.MLBTheShow23Rating,
            baseballPlayerDm.MLBTheShow24Rating,
            baseballPlayerDm.MLBTheShow25Rating);
        return baseballPlayer;
    }

    public IEnumerable<BaseballPlayer> ToDomain(IEnumerable<BaseballPlayerDataModel> baseballPlayerDm)
    {
        List<BaseballPlayer> baseballPlayersDomain = new List<BaseballPlayer>();

        foreach (BaseballPlayerDataModel baseballPlayerDataModel in baseballPlayerDm)
        {
            BaseballPlayer baseballPlayerDomain = ToDomain(baseballPlayerDataModel);

            baseballPlayersDomain.Add(baseballPlayerDomain);
        }

        return baseballPlayersDomain;
    }

    public BaseballPlayerDataModel ToDataModel(BaseballPlayer baseballPlayerDm)
    {
        BaseballPlayerDataModel baseballPlayerDataModel = new BaseballPlayerDataModel(baseballPlayerDm);

        return baseballPlayerDataModel;
    }

    public bool UpdateDataModel(BaseballPlayerDataModel baseballPlayerDataModel, BaseballPlayer baseballPlayerDomain)
    {
        baseballPlayerDataModel.PlayerName = baseballPlayerDomain.PlayerName;
        baseballPlayerDataModel.Country = baseballPlayerDomain.Country;
        baseballPlayerDataModel.MLBTriplePlay99Rating = baseballPlayerDomain.MLBTriplePlay99Rating;
        baseballPlayerDataModel.MLBTriplePlay2000Rating = baseballPlayerDomain.MLBTriplePlay2000Rating;
        baseballPlayerDataModel.MLBTriplePlay2001Rating = baseballPlayerDomain.MLBTriplePlay2001Rating;
        baseballPlayerDataModel.MLBTriplePlayBaseballRating = baseballPlayerDomain.MLBTriplePlayBaseballRating;
        baseballPlayerDataModel.MLBTriplePlay2002Rating = baseballPlayerDomain.MLBTriplePlay2002Rating;
        baseballPlayerDataModel.MLB2004Rating = baseballPlayerDomain.MLB2004Rating;
        baseballPlayerDataModel.MLBESPNRating = baseballPlayerDomain.MLBESPNRating;
        baseballPlayerDataModel.MLB2K5Rating = baseballPlayerDomain.MLB2K5Rating;
        baseballPlayerDataModel.MLB2K6Rating = baseballPlayerDomain.MLB2K6Rating;
        baseballPlayerDataModel.MLB2K7Rating = baseballPlayerDomain.MLB2K7Rating;
        baseballPlayerDataModel.MLB2K8Rating = baseballPlayerDomain.MLB2K8Rating;
        baseballPlayerDataModel.MLB2K9Rating = baseballPlayerDomain.MLB2K9Rating;
        baseballPlayerDataModel.MLB2K10Rating = baseballPlayerDomain.MLB2K10Rating;
        baseballPlayerDataModel.MLB2K11Rating = baseballPlayerDomain.MLB2K11Rating;
        baseballPlayerDataModel.MLB2K12Rating = baseballPlayerDomain.MLB2K12Rating;
        baseballPlayerDataModel.MLBTheShow13Rating = baseballPlayerDomain.MLBTheShow13Rating;
        baseballPlayerDataModel.MLBTheShow14Rating = baseballPlayerDomain.MLBTheShow14Rating;
        baseballPlayerDataModel.MLBTheShow15Rating = baseballPlayerDomain.MLBTheShow15Rating;
        baseballPlayerDataModel.MLBTheShow16Rating = baseballPlayerDomain.MLBTheShow16Rating;
        baseballPlayerDataModel.MLBTheShow17Rating = baseballPlayerDomain.MLBTheShow17Rating;
        baseballPlayerDataModel.MLBTheShow18Rating = baseballPlayerDomain.MLBTheShow18Rating;
        baseballPlayerDataModel.MLBTheShow19Rating = baseballPlayerDomain.MLBTheShow19Rating;
        baseballPlayerDataModel.MLBTheShow20Rating = baseballPlayerDomain.MLBTheShow20Rating;
        baseballPlayerDataModel.MLBTheShow21Rating = baseballPlayerDomain.MLBTheShow21Rating;
        baseballPlayerDataModel.MLBTheShow22Rating = baseballPlayerDomain.MLBTheShow22Rating;
        baseballPlayerDataModel.MLBTheShow23Rating = baseballPlayerDomain.MLBTheShow23Rating;
        baseballPlayerDataModel.MLBTheShow24Rating = baseballPlayerDomain.MLBTheShow24Rating;
        baseballPlayerDataModel.MLBTheShow25Rating = baseballPlayerDomain.MLBTheShow25Rating;
        return true;
    }
}