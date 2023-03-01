namespace RunningIrelandForum.Models
{
    public static class Forum
    {
        public static List<UserPost> ForumHome = new List<UserPost>();

        public static void init()
        {
            UserPost up1 = new() { Subject = "Blessington Greenway", Message = "New Bridge is intalled and is a wonderful edition", Timestamp = new DateTime(2023, 02, 28, 22, 35, 5,) };
            ForumHome.Add(up1);

            UserPost up2 = new() { Subject = "Glendalough Tucker Trail", Message = "This event will now form part of the ultra championships for 2023. With the IUC league link updated (thanks Rich) to show 6 events for this year, we’ll have a score of 4 to count at year end.\r\n\r\nHappy event planning to all ‘23 IUC hopefuls :)", Timestamp = new DateTime(2023, 03, 01, 22, 35, 5,) };
            ForumHome.Add(up2);

            UserPost up3 = new() { Subject = "Blessington Greenway", Message = "New Bridge is intalled and is a wonderful edition", Timestamp = new DateTime(2023, 03, 01, 22, 35, 5,) };
            ForumHome.Add(up3);

            UserPost up4 = new() { Subject = "Blessington Greenway", Message = "New Bridge is intalled and is a wonderful edition", Timestamp = new DateTime(2023, 03, 01, 23, 57, 5,) };
            ForumHome.Add(up4);

            UserPost up5 = new() { Subject = "Blessington Greenway", Message = "New Bridge is intalled and is a wonderful edition", Timestamp = new DateTime(2023, 03, 02, 00, 01, 10,) };
            ForumHome.Add(up5);
        }
    }
}