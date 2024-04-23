using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FirstApplication.Models
{
    public class MvcContext : DbContext
    {
        public MvcContext()
            : base(@"data source=(LocalDb)\MSSQLLocalDB;initial catalog=MvcCourse;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;")
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentCourse> StudentCourses { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
    }
}