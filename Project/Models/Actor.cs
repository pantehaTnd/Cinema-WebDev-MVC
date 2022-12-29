using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public string? ActorName { get; set; }
        public string? Bio { get; set; }
    }
}
