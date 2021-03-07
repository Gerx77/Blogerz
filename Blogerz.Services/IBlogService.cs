using System.Collections.Generic;
using Blogerz.Model.Models;

namespace Blogerz.Services
{
    public interface IBlogService
    {
        Blog GetBlog(int id);
        Blog GetBlog(string url);
        IEnumerable<Blog> GetBlogs();
        void CreateBlog(Blog blog);
        void UpdateBlog(Blog blog);
        void DeleteBlog(Blog blog);
        void SaveBlog();
    }
}
