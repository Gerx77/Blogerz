using System;
using System.Collections.Generic;
using System.Text;

namespace Blogerz.Model.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public virtual List<Post> Posts { get; set; }

        public Blog()
        {
            DateCreated = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Id: {BlogId}, Url: {Url}";
        }
    }
}
