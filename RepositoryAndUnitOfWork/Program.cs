using System;
using RepositoryAndUnitOfWork.ORM;
using RepositoryAndUnitOfWork.UnitOfWorkParts;

namespace RepositoryAndUnitOfWork
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             What problems can the repository design pattern solve?
                In many applications, the business logic accesses data from data stores such as databases,
                SharePoint lists, or Web services.
                Directly accessing the data can result in the following:

                Duplicated code
                A higher potential for programming errors
                Weak typing of the business data
                Difficulty in centralizing data-related policies such as caching
                An inability to easily test the business logic in isolation from external dependencies

             More info: https://msdn.microsoft.com/en-us/library/ff649690.aspx
             */

            //usually it's injected into dependent classes within the scope of a request.
            var db = new FreelancerBlogContext();

            var unitOfWork = new UnitOfWork(db);

            var allArticleTags = unitOfWork.ArticleRepository.GetAllArticleTags();
        }
    }
}
