using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RunningForumAPI.Models;

namespace RunningForumAPI.Controllers
{
    // return all posts in the forum
    [Route("ReturnPostsFromID")]
    [ApiController]
    public class ForumPostIDController : ControllerBase
    {
        [HttpGet(Name = "ReturnPostsFromID")]
        public UserPost? Get(string PostId)
        {
            foreach (var UserPost in Forum.ForumHome)
            {
                if (UserPost.PostId.ToString() == PostId)
                {
                    return UserPost;
                }
            }
            return null;

        }
    }
}