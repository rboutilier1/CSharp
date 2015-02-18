using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BasePlusCommissionEmployeeTest
    {
        public static void main( string[] args)
        {
            BasePlusCommissionEmployee employee = new BasePlusCommissionEmployee("Bob", "Lewis", "333-33-3333", 5000.00M, .04M, 300.00M);

            Console.WriteLine("Employee Information obtained by properties and methods: \n");
            Console.WriteLine("First name is {0}", employee.FirstName);
            Console.WriteLine("Last name is {0}", employee.LastName);
            Console.WriteLine("Social security number is {0}", employee.SocialSecurityNumber);
            Console.WriteLine("Gross Sales are {0:C}", employee.GrossSales);
            Console.WriteLine("Commission rate is {0:F2}", employee.CommissonRate);
            Console.WriteLine("Earnings are {0:C}", employee.Earnings());

        }
    }
}
