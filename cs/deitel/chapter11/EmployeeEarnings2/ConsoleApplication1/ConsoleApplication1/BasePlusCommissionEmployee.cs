using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BasePlusCommissionEmployee
    {
        private string firstName;
        private string lastName;
        private string socialSecurityNumber;
        private decimal grossSales;
        private decimal commissionRate;
        private decimal baseSalary;

        public BasePlusCommissionEmployee(string first, string last, string ssn, decimal sales, decimal rate, decimal salary)
        {
            firstName = first;
            lastName = last;
            socialSecurityNumber = ssn;
            grossSales = sales;
            commissionRate = rate;
            baseSalary = salary;
        }

        public string LastName
        {
            get
            {
                return firstName;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        public string SocialSecurityNumber
        {
            get
            {
                return socialSecurityNumber;
            }
        }

        public decimal GrossSales
        {
            get
            {
                return grossSales;
            }
            set
            {
                if (value >= 0)
                    grossSales = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
