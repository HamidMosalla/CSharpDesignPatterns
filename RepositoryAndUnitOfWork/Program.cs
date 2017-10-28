using System;
using RepositoryAndUnitOfWork.ORM;
using RepositoryAndUnitOfWork.UnitOfWorkParts;

namespace RepositoryAndUnitOfWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //usually it's injected into dependent classes within the scope of a request.
            var db = new FreelancerBlogContext();

            var unitOfWork = new UnitOfWork(db);

            var allArticleTags = unitOfWork.ArticleRepository.GetAllArticleTags();
        }
    }
}
