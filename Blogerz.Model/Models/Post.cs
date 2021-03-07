using System;
using System.Collections.Generic;
using System.Text;

namespace Blogerz.Model.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public int BlogId { get; set; }
        //public virtual Blog Blog { get; set; }

        public Post()
        {
            DateCreated = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Id: {PostId}, {Title}";
        }
    }
}
