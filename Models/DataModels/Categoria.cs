﻿using System.ComponentModel.DataAnnotations;

namespace Universidad.Models.DataModels
{
    public class Categoria : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<Curso> Cursos { get; set; } = new List<Curso>();
    }
}
