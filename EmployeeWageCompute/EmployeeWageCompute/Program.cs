using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCompute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.Attendance();
            EmployeeWage employeeWage1 = new EmployeeWage();
            employeeWage1.DailyWages();

        }
    }
}
