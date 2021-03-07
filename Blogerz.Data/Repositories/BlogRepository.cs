using Blogerz.Data.Infrastructure;
using Blogerz.Model.Models;
using System;
using System.Linq;

namespace Blogerz.Data.Repositories
{
    public interface IBlogRepository : IRepository<Blog>
    {
        Blog GetBlogByUrl(string url);
    }
    public class BlogRepository : RepositoryBase<Blog>, IBlogRepository
    {
        public BlogRepository(IDbFactory dbFactory) : base(dbFactory) { }

        public Blog GetBlogByUrl(string url)
        {
            return this.DbContext.Blogs.Where(c => c.Url == url).FirstOrDefault();
        }

        public override void Update(Blog entity)
        {
            entity.DateUpdated = DateTime.Now;
            var xyz = this.DbContext.Blogs.Find(entity.BlogId);
            this.DbContext.Entry(xyz).CurrentValues.SetValues(entity);
            base.Update(entity);
        }
    }
}
