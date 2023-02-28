using System.ComponentModel.DataAnnotations;

namespace PhoneBookService.Models
{
    public class SMSMessage
    {
        [Required]
        public string SenderNum { get; set; }

        [Required]
        public string ReceiverNum { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(140)]
        public string MessageBody { get; set; }

        public override string ToString()
        {
            return String.Format("From: {0} | To: {1} | Message: {2}", SenderNum, ReceiverNum, MessageBody);
        }
    }
}
