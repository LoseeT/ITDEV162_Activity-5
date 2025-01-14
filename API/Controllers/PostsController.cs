using Domain;
using Microsoft.AspNetCore.Mvc;
using Persistence;

namespace API.Controllers{
    [ApiController]
    //Runs on localhost:5278/api/posts
    [Route("api/[controller]")]
    public class PostsController: ControllerBase
    {
        private readonly DataContext _context;

        public PostsController(DataContext context)
        {
            this._context = context;
        }


        [HttpGet(Name = "GetPosts")]
        public ActionResult<List<Post>> Get()
        {
            return this._context.Posts.ToList();
        }
    }
}
