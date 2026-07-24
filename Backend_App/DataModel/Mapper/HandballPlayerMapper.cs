using DataModel.Model;

namespace DataModel.Mapper;

using Domain.Factory.Interface;
using Domain.Model.Handball.HandballPlayer;

public class HandballPlayerMapper
{
    private IHandballPlayerFactory _handballPlayerFactory;

    public HandballPlayerMapper(IHandballPlayerFactory handballPlayerFactory)
    {
        _handballPlayerFactory = handballPlayerFactory;
    }

    public HandballPlayer ToDomain(HandballPlayerDataModel handballPlayerDm)
    {

        
        HandballPlayer handballPlayer = _handballPlayerFactory.newHandballPlayer(handballPlayerDm.PlayerId,
            handballPlayerDm.PlayerName,
            handballPlayerDm.Country,
            handballPlayerDm.Handball17Rating,
            handballPlayerDm.Handball21Rating);
        return handballPlayer;
    }

    public IEnumerable<HandballPlayer> ToDomain(IEnumerable<HandballPlayerDataModel> handballPlayerDm)
    {
        List<HandballPlayer> handballPlayersDomain = new List<HandballPlayer>();

        foreach (HandballPlayerDataModel handballPlayerDataModel in handballPlayerDm)
        {
            HandballPlayer handballPlayerDomain = ToDomain(handballPlayerDataModel);

            handballPlayersDomain.Add(handballPlayerDomain);
        }

        return handballPlayersDomain;
    }

    public HandballPlayerDataModel ToDataModel(HandballPlayer handballPlayerDm)
    {
        HandballPlayerDataModel handballPlayerDataModel = new HandballPlayerDataModel(handballPlayerDm);

        return handballPlayerDataModel;
    }

    public bool UpdateDataModel(HandballPlayerDataModel handballPlayerDataModel, HandballPlayer handballPlayerDomain)
    {
        handballPlayerDataModel.PlayerName = handballPlayerDomain.PlayerName;
        handballPlayerDataModel.Country = handballPlayerDomain.Country;
        handballPlayerDataModel.Handball17Rating = handballPlayerDomain.Handball17Rating;
        handballPlayerDataModel.Handball21Rating = handballPlayerDomain.Handball21Rating;

        return true;
    }
}