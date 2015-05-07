using System;

class BasePlusCommissionEmployeeInherits : CommissionEmployee
{
    private decimal baseSalary;

    public BasePlusCommissionEmployeeInherits(string first, string last, string ssn, decimal sales, decimal rate, decimal salary) : base(first, last, ssn, sales, rate) 
    {

    }
}

