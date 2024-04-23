using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstApplication.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Name must be < 20 Character.")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "email must be example@hotmail.com")]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Create Date")]
        public Nullable<DateTime> CreateDate { get; set; }


        public int Age { get; set; }
        public int Year { get; set; }
        public virtual ICollection<StudentCourse> StudentCources { get; set; }
    }
}