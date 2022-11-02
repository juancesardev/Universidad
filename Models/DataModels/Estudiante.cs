using System.ComponentModel.DataAnnotations;

namespace Universidad.Models.DataModels
{
    public class Estudiante : BaseEntity
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        public DateTime Dob { get; set; }
        public ICollection<Curso> Curso { get; set; } = new List<Curso>();

    }
}
