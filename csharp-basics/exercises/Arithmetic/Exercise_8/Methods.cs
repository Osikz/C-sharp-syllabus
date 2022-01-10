using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    public class Methods
    {
        public static string CalculatePay(double payRate, int hours)
        {
            if (payRate < 8.00 || hours > 60)
            {
                return "Something is not right here...";
            }
            else if (hours <= 40)
            {
                return $"Employee earned {Math.Round(payRate * hours, 2)}$ this week.";
            }
            else if (hours > 40)
            {
                int overtime = hours - 40;
                double overtimePayRate = payRate * 1.5;
                return $"Employee earned {Math.Round(payRate * 40 + overtime * overtimePayRate, 2)}$ this week.";
            }
            else
            {
                return "Something went wrong..";
            }
        }
    }
}
