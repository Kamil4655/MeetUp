using System.ComponentModel.DataAnnotations;

namespace MeetUp.Models
{
    public class Category : BaseEntity
    {
        [MaxLength(35),Required]
        public string Name { get; set; }
        [Required]
        public string ImageFile { get; set; }
        [MaxLength(255),Required]
        public string Description { get; set; }
        [Required]
        public string SocialMedia { get; set; }
    }
}
