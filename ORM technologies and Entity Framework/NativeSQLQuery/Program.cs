using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NativeSQLQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = NativeSqlQuery.SelectEmployeesIn2002NativeQuery();
            foreach (var employee in employees)
            {
                 Console.WriteLine("{0}. {1}", employee.EmployeeID, employee.FirstName);
            }
        }
    }
}
