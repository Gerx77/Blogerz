using Blogerz.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace Blogerz.Data
{
    public class BlogerzDbContext : DbContext
    {
        public BlogerzDbContext() //: base(nameOrConnectionString: "BEDBConnectionString")
        {

        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}
