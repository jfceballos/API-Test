using System.ComponentModel.DataAnnotations;

namespace Commander.Models
{
    public class Command
    {
        public int Id { get; set; }

        [Required]
        public string HowTo { get; set; }
        public string Line { get; set; }
        public string Platform { get; set; }
    }
}