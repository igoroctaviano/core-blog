using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace core_blog
{
    [Route("api/[controller]")]
    public class PostController : Controller
    {
        // GET api/post
        [HttpGet]
        public Post[] Get()
        {
            var posts = new List<Post>();

            posts.Add(new Post() { Id = 1, Author = "Roger", Content = "This is a content.",
                                   PublicationDate = DateTime.Now });
            posts.Add(new Post() { Id = 2, Author = "Max", Content = "This is another content.",
                                   PublicationDate = DateTime.Now });

            return posts.ToArray();
        }

        // GET api/post/5
        [HttpGet("{id}")]
        public Post Get(int id)
        {
            return Get().Where(p => p.Id == id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
