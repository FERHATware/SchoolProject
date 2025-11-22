using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Models
{
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherId { set; get; }

        [MinLength(5)]
        [MaxLength(50)]
        public string TeacherName { set; get; }

        [Range(5,100)]
        public int TeacherAge{set ; get;}
    }
}
