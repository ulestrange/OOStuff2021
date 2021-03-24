using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class PartTimeEmployee : Employee
    {
        public int HoursWorked { get; set; }


        public PartTimeEmployee() : base()
        {
        }

        public PartTimeEmployee(string name, string gen, decimal payRate, string nat,
            int hrsWorked) : base (name, gen, payRate, nat)
        {
            HoursWorked = hrsWorked;
        }

        public override decimal CalcPay()
        {
            return (HoursWorked * HourlyRate);
        }

        public override string ToString()
        {
           return ( base.ToString() + ", Hours Worked " + HoursWorked);
        }
    }


}
