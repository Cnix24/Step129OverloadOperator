using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step124AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee { firstName = "Sample", lastName = "Student", Id = 1 };
            Employee secondEmployee = new Employee { firstName = "Sample2", lastName = "Student2", Id = 1 };

            Console.WriteLine(employee == secondEmployee);
            employee.SayName();
            employee.Quit();
            Console.ReadLine();
        }
        
    }
}
