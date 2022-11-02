using System.ComponentModel.DataAnnotations;

namespace Universidad.Models.DataModels
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; } = String.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string UpdatedBy { get; set; } = String.Empty;
        public string? UpdatedAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string DeleteBy { get; set; } = String.Empty;
        public DateTime? DeleteAt { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
/*
         [Required]
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User CreatedBy { get; set; } = new User();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public User UpdatedBy { get; set; } = new User();
        public DateTime? UpdateAt { get; set; }
        public User DeleteBy { get; set; } = new User();
        public DateTime? DeleteAt { get; set; }
        public bool IsDeleted { get; set; } = false;
 
 */