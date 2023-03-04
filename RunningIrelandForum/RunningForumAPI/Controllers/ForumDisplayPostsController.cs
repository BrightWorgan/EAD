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
            //List<UserPost> clonedListUserPost = new List<UserPost>(Forum.ForumHome);
            List<UserPost> posts = new List<UserPost>();
            int list_count = Forum.ForumHome.Count;
            if (list_count < UserNum)
            {
                return Forum.ForumHome;
            }
            if (list_count > UserNum)
            {
                for (int i = 1; i < UserNum +1; i++)
                {
                    posts.Add(Forum.ForumHome[list_count-i]);

                }
                return posts;
            
            }
            return null;


            //foreach (var UserPost in Forum.ForumHome)
            //{
            //    if (clonedListUserPost.length()
            //    {
            //        return UserPost;
            //    }
            //}
            //return null;

        }
        //List<string> source = new List<string>() { "A", "B", "C" };
        //List<UserPost> clonedListUserPost = new List<UserPost>(source);
        //Console.WriteLine(String.Join(",", clonedList));
    }
}
