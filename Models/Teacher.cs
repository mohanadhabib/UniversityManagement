using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string? Name { get; set; }
        [Required]
        public int Ssn { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [MaxLength(6)]
        public string? Gender { get; set; }
        public string? Phone { get; set; }
        [Required]
        public float Salary { get; set; }
    }
}
