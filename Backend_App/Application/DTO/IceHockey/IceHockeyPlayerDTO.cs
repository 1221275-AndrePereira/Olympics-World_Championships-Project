namespace Application.DTO.IceHockey;


using Domain.Model.IceHockey;
using Domain.Model.IceHockey.IceHockeyPlayer;

public class IceHockeyPlayerDTO
{

    public Guid PlayerId{ get; set; }

    public string PlayerName{ get; set; }

    public string Country{ get; set; }

    public IceHockeyPlayerRating? NHL93Rating { get; set; }
    public IceHockeyPlayerRating? NHL94Rating { get; set; }
    public IceHockeyPlayerRating? NHL95Rating { get; set; }
    public IceHockeyPlayerRating? NHL96Rating { get; set; }
    public IceHockeyPlayerRating? NHL97Rating { get; set; }
    public IceHockeyPlayerRating? NHL98Rating { get; set; }
    public IceHockeyPlayerRating? NHL99Rating { get; set; }
    public IceHockeyPlayerRating? NHL2000Rating { get; set; }
    public IceHockeyPlayerRating? NHL2001Rating { get; set; }
    public IceHockeyPlayerRating? NHL2002Rating { get; set; }
    public IceHockeyPlayerRating? NHL2003Rating { get; set; }
    public IceHockeyPlayerRating? NHL2004Rating { get; set; }
    public IceHockeyPlayerRating? NHL2005Rating { get; set; }
    public IceHockeyPlayerRating? NHL06Rating { get; set; }
    public IceHockeyPlayerRating? NHL07Rating { get; set; }
    public IceHockeyPlayerRating? NHL08Rating { get; set; }
    public IceHockeyPlayerRating? NHL09Rating { get; set; }
    public IceHockeyPlayerRating? NHL10Rating { get; set; }
    public IceHockeyPlayerRating? NHL11Rating { get; set; }
    public IceHockeyPlayerRating? NHL12Rating { get; set; }
    public IceHockeyPlayerRating? NHL13Rating { get; set; }
    public IceHockeyPlayerRating? NHL14Rating { get; set; }
    public IceHockeyPlayerRating? NHL15Rating { get; set; }
    public IceHockeyPlayerRating? NHL16Rating { get; set; }
    public IceHockeyPlayerRating? NHL17Rating { get; set; }
    public IceHockeyPlayerRating? NHL18Rating { get; set; }
    public IceHockeyPlayerRating? NHL19Rating { get; set; }
    public IceHockeyPlayerRating? NHL20Rating { get; set; }
    public IceHockeyPlayerRating? NHL21Rating { get; set; }
    public IceHockeyPlayerRating? NHL22Rating { get; set; }
    public IceHockeyPlayerRating? NHL23Rating { get; set; }
    public IceHockeyPlayerRating? NHL24Rating { get; set; }
    public IceHockeyPlayerRating? NHL25Rating { get; set; }
    public IceHockeyPlayerRating? NHL26Rating { get; set; }

    public IceHockeyPlayerDTO()
    {
    }

