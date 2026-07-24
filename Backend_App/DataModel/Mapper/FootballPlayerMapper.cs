using DataModel.Model;

namespace DataModel.Mapper;

using Domain.Factory.Interface;
using Domain.Model.Football.FootballPlayer;

public class FootballPlayerMapper
{
    private IFootballPlayerFactory _footballPlayerFactory;

    public FootballPlayerMapper(IFootballPlayerFactory footballPlayerFactory)
    {
        _footballPlayerFactory = footballPlayerFactory;
    }

    public FootballPlayer ToDomain(FootballPlayerDataModel footballPlayerDm)
    {

        
        FootballPlayer footballPlayer = _footballPlayerFactory.newFootballPlayer(footballPlayerDm.PlayerId,
            footballPlayerDm.PlayerName,
            footballPlayerDm.Country,
            footballPlayerDm.FIFA96Rating,
            footballPlayerDm.FIFA97Rating,
            footballPlayerDm.FIFA98Rating,
            footballPlayerDm.FIFA99Rating,
            footballPlayerDm.FIFA2000Rating,
            footballPlayerDm.FIFA2001Rating,
            footballPlayerDm.FIFA2002Rating,
            footballPlayerDm.FIFA2003Rating,
            footballPlayerDm.FIFA2004Rating,
            footballPlayerDm.FIFA2005Rating,
            footballPlayerDm.FIFA06Rating,
            footballPlayerDm.FIFA07Rating,
            footballPlayerDm.FIFA08Rating,
            footballPlayerDm.FIFA09Rating,
            footballPlayerDm.FIFA10Rating,
            footballPlayerDm.FIFA11Rating,
            footballPlayerDm.FIFA12Rating,
            footballPlayerDm.FIFA13Rating,
            footballPlayerDm.FIFA14Rating,
            footballPlayerDm.FIFA15Rating,
            footballPlayerDm.FIFA16Rating,
            footballPlayerDm.FIFA17Rating,
            footballPlayerDm.FIFA18Rating,
            footballPlayerDm.FIFA19Rating,
            footballPlayerDm.FIFA20Rating,
            footballPlayerDm.FIFA21Rating,
            footballPlayerDm.FIFA22Rating,
            footballPlayerDm.FIFA23Rating,
            footballPlayerDm.EAFC24Rating,
            footballPlayerDm.EAFC25Rating,
            footballPlayerDm.EAFC26Rating);
        return footballPlayer;
    }

    public IEnumerable<FootballPlayer> ToDomain(IEnumerable<FootballPlayerDataModel> footballPlayerDm)
    {
        List<FootballPlayer> footballPlayersDomain = new List<FootballPlayer>();

        foreach (FootballPlayerDataModel footballPlayerDataModel in footballPlayerDm)
        {
            FootballPlayer footballPlayerDomain = ToDomain(footballPlayerDataModel);

            footballPlayersDomain.Add(footballPlayerDomain);
        }

        return footballPlayersDomain;
    }

    public FootballPlayerDataModel ToDataModel(FootballPlayer footballPlayerDm)
    {
        FootballPlayerDataModel footballPlayerDataModel = new FootballPlayerDataModel(footballPlayerDm);

        return footballPlayerDataModel;
    }

    public bool UpdateDataModel(FootballPlayerDataModel footballPlayerDataModel, FootballPlayer footballPlayerDomain)
    {
        footballPlayerDataModel.PlayerName = footballPlayerDomain.PlayerName;
        footballPlayerDataModel.Country = footballPlayerDomain.Country;
        footballPlayerDataModel.FIFA96Rating = footballPlayerDomain.FIFA96Rating;
        footballPlayerDataModel.FIFA97Rating = footballPlayerDomain.FIFA97Rating;
        footballPlayerDataModel.FIFA98Rating = footballPlayerDomain.FIFA98Rating;
        footballPlayerDataModel.FIFA99Rating = footballPlayerDomain.FIFA99Rating;
        footballPlayerDataModel.FIFA2000Rating = footballPlayerDomain.FIFA2000Rating;
        footballPlayerDataModel.FIFA2001Rating = footballPlayerDomain.FIFA2001Rating;
        footballPlayerDataModel.FIFA2002Rating = footballPlayerDomain.FIFA2002Rating;
        footballPlayerDataModel.FIFA2003Rating = footballPlayerDomain.FIFA2003Rating;
        footballPlayerDataModel.FIFA2004Rating = footballPlayerDomain.FIFA2004Rating;
        footballPlayerDataModel.FIFA2005Rating = footballPlayerDomain.FIFA2005Rating;
        footballPlayerDataModel.FIFA06Rating = footballPlayerDomain.FIFA06Rating;
        footballPlayerDataModel.FIFA07Rating = footballPlayerDomain.FIFA07Rating;
        footballPlayerDataModel.FIFA08Rating = footballPlayerDomain.FIFA08Rating;
        footballPlayerDataModel.FIFA09Rating = footballPlayerDomain.FIFA09Rating;
        footballPlayerDataModel.FIFA10Rating = footballPlayerDomain.FIFA10Rating;
        footballPlayerDataModel.FIFA11Rating = footballPlayerDomain.FIFA11Rating;
        footballPlayerDataModel.FIFA12Rating = footballPlayerDomain.FIFA12Rating;
        footballPlayerDataModel.FIFA13Rating = footballPlayerDomain.FIFA13Rating;
        footballPlayerDataModel.FIFA14Rating = footballPlayerDomain.FIFA14Rating;
        footballPlayerDataModel.FIFA15Rating = footballPlayerDomain.FIFA15Rating;
        footballPlayerDataModel.FIFA16Rating = footballPlayerDomain.FIFA16Rating;
        footballPlayerDataModel.FIFA17Rating = footballPlayerDomain.FIFA17Rating;
        footballPlayerDataModel.FIFA18Rating = footballPlayerDomain.FIFA18Rating;
        footballPlayerDataModel.FIFA19Rating = footballPlayerDomain.FIFA19Rating;
        footballPlayerDataModel.FIFA20Rating = footballPlayerDomain.FIFA20Rating;
        footballPlayerDataModel.FIFA21Rating = footballPlayerDomain.FIFA21Rating;
        footballPlayerDataModel.FIFA22Rating = footballPlayerDomain.FIFA22Rating;
        footballPlayerDataModel.FIFA23Rating = footballPlayerDomain.FIFA23Rating;
        footballPlayerDataModel.EAFC24Rating = footballPlayerDomain.EAFC24Rating;
        footballPlayerDataModel.EAFC25Rating = footballPlayerDomain.EAFC25Rating;
        footballPlayerDataModel.EAFC26Rating = footballPlayerDomain.EAFC26Rating;

        return true;
    }
}