using System.Collections.Generic;
using Blogerz.Data.Infrastructure;
using Blogerz.Data.Repositories;
using Blogerz.Model.Models;

namespace Blogerz.Services
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository blogRepository;
        private readonly IUnitOfWork unitOfWork;

        public BlogService(IBlogRepository blogRepository, IUnitOfWork unitOfWork)
        {
            this.blogRepository = blogRepository;
            this.unitOfWork = unitOfWork;
        }

        public Blog GetBlog(int id)
        {
            return blogRepository.GetById(id);
        }

        public Blog GetBlog(string url)
        {
            return blogRepository.GetBlogByUrl(url);
        }

        public IEnumerable<Blog> GetBlogs()
        {
            return blogRepository.GetAll();
        }

        public void CreateBlog(Blog blog)
        {
            blogRepository.Add(blog);
        }

        public void UpdateBlog(Blog blog)
        {
            blogRepository.Update(blog);
        }

        public void DeleteBlog(Blog blog)
        {
            blogRepository.Delete(blog);
        }

        public void SaveBlog()
        {
            unitOfWork.Commit();
        }
    }
}
