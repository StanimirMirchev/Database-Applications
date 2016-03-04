using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    using Entity_Framework;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("New Employee!");
            int newEmployeeID = DAO_Class.CreateNewEmployee("Georgi", "Georgiev", "Soldier", 1, new DateTime(2015, 03, 22), 550);

            Console.WriteLine("Update Employee!");
            DAO_Class.UpdateEmployee(newEmployeeID, "Marinkin", "Georgiev", "Soldier", 1, new DateTime(2015, 03, 22), 550);

            Console.WriteLine("Delete Employee!");
            DAO_Class.DeleteProduct(newEmployeeID - 1);



        }
    }
}
