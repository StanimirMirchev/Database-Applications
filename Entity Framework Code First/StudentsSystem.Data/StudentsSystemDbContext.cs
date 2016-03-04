using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSystem.Data
{
    using StudentsSystem.Models;
    public class StudentsSystemDbContext : DbContext
    {
         public StudentsSystemDbContext()
            : base("StudentsSystem")
        {
        }

        public IDbSet<Courses> Courses { get; set; }

        public IDbSet<Homework> Homeworks { get; set; }

        public IDbSet<Resources> Resources { get; set; }

        public IDbSet<Students> Students { get; set; }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
    }
}
