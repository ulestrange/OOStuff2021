using System;
using System.IO;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateTempReport();
            //WriteSongLine();

            // Console.WriteLine(Read3rdSongLine());

            WriteSongToConsole();
        }

        static void WriteSongToConsole()
        {

            string lineIn;

            string filename = "../../../song2.txt";

            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

            lineIn = sr.ReadLine();



            while (lineIn != null)
            {


                Console.WriteLine(lineIn);
                lineIn = sr.ReadLine();
            }


        }

        static void WriteSongLine()
        {

            string filename1 = "../../../song2.txt";
            string filename2 = "songuna.txt";
            string filename3 = @"C:\Users\lestr\Desktop\song4.csv";
            string filename4 = "C:\\Users\\lestr\\Desktop\\song5.txt";

            FileStream fs = new FileStream(filename1, FileMode.Create, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("Sinne Fianna Fáil,\natá faoi gheall ag Éirinn,\nBuíon dár slua\nthar toinn do ráinig chughainn,\nFaoi mhóid bheith saor/nSeantír ár sinsear feasta,");

            sw.Close();
        }

        static string ReadSongLine()
        {
            string lineIn;

            string filename = "../../../song2.txt";

            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

            lineIn = sr.ReadLine();

            return lineIn;
        }

        static string Read3rdSongLine()
        {
            string lineIn;

            string filename = "../../../song2.txt";

            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

            sr.ReadLine();
            sr.ReadLine();
            lineIn = sr.ReadLine();

            return lineIn;
        }




    }
}
