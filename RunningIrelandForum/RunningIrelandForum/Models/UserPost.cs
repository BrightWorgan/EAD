namespace RunningIrelandForum.Models
{
    public class UserPost
    {
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }

        public UserPost(int id, string Subject, string Message, DateTime Timestamp)
        {
            this.Subject = Subject;
            this.Message = Message;
            this.Timestamp = Timestamp;
        }



    }
}
