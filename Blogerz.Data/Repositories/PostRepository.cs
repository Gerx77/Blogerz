using Blogerz.Data.Infrastructure;
using Blogerz.Model.Models;
using System;
using System.Linq;

namespace Blogerz.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
        Post GetPostByTitle(string name);
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory) { }

        public override void Update(Post entity)
        {
            entity.DateUpdated = DateTime.Now;
            var xyz = this.DbContext.Posts.Find(entity.PostId);
            this.DbContext.Entry(xyz).CurrentValues.SetValues(entity);
            base.Update(entity);
        }

        public Post GetPostByTitle(string name)
        {
            return this.DbContext.Posts.Where(c => c.Title == name).FirstOrDefault();
        }
    }
}
