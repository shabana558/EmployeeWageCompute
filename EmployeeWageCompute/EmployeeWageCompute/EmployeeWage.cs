using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompute
{
    public class EmployeeWage
    {
        public void Attendance()
        {
            //UC1 check employee present or absent
            Random random = new Random();
            int fullTimeEmployee = 1;
            int randomInput = random.Next(0, 2);

            if (randomInput == fullTimeEmployee)
            {


                //block of code to be executed if condition is true//
                Console.WriteLine("Employee is present");



            }
            else
            {
                //block of code to be executed if condition is false//
                Console.WriteLine("employee is absent");

                Console.ReadLine();

            }
        }
    }
}
