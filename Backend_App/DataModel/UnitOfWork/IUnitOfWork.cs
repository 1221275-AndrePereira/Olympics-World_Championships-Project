using Domain.IRepository;
using Domain.Model.Interface;

namespace UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository Generic { get; }

    IAmericanFootballPlayerRepository AmericanFootballPlayerRepository { get; }
    IBaseballPlayerRepository BaseballPlayerRepository { get; }
    IBasketballPlayerRepository BasketballPlayerRepository { get; }
    IFootballPlayerRepository FootballPlayerRepository { get; }
    IHandballPlayerRepository HandballPlayerRepository { get; }
    IIceHockeyPlayerRepository IceHockeyPlayerRepository { get; }
    
    Task<int> CompleteAsync();
}