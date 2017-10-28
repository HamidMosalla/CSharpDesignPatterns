using System.Threading.Tasks;
using RepositoryAndUnitOfWork.DomainModels;

namespace RepositoryAndUnitOfWork.RepositoryInterfaces
{
    public interface IPortfolioRepository : IRepository<Portfolio, int>
    {
        Task<int> AddNewPortfolio(Portfolio portfolio);
        Task<int> DeletePortfolioAsync(Portfolio model);
        void Detach(Portfolio model);
        Task<int> UpdatePortfolioAsync(Portfolio portfolio);
    }
}
