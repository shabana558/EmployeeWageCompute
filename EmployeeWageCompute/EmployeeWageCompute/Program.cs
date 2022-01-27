﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompute
{
    internal class Program
    {

       static void Main(string[] args)
        
        
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int Emp_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_HRS_IN_MONTH = 10;

        public static int computeEmpWage()
        {

            //variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //computation
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs :" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * Emp_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);
            return totalEmpWage;

        }
        }
    }

    

