using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RunningForumAPI.Models;

namespace RunningForumAPI.Controllers
{
    // return all posts in the forum
    [Route("ReturnAllPosts")]
    [ApiController]
    public class ForumAllController : ControllerBase
    {
        [HttpGet(Name = "ReturnAllPosts")]
        public List<UserPost> Get()
        {
            
            return Forum.ForumHome;

        }
    }
}
