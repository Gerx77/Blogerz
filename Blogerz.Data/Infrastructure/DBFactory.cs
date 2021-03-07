using System;

namespace Blogerz.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        BlogerzDbContext Init();
    }

    public class DBFactory : Disposable, IDbFactory
    {
        BlogerzDbContext dbContext;

        public BlogerzDbContext Init()
        {
            return dbContext ?? (dbContext = new BlogerzDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
