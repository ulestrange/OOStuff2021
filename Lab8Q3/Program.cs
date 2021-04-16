using System;
using System.IO;

namespace Lab8Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] daysTemperatureCount = new int[5];
        }


        static void CreateTempReport()

        {
            string fileToRead = "../../../temp.txt";

            string fileToWrite = "../../../report.txt";

            string lineIn; // will hold data that we read in

            FileStream fsIn = new FileStream(fileToRead, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fsIn);

            FileStream fsOut = new FileStream(fileToWrite, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fsOut);

            sw.WriteLine("{0,10}{1,15}", "Date", "Temperature");

            lineIn = sr.ReadLine(); // read in first line from file

            processData(lineIn);

            // First read in all the temps and 
            // store them in the correct place.


            // Then write out all the temps.


            

            while (lineIn != null) // null signals we are end of the file
            {
                Console.WriteLine(lineIn); // print to screen
               processData(lineIn));

                lineIn = sr.ReadLine(); // read in next line from file
            }

            sr.Close();
            sw.Close();
        }

        static void processData (string lineIn)
        {
            string[] fields = new string[2];
            fields = lineIn.Split(',');

            int temperature = Convert.ToInt32(fields[1]);


        }
    }
}