    public IceHockeyPlayerDTO(
        Guid id,
        string playerName,
        string country,
        IceHockeyPlayerRating? ratingNHL93,
        IceHockeyPlayerRating? ratingNHL94,
        IceHockeyPlayerRating? ratingNHL95,
        IceHockeyPlayerRating? ratingNHL96,
        IceHockeyPlayerRating? ratingNHL97,
        IceHockeyPlayerRating? ratingNHL98,
        IceHockeyPlayerRating? ratingNHL99,
        IceHockeyPlayerRating? ratingNHL2000,
        IceHockeyPlayerRating? ratingNHL2001,
        IceHockeyPlayerRating? ratingNHL2002,
        IceHockeyPlayerRating? ratingNHL2003,
        IceHockeyPlayerRating? ratingNHL2004,
        IceHockeyPlayerRating? ratingNHL2005,
        IceHockeyPlayerRating? ratingNHL06,
        IceHockeyPlayerRating? ratingNHL07,
        IceHockeyPlayerRating? ratingNHL08,
        IceHockeyPlayerRating? ratingNHL09,
        IceHockeyPlayerRating? ratingNHL10,
        IceHockeyPlayerRating? ratingNHL11,
        IceHockeyPlayerRating? ratingNHL12,
        IceHockeyPlayerRating? ratingNHL13,
        IceHockeyPlayerRating? ratingNHL14,
        IceHockeyPlayerRating? ratingNHL15,
        IceHockeyPlayerRating? ratingNHL16,
        IceHockeyPlayerRating? ratingNHL17,
        IceHockeyPlayerRating? ratingNHL18,
        IceHockeyPlayerRating? ratingNHL19,
        IceHockeyPlayerRating? ratingNHL20,
        IceHockeyPlayerRating? ratingNHL21,
        IceHockeyPlayerRating? ratingNHL22,
        IceHockeyPlayerRating? ratingNHL23,
        IceHockeyPlayerRating? ratingNHL24,
        IceHockeyPlayerRating? ratingNHL25,
        IceHockeyPlayerRating? ratingNHL26
    )
    {
        PlayerId = id;
        PlayerName = playerName;
        Country = country;
        NHL93Rating = ratingNHL93;
        NHL94Rating = ratingNHL94;
        NHL95Rating = ratingNHL95;
        NHL96Rating = ratingNHL96;
        NHL97Rating = ratingNHL97;
        NHL98Rating = ratingNHL98;
        NHL99Rating = ratingNHL99;
        NHL2000Rating = ratingNHL2000;
        NHL2001Rating = ratingNHL2001;
        NHL2002Rating = ratingNHL2002;
        NHL2003Rating = ratingNHL2003;
        NHL2004Rating = ratingNHL2004;
        NHL2005Rating = ratingNHL2005;
        NHL06Rating = ratingNHL06;
        NHL07Rating = ratingNHL07;
        NHL08Rating = ratingNHL08;
        NHL09Rating = ratingNHL09;
        NHL10Rating = ratingNHL10;
        NHL11Rating = ratingNHL11;
        NHL12Rating = ratingNHL12;
        NHL13Rating = ratingNHL13;
        NHL14Rating = ratingNHL14;
        NHL15Rating = ratingNHL15;
        NHL16Rating = ratingNHL16;
        NHL17Rating = ratingNHL17;
        NHL18Rating = ratingNHL18;
        NHL19Rating = ratingNHL19;
        NHL20Rating = ratingNHL20;
        NHL21Rating = ratingNHL21;
        NHL22Rating = ratingNHL22;
        NHL23Rating = ratingNHL23;
        NHL24Rating = ratingNHL24;
        NHL25Rating = ratingNHL25;
        NHL26Rating = ratingNHL26;
    }

    static public IceHockeyPlayerDTO ToDTO(IceHockeyPlayer iceHockeyPlayer)
    {

        IceHockeyPlayerDTO iceHockeyPlayerDTO = new IceHockeyPlayerDTO(iceHockeyPlayer.PlayerId,
            iceHockeyPlayer.PlayerName,
            iceHockeyPlayer.Country,
            iceHockeyPlayer.NHL93Rating,
            iceHockeyPlayer.NHL94Rating,
            iceHockeyPlayer.NHL95Rating,
            iceHockeyPlayer.NHL96Rating,
            iceHockeyPlayer.NHL97Rating,
            iceHockeyPlayer.NHL98Rating,
            iceHockeyPlayer.NHL99Rating,
            iceHockeyPlayer.NHL2000Rating,
            iceHockeyPlayer.NHL2001Rating,
            iceHockeyPlayer.NHL2002Rating,
            iceHockeyPlayer.NHL2003Rating,
            iceHockeyPlayer.NHL2004Rating,
            iceHockeyPlayer.NHL2005Rating,
            iceHockeyPlayer.NHL06Rating,
            iceHockeyPlayer.NHL07Rating,
            iceHockeyPlayer.NHL08Rating,
            iceHockeyPlayer.NHL09Rating,
            iceHockeyPlayer.NHL10Rating,
            iceHockeyPlayer.NHL11Rating,
            iceHockeyPlayer.NHL12Rating,
            iceHockeyPlayer.NHL13Rating,
            iceHockeyPlayer.NHL14Rating,
            iceHockeyPlayer.NHL15Rating,
            iceHockeyPlayer.NHL16Rating,
            iceHockeyPlayer.NHL17Rating,
            iceHockeyPlayer.NHL18Rating,
            iceHockeyPlayer.NHL19Rating,
            iceHockeyPlayer.NHL20Rating,
            iceHockeyPlayer.NHL21Rating,
            iceHockeyPlayer.NHL22Rating,
            iceHockeyPlayer.NHL23Rating,
            iceHockeyPlayer.NHL24Rating,
            iceHockeyPlayer.NHL25Rating,
            iceHockeyPlayer.NHL26Rating);
        return iceHockeyPlayerDTO;
    }

