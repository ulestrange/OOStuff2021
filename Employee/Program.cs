using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee myEmp = new Employee();

            myEmp.Name = "Una L'Estrange";
            myEmp.Gender = "Female";
            myEmp.HourlyRate = 500;

            Console.WriteLine(myEmp.ToString());

            Employee secondEmp = new Employee("Viv", "Male", 10, "British");

            Console.WriteLine(secondEmp.ToString());

            Console.WriteLine("Tax is {0}", myEmp.CalcTax());
            Console.WriteLine("Tax is {0}", secondEmp.CalcTax());
        }
    }
}
