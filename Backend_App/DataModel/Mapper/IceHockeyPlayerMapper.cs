using DataModel.Model;

namespace DataModel.Mapper;

using Domain.Factory.Interface;
using Domain.Model.IceHockey.IceHockeyPlayer;

public class IceHockeyPlayerMapper
{
    private IIceHockeyPlayerFactory _iceHockeyPlayerFactory;

    public IceHockeyPlayerMapper(IIceHockeyPlayerFactory iceHockeyPlayerFactory)
    {
        _iceHockeyPlayerFactory = iceHockeyPlayerFactory;
    }

    public IceHockeyPlayer ToDomain(IceHockeyPlayerDataModel iceHockeyPlayerDm)
    {

        
        IceHockeyPlayer iceHockeyPlayer = _iceHockeyPlayerFactory.newIceHockeyPlayer(iceHockeyPlayerDm.PlayerId,
            iceHockeyPlayerDm.PlayerName,
            iceHockeyPlayerDm.Country,
            iceHockeyPlayerDm.NHL93Rating,
            iceHockeyPlayerDm.NHL94Rating,
            iceHockeyPlayerDm.NHL95Rating,
            iceHockeyPlayerDm.NHL96Rating,
            iceHockeyPlayerDm.NHL97Rating,
            iceHockeyPlayerDm.NHL98Rating,
            iceHockeyPlayerDm.NHL99Rating,
            iceHockeyPlayerDm.NHL2000Rating,
            iceHockeyPlayerDm.NHL2001Rating,
            iceHockeyPlayerDm.NHL2002Rating,
            iceHockeyPlayerDm.NHL2003Rating,
            iceHockeyPlayerDm.NHL2004Rating,
            iceHockeyPlayerDm.NHL2005Rating,
            iceHockeyPlayerDm.NHL06Rating,
            iceHockeyPlayerDm.NHL07Rating,
            iceHockeyPlayerDm.NHL08Rating,
            iceHockeyPlayerDm.NHL09Rating,
            iceHockeyPlayerDm.NHL10Rating,
            iceHockeyPlayerDm.NHL11Rating,
            iceHockeyPlayerDm.NHL12Rating,
            iceHockeyPlayerDm.NHL13Rating,
            iceHockeyPlayerDm.NHL14Rating,
            iceHockeyPlayerDm.NHL15Rating,
            iceHockeyPlayerDm.NHL16Rating,
            iceHockeyPlayerDm.NHL17Rating,
            iceHockeyPlayerDm.NHL18Rating,
            iceHockeyPlayerDm.NHL19Rating,
            iceHockeyPlayerDm.NHL20Rating,
            iceHockeyPlayerDm.NHL21Rating,
            iceHockeyPlayerDm.NHL22Rating,
            iceHockeyPlayerDm.NHL23Rating,
            iceHockeyPlayerDm.NHL24Rating,
            iceHockeyPlayerDm.NHL25Rating,
            iceHockeyPlayerDm.NHL26Rating);
        return iceHockeyPlayer;
    }

    public IEnumerable<IceHockeyPlayer> ToDomain(IEnumerable<IceHockeyPlayerDataModel> iceHockeyPlayerDm)
    {
        List<IceHockeyPlayer> iceHockeyPlayersDomain = new List<IceHockeyPlayer>();

        foreach (IceHockeyPlayerDataModel iceHockeyPlayerDataModel in iceHockeyPlayerDm)
        {
            IceHockeyPlayer iceHockeyPlayerDomain = ToDomain(iceHockeyPlayerDataModel);

            iceHockeyPlayersDomain.Add(iceHockeyPlayerDomain);
        }

        return iceHockeyPlayersDomain;
    }

    public IceHockeyPlayerDataModel ToDataModel(IceHockeyPlayer iceHockeyPlayerDm)
    {
        IceHockeyPlayerDataModel iceHockeyPlayerDataModel = new IceHockeyPlayerDataModel(iceHockeyPlayerDm);

        return iceHockeyPlayerDataModel;
    }

