using StudentsSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSystem.Data.Repositories
{
    class StudentRepository : GenericRepository<Students>, IStudentRepository
    {
         public StudentRepository(StudentsSystemDbContext context) 
            : base(context)
        {
        }

     //    public IQueryable<Students> ListAllStudentsAndHomework()
      //   {
          //  var innerJoinQuery =
            //    from student in Students 
             //   join homework in Homework on Students.Id equals homework.StudentId
              //  select 
       //  }
    }
}
