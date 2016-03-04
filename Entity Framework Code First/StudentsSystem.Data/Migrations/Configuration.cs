namespace StudentsSystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using StudentsSystem.Models;
    public sealed class Configuration : DbMigrationsConfiguration<StudentsSystem.Data.StudentsSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            ContextKey = "StudentsSystem.Data.StudentsSystemDbContext";
        }

        protected override void Seed(StudentsSystem.Data.StudentsSystemDbContext context)
        {
            var student = new Students
            {
                Name = "Marin",
                PhoneNumber = "08213",
                RegistrationDate = new DateTime(2014, 02, 3),
                Birthday = new DateTime(2015, 01, 01)
            };

            context.Students.Add(student);
            context.SaveChanges();

            var student1 = new Students
            {
                Name = "Martin",
                PhoneNumber = "08213432",
                RegistrationDate = new DateTime(2014, 06, 6),
                Birthday = new DateTime(2015, 01, 11)
            };

            context.Students.Add(student1);
            context.SaveChanges();

            var student2 = new Students
            {
                Name = "Petko",
                PhoneNumber = "08213432432",
                RegistrationDate = new DateTime(2014, 02, 3),
                Birthday = new DateTime(2015, 01, 01)
            };

            context.Students.Add(student2);
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
