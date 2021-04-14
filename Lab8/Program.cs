using System;
using System.IO;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateTempReport();
        }

        static void WriteSongLine ()
        {

            string filename1 = "../../../song2.txt";
            string filename2 = "song2.txt";
            string filename3 = @"C:\Users\lestr\Desktop\song4.csv";
            string filename4 = "C:\\Users\\lestr\\Desktop\\song5.txt";

            FileStream fs = new FileStream(filename4, FileMode.Create, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("Hello is it me you're lookin for");

            sw.Close();
        }

        static void CreateTempReport ()

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

            sw.WriteLine(FormatLineForReport(lineIn));

            while (lineIn != null) // null signals we are end of the file
            {
                Console.WriteLine(lineIn); // print to screen
                sw.WriteLine(FormatLineForReport(lineIn));

                lineIn = sr.ReadLine(); // read in next line from file
            }

            sr.Close();
            sw.Close();
        }
        
        static string FormatLineForReport (string lineIn)
        {
            string[] fields = new string[2];
            fields = lineIn.Split(',');

            return String.Format("{0,10}{1,15}", fields[0], fields[1]);

        }
    }
}
