using System;
using System.Threading.Tasks;
using RepositoryAndUnitOfWork.RepositoryInterfaces;

namespace RepositoryAndUnitOfWork.UnitOfWorkParts
{
    public interface IUnitOfWork : IDisposable
    {
        IArticleRepository ArticleRepository { get; }
        IUserRepository UserRepository { get; }
        IContactRepository ContactRepository { get; }
        IPortfolioRepository PortfolioRepository { get; }
        ISiteOrderRepository SiteOrderRepository { get; }
        ISlideShowRepository SlideShowRepository { get; }
        int Save();
        Task<int> SaveAsync();
        new void Dispose();
    }
}