    static public IEnumerable<IceHockeyPlayerDTO> ToDTO(IEnumerable<IceHockeyPlayer> iceHockeyPlayers)
    {
        List<IceHockeyPlayerDTO> iceHockeyPlayerDTOs = new List<IceHockeyPlayerDTO>();

        foreach (IceHockeyPlayer iceHockeyPlayer in iceHockeyPlayers)
        {
            IceHockeyPlayerDTO iceHockeyPlayerDTO = IceHockeyPlayerDTO.ToDTO(iceHockeyPlayer);
            iceHockeyPlayerDTOs.Add(iceHockeyPlayerDTO);
        }

        return iceHockeyPlayerDTOs;
    }

    static public IceHockeyPlayer ToDomain(IceHockeyPlayerDTO iceHockeyPlayerDTO)
    {

        IceHockeyPlayer iceHockeyPlayer = new IceHockeyPlayer(iceHockeyPlayerDTO.PlayerId,
            iceHockeyPlayerDTO.PlayerName,
            iceHockeyPlayerDTO.Country,
            iceHockeyPlayerDTO.NHL93Rating,
            iceHockeyPlayerDTO.NHL94Rating,
            iceHockeyPlayerDTO.NHL95Rating,
            iceHockeyPlayerDTO.NHL96Rating,
            iceHockeyPlayerDTO.NHL97Rating,
            iceHockeyPlayerDTO.NHL98Rating,
            iceHockeyPlayerDTO.NHL99Rating,
            iceHockeyPlayerDTO.NHL2000Rating,
            iceHockeyPlayerDTO.NHL2001Rating,
            iceHockeyPlayerDTO.NHL2002Rating,
            iceHockeyPlayerDTO.NHL2003Rating,
            iceHockeyPlayerDTO.NHL2004Rating,
            iceHockeyPlayerDTO.NHL2005Rating,
            iceHockeyPlayerDTO.NHL06Rating,
            iceHockeyPlayerDTO.NHL07Rating,
            iceHockeyPlayerDTO.NHL08Rating,
            iceHockeyPlayerDTO.NHL09Rating,
            iceHockeyPlayerDTO.NHL10Rating,
            iceHockeyPlayerDTO.NHL11Rating,
            iceHockeyPlayerDTO.NHL12Rating,
            iceHockeyPlayerDTO.NHL13Rating,
            iceHockeyPlayerDTO.NHL14Rating,
            iceHockeyPlayerDTO.NHL15Rating,
            iceHockeyPlayerDTO.NHL16Rating,
            iceHockeyPlayerDTO.NHL17Rating,
            iceHockeyPlayerDTO.NHL18Rating,
            iceHockeyPlayerDTO.NHL19Rating,
            iceHockeyPlayerDTO.NHL20Rating,
            iceHockeyPlayerDTO.NHL21Rating,
            iceHockeyPlayerDTO.NHL22Rating,
            iceHockeyPlayerDTO.NHL23Rating,
            iceHockeyPlayerDTO.NHL24Rating,
            iceHockeyPlayerDTO.NHL25Rating,
            iceHockeyPlayerDTO.NHL26Rating);
        return iceHockeyPlayer;
    }
}