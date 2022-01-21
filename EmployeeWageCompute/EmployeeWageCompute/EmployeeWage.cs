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
        public void DailyWages()
        {

            //UC2 check employee present or absent
            Random random = new Random();
            int fullTimeEmployee = 1;
            //Next method is used for generating random input from 0 to 2.//
            int randomInput = random.Next(0, 2);
            int empRatePerHr = 20;
            int empHrs = 0;
            int totalWage=0;

            if (randomInput == fullTimeEmployee)
            {


                //block of code to be executed if condition is true//
                Console.WriteLine("Employee is present");
                //number of hours working in a day.
                empHrs = 8;
            }
            else
            {
                //block of code to be executed if condition is false//
                Console.WriteLine("employee is absent");
                empHrs = 0;

            }
            //formula for calculating employee daily wage
            totalWage = empRatePerHr * empHrs;
            Console.WriteLine("Dailywage is:"+totalWage);
            Console.ReadLine();
        }

        public void EmployeeParttime()
        {
            //UC2 check employee present or absent
            Random random = new Random();
            int fullTimeEmployee = 1;
            int partTimeEmployee = 2;
            //Next method is used for generating random input from 0 to 2.//
            int randomInput = random.Next(0, 2);
            int empRatePerHr = 20;
            int empHrs = 0;
            int totalWage = 0;

            if (randomInput == fullTimeEmployee)
            {


                //block of code to be executed if condition is true//
                Console.WriteLine("Employee is present");
                //number of hours working in a day.
                empHrs = 8;
            }

            else if (randomInput== partTimeEmployee)

            {
             

            }
            else
            {
                //block of code to be executed if condition is false//
                Console.WriteLine("employee is absent");
                empHrs = 0;

            }
            //formula for calculating employee daily wage
            totalWage = empRatePerHr * empHrs;
            Console.WriteLine("Dailywage is:" + totalWage);
            Console.ReadLine();
        }

        
        

        
    }
}

