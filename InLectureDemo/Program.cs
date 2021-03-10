using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InLectureDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle roundy = new Circle();

            roundy.Radius = 10;


            Rectangle box1;// declare variable of type rectangle
            box1 = new Rectangle(); // creating an object of type  Rectangle

            box1.Length = 10; // assgn value to the length attribute
            box1.Width = 30;
            int area = box1.CalcArea();

            Console.WriteLine("the area  box1 = {0}", area);
            Console.WriteLine(box1.ToString()); // call the toString method to get info about the object


            Rectangle box2;
            box2 = new Rectangle();
            box2.Length = 6;
            box2.Width = 8;
            
           // box2.length = 6;
           // box2.width = 8;
            area = box2.CalcArea();
            Console.WriteLine("the area of box 2 {0}", area);

            Rectangle box3;
            box3 = new Rectangle(5, 10);

            area = box3.CalcArea();
            Console.WriteLine("the area of box3 {0}", area);

        }
    }
}
