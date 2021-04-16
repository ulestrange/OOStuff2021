using System;
using System.IO;

namespace Lab8Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteTempToFile();
        }

        static void WriteTempToFile()
        {
            int runningTotal = 0;
            int countOfTemperatures = 0;


            string lineIn;

            string fileIn = "../../../temp.txt";
            string fileOut = "../../../report.txt";

            FileStream fsIn = new FileStream(fileIn, FileMode.Open, FileAccess.Read);

            FileStream fsOut = new FileStream(fileOut, FileMode.Create, FileAccess.Write);

            StreamReader sr = new StreamReader(fsIn);

            StreamWriter sw = new StreamWriter(fsOut);

            lineIn = sr.ReadLine();

            sw.WriteLine("Temperature Report \n");
            sw.WriteLine("{0,-15} {1,-15}", "Date", "Temperature");


            while (lineIn != null)
            {
                string[] fields = lineIn.Split(',');

                sw.WriteLine("{0,-15} {1,-15}", fields[0], fields[1]);

                runningTotal += Convert.ToInt32(fields[1]);
                countOfTemperatures++;

                lineIn = sr.ReadLine();
            }

            sw.WriteLine("\n Average is {0}", runningTotal / (double)countOfTemperatures);

            sw.Close();
            sr.Close();
        }



    }
}

