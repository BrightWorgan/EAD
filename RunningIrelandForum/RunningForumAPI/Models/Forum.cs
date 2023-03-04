using System.Collections.Generic;

namespace RunningForumAPI.Models
{
    public static class Forum
    {
        public static List<UserPost> ForumHome = new List<UserPost>();

        public static void init()
        {
            UserPost up1 = new UserPost() { Subject = "Blessington Greenway, Co. Wicklow", Message = "New Bridge is intalled and is a wonderful edition", Timestamp = new DateTime(2023, 02, 28, 22, 35, 5), PostId = Guid.NewGuid() };
            ForumHome.Add(up1);

            UserPost up2 = new UserPost () { Subject = "Glendalough Tucker Trail, Co. Wicklow", Message = "This event will now form part of the ultra championships for 2023. With the IUC league link updated (thanks Rich) to show 6 events for this year, we’ll have a score of 4 to count at year end.\r\n\r\nHappy event planning to all ‘23 IUC hopefuls :)", Timestamp = new DateTime(2023, 03, 01, 22, 35, 5), PostId = Guid.NewGuid() };
            ForumHome.Add(up2);

            UserPost up3 = new UserPost () { Subject = "Kippure Mountain Trial, Co. Wicklow", Message = "Snow on the top of Kippure! I struggled to climb up the military side today.", Timestamp = new DateTime(2023, 03, 01, 22, 35, 5), PostId = Guid.NewGuid() };
            ForumHome.Add(up3);

            UserPost up4 = new UserPost () { Subject = "Russborough House Parkrun, Blessington, Co. Wicklow", Message = "Got a new PR today at Parkrun!", Timestamp = new DateTime(2023, 03, 01, 23, 57, 5), PostId = Guid.NewGuid() };
            ForumHome.Add(up4);

            UserPost up5 = new UserPost () { Subject = "Russborough House Parkrun, Blessington, Co. Wicklow", Message = "We need more voulunteers for next week's Parkrun. Does anyone facy joining me in helping out? We can grab a coffee in the cafe afterwards :)", Timestamp = new DateTime(2023, 03, 02, 00, 01, 10), PostId = Guid.NewGuid() };
            ForumHome.Add(up5);
        }
    }


}