namespace RunningIrelandForum.Models
{
    public static class Forum
    {
        public static List<UserPost> ForumHome = new List<UserPost>();

        public static void init()
        {
            UserPost up1 = new() { Subject = "Blessington Greenway", Message = "New Bridge is intalled and is a wonderful edition", Timestamp = new DateTime(1979, 07, 28, 22, 35, 5,) };
        }
    }
}