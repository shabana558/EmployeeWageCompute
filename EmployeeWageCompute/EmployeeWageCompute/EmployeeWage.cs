using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompute
{
    public class EmployeeWage
    {
        public void MaximumDays()
        { }
            
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int Emp_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
       

        public static int EMP_RATE_PER_HOUR { get; private set; }

        static void Main(string[] args)
        {
            //variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //computation
           for(int day=0;day<NUM_OF_WORKING_DAYS;day++)
            {
              
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)

                {
                    case PART_TIME:
                        empHrs = 4;
                        break;
                    case FULL_TIME:
                        //code block
                        empHrs = 8;
                        break;
                    default:
                        //code block
                        //numb of hrs working in a day.
                        empHrs = 0;
                        break;


                }
                EmpWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += EmployeeWage;
                Console.WriteLine("Emp Wage :"+ empWage);

               
                Console.WriteLine("Total Emp Wage :" + totalEmpWage);



            }


        }
    }

}      
      

  
   


