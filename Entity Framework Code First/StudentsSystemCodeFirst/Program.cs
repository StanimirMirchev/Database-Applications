using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsSystemCodeFirst.ConsoleClient
{
    using StudentsSystem.Data;
    using StudentsSystem.Models;
    using System.Data.Entity;
    using StudentsSystem.Data.Migrations;
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentsSystemDbContext, Configuration>());
           var db = new StudentsSystemDbContext();
           db.Students.Add(new Students
            {
                Name = "Gosho",
                PhoneNumber = "0885331155",
                RegistrationDate = DateTime.Now,
                Birthday = DateTime.Now
            });

            db.SaveChanges();
           

           
           db.Courses.Add(new Courses
           {
              Name = "C++",
              Description ="mnogo zdrav",
              StartDate = new DateTime(2011, 02, 03),
              EndDate = new DateTime(2012, 02, 07),
              Price = 1500
           });

           db.SaveChanges();
           

           db.Homeworks.Add(new Homework
           {
               Content = "10 zadachi",
               HomeworkContentType = ContentType.zip,
               DateAndTime = DateTime.Now,
               StudentId = 1,
               CoursesId = 1

           });

           db.SaveChanges();

           db.Homeworks.Add(new Homework
           {
               Content = "15 zadachi",
               HomeworkContentType = ContentType.pdfOrApplication,
               DateAndTime = DateTime.Now,
               StudentId = 2,
               CoursesId = 1
           });

           db.SaveChanges();
        }
    }
}
