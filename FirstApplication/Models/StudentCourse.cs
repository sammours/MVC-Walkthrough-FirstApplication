using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApplication.Models
{
    public class StudentCourse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}