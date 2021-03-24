using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class Employee
    {

        public static int lastEmployeeNumber;
        public string Name { get; set; }
        public string Gender { get; set; }
        public int EmployeeNumber { get; set; }
        public decimal HourlyRate { get; set; }

        private string nationality;

        public string Nationality
        {
            get { return nationality; }
            set
            {
                if (value == "British")
                { nationality = "Visa Required"; }
                else
                { nationality = value; }
            }
        }


        //default constructor
        public Employee()
        {
            lastEmployeeNumber++;
            EmployeeNumber = lastEmployeeNumber;
        }
        //parameterised constructor
        public Employee(string name, string gen, decimal payRate, string nat)
        {
            Name = name;
            Gender = gen;
            HourlyRate = payRate;
            lastEmployeeNumber++;
            EmployeeNumber = lastEmployeeNumber;
            Nationality = nat;
        }
        //method
        public override string ToString()
        {
            return String.Format("Name is {0}, Gender is {1}, Rate is {2}, " +
                 "Number is {3}, Nationality is {4}",
                 Name, Gender, HourlyRate, EmployeeNumber, Nationality); ;

        }

        public virtual decimal CalcPay()
        {
            return 40 * HourlyRate;
        }

        public virtual decimal CalcTax()
        {
            return (CalcPay() * .4m) ;
        }
    }

}
