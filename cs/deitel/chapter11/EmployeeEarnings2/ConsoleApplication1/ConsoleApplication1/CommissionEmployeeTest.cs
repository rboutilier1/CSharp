﻿using System;

    class CommissionEmployeeTest
    {
        static void Main(string[] args)
        {
            CommissionEmployee employee = new CommissionEmployee("Sue", "Jones", "222-22-2222", 10000.00M, .06M);

            // display commission data
            Console.WriteLine("Employee information obtained by properties and methods:\n");
            Console.WriteLine("First Name is {0}", employee.FirstName);
            Console.WriteLine("Last Name is {0}", employee.LastName);
            Console.WriteLine("Social Security number is {0}", employee.SocialSecurityNumber);
            Console.WriteLine("Gross Sales are {0:C}", employee.GrossSales);
            Console.WriteLine("Commission Rate is {0:F2}", employee.CommissionRate);
            Console.WriteLine("Earning are {0:C}", employee.Earnings());

            employee.GrossSales = 5000.00M;
            employee.CommissionRate = .1M;

            Console.WriteLine("\n:{0}\n\n{1}", "Updated employee information obtained by ToString", employee);
            Console.WriteLine("earnings: {0:C}", employee.Earnings());

        }
    }
