using System.ComponentModel.DataAnnotations;

namespace Api.Models
{

    public class User
    {
        // attributes
        [Key]
        public Guid UserID { get; set; }

        [Required]
        public string? UserName { get; set; }

        [Required]
        public string? Password { get; set; }

        [EmailAddress]
        public string? EmailAddress { get; set; }

        public Shops FavouriteShop { get; set; }
    }
}
