
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Models
{
    

    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { set; get; }

        [MinLength(5)]
        [MaxLength(50)]
        public string CourseName { set; get; }

        [Range(0 , 25)]
        public int CourseCapisity{ set ; get; }


        public int TeacherId { set; get; }
        public Teacher Teacher { set; get; }
    }
}
