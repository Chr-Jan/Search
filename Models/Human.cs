using System.ComponentModel.DataAnnotations;

namespace Search.Models
{
    public class Human
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(0, 120)]
        public int Age { get; set; }

        public bool Handsome { get; set; }
    }
}
