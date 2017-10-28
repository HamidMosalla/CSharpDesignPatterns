using System.Threading.Tasks;
using RepositoryAndUnitOfWork.DomainModels;

namespace RepositoryAndUnitOfWork.RepositoryInterfaces
{
    public interface ISiteOrderRepository : IRepository<SiteOrder, int>
    {
        Task<int> AddSiteOrderAsync(SiteOrder siteOrder);
    }
}
