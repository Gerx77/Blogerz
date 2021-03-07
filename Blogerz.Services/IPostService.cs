using System.Collections.Generic;
using Blogerz.Model.Models;

namespace Blogerz.Services
{
    public interface IPostService
    {
        Post GetPost(int id);
        Post GetPost(string name);
        IEnumerable<Post> GetPosts();
        void CreatePost(Post post);
        void UpdatePost(Post post);
        void DeletePost(Post post);
        void SavePost();
    }
}
