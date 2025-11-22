using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { set; get; }

        [MinLength(5)]
        [MaxLength(50)]
        public string StudentName { set; get; }
        public bool IsActive { set; get; }
        [Range(5,100)]
        public int StudentAge { set; get; }

        public string PhotoName { set; get; }
    }
}
