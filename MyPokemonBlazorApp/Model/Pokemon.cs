using System.ComponentModel.DataAnnotations;

namespace MyPokemonBlazorApp.Model
{
    public class Pokemon
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        [Range (1, 800, ErrorMessage = "Total must be between 1 and 800")]
        public int Total { get; set; }

        [Required]
        [Range(1, 255, ErrorMessage = "HP must be between 1 and 255")]
        public int HP { get; set; }

        [Required]
        [Range(1, 255, ErrorMessage = "Attack must be between 1 and 255")]
        public int Attack { get; set; }

        [Required]
        [Range(1, 255, ErrorMessage = "Defence must be between 1 and 255")]
        public int Defence { get; set; }

        [Required]
        [Range(1, 255, ErrorMessage = "Speed must be between 1 and 255")]
        public int Speed { get; set; }

        [Required]
        [Range(1, 10, ErrorMessage = "Generation must be between 1 and 10")]
        public int Generation { get; set; }

        [Required]
        public bool Legendary { get; set; }

        public List<Trainer> Trainers { get; set; }
    }
}
