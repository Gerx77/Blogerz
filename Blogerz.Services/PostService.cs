using System.Collections.Generic;
using Blogerz.Model.Models;
using Blogerz.Data.Infrastructure;
using Blogerz.Data.Repositories;

namespace Blogerz.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository postRepository;
        private readonly IUnitOfWork unitOfWork;

        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this.postRepository = postRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreatePost(Post post)
        {
            postRepository.Add(post);
        }

        public void DeletePost(Post post)
        {
            postRepository.Delete(post);
        }

        public Post GetPost(int id)
        {
            return postRepository.GetById(id);
        }

        public Post GetPost(string name)
        {
            return postRepository.GetPostByTitle(name);
        }

        public IEnumerable<Post> GetPosts()
        {
            return postRepository.GetAll();
        }

        public void SavePost()
        {
            unitOfWork.Commit();
        }

        public void UpdatePost(Post post)
        {
            postRepository.Update(post);
        }
    }
}
