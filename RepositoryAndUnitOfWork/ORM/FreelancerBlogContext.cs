
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RepositoryAndUnitOfWork.DomainModels;

namespace RepositoryAndUnitOfWork.ORM
{
    public class FreelancerBlogContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleComment> ArticleComments { get; set; }
        public DbSet<ArticleRating> ArticleRatings { get; set; }
        public DbSet<ArticleTag> ArticleTags { get; set; }
        public DbSet<ArticleArticleTag> ArticleArticleTags { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<SiteOrder> SiteOrders { get; set; }
        public DbSet<SlideShow> SlideShows { get; set; }

        public FreelancerBlogContext(){ }

        public FreelancerBlogContext(DbContextOptions<FreelancerBlogContext> options) : base(options) { }
    }
}