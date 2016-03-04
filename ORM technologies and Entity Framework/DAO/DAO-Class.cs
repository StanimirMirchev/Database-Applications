using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    using Entity_Framework;
    class DAO_Class
    {
        public static int CreateNewEmployee(string FirstName, string LastName, string JobTitle,
                                           int DepartmentId, DateTime HireDate, decimal Salary)
        {
            var softUniEntities = new SoftUniEntities();
            var newEmployee = new Employee
            {
                FirstName = FirstName,
                LastName = LastName,
                JobTitle = JobTitle,
                DepartmentID = DepartmentId,
                HireDate = HireDate,
                Salary = Salary
            };

            softUniEntities.Employees.Add(newEmployee);
            softUniEntities.SaveChanges();

            return newEmployee.EmployeeID;
        }

        public static void UpdateEmployee(int EmployeeId, string newFirstName, string newLastName, string newJobTitle, int newDepartmentID, DateTime newHireDate, decimal newMoney)
        {
            var softUniEntities = new SoftUniEntities();
            Employee employee = GetEmployeeById(softUniEntities, EmployeeId);

            employee.FirstName = newFirstName;
            employee.LastName = newLastName;
            employee.JobTitle = newJobTitle;
            employee.DepartmentID = newDepartmentID;
            employee.HireDate = newHireDate;
            employee.Salary = newMoney;

            softUniEntities.SaveChanges();
        }

        public static void DeleteProduct(int EmployeeId)
        {
            var softUniEntities = new SoftUniEntities();
            Employee employee = GetEmployeeById(softUniEntities, EmployeeId);
            softUniEntities.Employees.Remove(employee);
            softUniEntities.SaveChanges();
        }

        public static Employee GetEmployeeById(SoftUniEntities entity, int EmployeeId)
        {
            Employee employee = entity.Employees
                .FirstOrDefault(p => p.EmployeeID == EmployeeId);

            return employee;
        }
    }
}
