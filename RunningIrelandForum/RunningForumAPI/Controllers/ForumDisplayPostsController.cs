using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RunningForumAPI.Models;

namespace RunningForumAPI.Controllers
{
    // return all posts in the forum
    [Route("ForumDisplayPostsController")]
    [ApiController]
    public class ForumDisplayPostsController : ControllerBase
    {
        [HttpGet(Name = "ForumDisplayPostsController")]
        public List<UserPost> Get(int UserNum)
        {
            //
            List<UserPost> posts = new List<UserPost>();
            int list_count = Forum.ForumHome.Count;
            if (list_count <= UserNum)
            {
                return Forum.ForumHome;
            }

                for (int i = 1; i < UserNum +1; i++)
                {
                    posts.Add(Forum.ForumHome[list_count-i]);

                }
                return posts;

        }
        

    }
}
