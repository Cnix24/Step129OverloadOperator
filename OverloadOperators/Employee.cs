using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step124AbstractClasses
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public override void SayName()
        {
            Console.WriteLine(firstName +" "+ lastName +" "+ Id);
        }

        public void Quit()
        {
            Console.WriteLine("I quit.");
        }

        //public static bool operator ==(Employee employee, Employee Id)
        //{
        //    if (employee.Id.Equals(employee.Id))
        //    {
        //        return true;
        //    }
        //    return employee.Id == employee.Id;
        //}
        //public static bool operator !=(Employee employee, Employee Id)
        //{
        //    return !(employee.Id == employee.Id);
        //}

        public static bool operator ==(Employee x, Employee y)
        {
       
            return x.Id == y.Id;
        }

        public static bool operator !=(Employee x, Employee y)
        {
            return !(x == y);
        }

    }
}
