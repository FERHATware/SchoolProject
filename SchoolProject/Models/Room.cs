using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolProject.Models
{
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomId { set; get; }

        [MaxLength(50)]
        [MinLength(5)]
        public string RoomName { set; get; }

        [Range(0,25)]
        public int Capisity { set; get; }
    }
}
