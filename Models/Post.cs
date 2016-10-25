using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_blog
{
    public class Post
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime PublicationDate { get; set; }

        public Post()
        {

        }
    }
}
