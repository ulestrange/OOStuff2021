using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {

            PartTimeEmployee emp1 = new PartTimeEmployee();

            Console.WriteLine(emp1.ToString());

            //    Employee[] myEmpire = new Employee[5];


            //    Employee myEmp = new Employee();

            //    myEmp.Name = "Una L'Estrange";
            //    myEmp.Gender = "Female";
            //    myEmp.HourlyRate = 500;

            //    Console.WriteLine(myEmp.ToString());

            //    Employee secondEmp = new Employee("Viv", "Male", 10, "British");

            //    Console.WriteLine(secondEmp.ToString());

            //    Console.WriteLine("Tax is {0}", myEmp.CalcTax());
            //    Console.WriteLine("Tax is {0}", secondEmp.CalcTax());

            //    myEmpire[0] = myEmp;
            //    myEmpire[1] = secondEmp;
            //    myEmpire[2] = new PartTimeEmployee("Kevin", "Male", 30, "French", 10);
            //    myEmpire[3] = new Employee("Mary Loftus", "Female", 20, "Irish");
            //    myEmpire[4] = new PartTimeEmployee("Drew", "Male", 30, "Irish", 20);

            //    secondEmp.Name = "Vivian";
            //    myEmpire[1].HourlyRate = 1000;

            //    for (int i = 0; i < myEmpire.Length; i++)
            //    {
            //        string name = myEmpire[i].Name;
            //        decimal pay = myEmpire[i].CalcPay();


            //        Console.WriteLine("{0} is owed {1}", name, pay);
            //    }
            //}
        }
    }
}
