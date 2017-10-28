using System.Threading.Tasks;
using RepositoryAndUnitOfWork.DomainModels;

namespace RepositoryAndUnitOfWork.RepositoryInterfaces
{
    public interface IContactRepository : IRepository<Contact, int>
    {
        Task<int> AddNewContactAsync(Contact contact);
        Task<int> DeleteContactAsync(Contact model);
    }
}
