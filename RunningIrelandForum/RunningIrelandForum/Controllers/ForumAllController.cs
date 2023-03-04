using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RunningIrelandForum.Models;

namespace RunningIrelandForum.Controllers
{
    // return all posts in the forum
    [Route("forum")]
    [ApiController]
    public class ForumAllController : ControllerBase
    {
        //[HttpGet(Name = "ReturnPostByIDNum")]
        //public UserPost? Get(string PostId)
        //{
        //    foreach (var UserPost in Forum.ForumHome)
        //    {
        //        if (UserPost.PostId.ToString() == PostId)
        //        {
        //            return UserPost;
        //        }
        //    }
        //    return null;

        //}

        //[HttpGet(Name = "ReturnAllPosts")]
        public List<UserPost> Get()
        {
            
            return Forum.ForumHome;

        }
    }
}
