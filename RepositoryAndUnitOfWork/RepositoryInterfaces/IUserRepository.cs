using System.Threading.Tasks;
using RepositoryAndUnitOfWork.DomainModels;

namespace RepositoryAndUnitOfWork.RepositoryInterfaces
{
    public interface IUserRepository : IRepository<ApplicationUser, string>
    {
        Task<int> UpdateUserProfileAsync(ApplicationUser user);
        void Detach(ApplicationUser model);
        Task<ApplicationUser> FindByUserNameAsync(string userName);
    }
}
