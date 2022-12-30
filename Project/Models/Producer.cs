using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public string? ProducerName { get; set; }
        public string? Bio { get; set; }

        //İlişkiler
        public List<Movie>? Movies { get; set; }
    }
}