    public bool UpdateDataModel(IceHockeyPlayerDataModel iceHockeyPlayerDataModel, IceHockeyPlayer iceHockeyPlayerDomain)
    {
        iceHockeyPlayerDataModel.PlayerName = iceHockeyPlayerDomain.PlayerName;
        iceHockeyPlayerDataModel.Country = iceHockeyPlayerDomain.Country;
        iceHockeyPlayerDataModel.NHL93Rating = iceHockeyPlayerDomain.NHL93Rating;
        iceHockeyPlayerDataModel.NHL94Rating = iceHockeyPlayerDomain.NHL94Rating;
        iceHockeyPlayerDataModel.NHL95Rating = iceHockeyPlayerDomain.NHL95Rating;
        iceHockeyPlayerDataModel.NHL96Rating = iceHockeyPlayerDomain.NHL96Rating;
        iceHockeyPlayerDataModel.NHL97Rating = iceHockeyPlayerDomain.NHL97Rating;
        iceHockeyPlayerDataModel.NHL98Rating = iceHockeyPlayerDomain.NHL98Rating;
        iceHockeyPlayerDataModel.NHL99Rating = iceHockeyPlayerDomain.NHL99Rating;
        iceHockeyPlayerDataModel.NHL2000Rating = iceHockeyPlayerDomain.NHL2000Rating;
        iceHockeyPlayerDataModel.NHL2001Rating = iceHockeyPlayerDomain.NHL2001Rating;
        iceHockeyPlayerDataModel.NHL2002Rating = iceHockeyPlayerDomain.NHL2002Rating;
        iceHockeyPlayerDataModel.NHL2003Rating = iceHockeyPlayerDomain.NHL2003Rating;
        iceHockeyPlayerDataModel.NHL2004Rating = iceHockeyPlayerDomain.NHL2004Rating;
        iceHockeyPlayerDataModel.NHL2005Rating = iceHockeyPlayerDomain.NHL2005Rating;
        iceHockeyPlayerDataModel.NHL06Rating = iceHockeyPlayerDomain.NHL06Rating;
        iceHockeyPlayerDataModel.NHL07Rating = iceHockeyPlayerDomain.NHL07Rating;
        iceHockeyPlayerDataModel.NHL08Rating = iceHockeyPlayerDomain.NHL08Rating;
        iceHockeyPlayerDataModel.NHL09Rating = iceHockeyPlayerDomain.NHL09Rating;
        iceHockeyPlayerDataModel.NHL10Rating = iceHockeyPlayerDomain.NHL10Rating;
        iceHockeyPlayerDataModel.NHL11Rating = iceHockeyPlayerDomain.NHL11Rating;
        iceHockeyPlayerDataModel.NHL12Rating = iceHockeyPlayerDomain.NHL12Rating;
        iceHockeyPlayerDataModel.NHL13Rating = iceHockeyPlayerDomain.NHL13Rating;
        iceHockeyPlayerDataModel.NHL14Rating = iceHockeyPlayerDomain.NHL14Rating;
        iceHockeyPlayerDataModel.NHL15Rating = iceHockeyPlayerDomain.NHL15Rating;
        iceHockeyPlayerDataModel.NHL16Rating = iceHockeyPlayerDomain.NHL16Rating;
        iceHockeyPlayerDataModel.NHL17Rating = iceHockeyPlayerDomain.NHL17Rating;
        iceHockeyPlayerDataModel.NHL18Rating = iceHockeyPlayerDomain.NHL18Rating;
        iceHockeyPlayerDataModel.NHL19Rating = iceHockeyPlayerDomain.NHL19Rating;
        iceHockeyPlayerDataModel.NHL20Rating = iceHockeyPlayerDomain.NHL20Rating;
        iceHockeyPlayerDataModel.NHL21Rating = iceHockeyPlayerDomain.NHL21Rating;
        iceHockeyPlayerDataModel.NHL22Rating = iceHockeyPlayerDomain.NHL22Rating;
        iceHockeyPlayerDataModel.NHL23Rating = iceHockeyPlayerDomain.NHL23Rating;
        iceHockeyPlayerDataModel.NHL24Rating = iceHockeyPlayerDomain.NHL24Rating;
        iceHockeyPlayerDataModel.NHL25Rating = iceHockeyPlayerDomain.NHL25Rating;
        iceHockeyPlayerDataModel.NHL26Rating = iceHockeyPlayerDomain.NHL26Rating;

        return true;
    }
}