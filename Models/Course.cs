using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public  class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string? Name { get; set; }
        [Required]
        public int CreditHours { get; set; }    
        public Teacher? Teacher { get; set; }

        [Required]
        public int TeacherId { get; set; }  
    }
}
