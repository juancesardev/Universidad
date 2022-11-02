using System.ComponentModel.DataAnnotations;

namespace Universidad.Models.DataModels
{
    public enum Level { Basic, Medium, Advanced, Expert}
    public class Curso: BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string ShortDescription { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        public Level Level { get; set; } = Level.Basic; // se inicia cpn el nivel  Básico, y si viene de otro centro de educación?

        [Required]
        public ICollection<Categoria> Categorias { get; set; } = new List<Categoria>();
        [Required]
        public Chapter Chapter { get; set; } = new Chapter();
        [Required]
        public ICollection<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();
    }
}
