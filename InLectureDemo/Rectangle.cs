using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InLectureDemo
{
    class Rectangle
    {
        private int length;

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        private int width;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }



        //public int Length { get; set; }

        //// attributes of the class
        //// will will need to make these private - in a later lesson
        //private int length;
        //private int width;



        //// methods
        //// constructor method - must call this before we can use the class
        public Rectangle()
        {
            // creates an object with no values assigned to attributes
        }

        public Rectangle(int l, int w)
        {
            // creates an object with values assigned to attributes
            length = l;
            width = w;


        }


    //public int GetLenght()
    //{
    //    return length;

    //}

    //public void SetLength(int inputLength)
    //{
    //    length = inputLength;

    //}

    //public int GetWidth()
    //{
    //    return width;

    //}

    //public void SetWidth(int inputWidth)
    //{
    //    length = inputWidth;

    //}

    public int CalcArea()
        {
            return length * width;

        }


        public override string ToString() // special methods that tells us about the object
        {
            return String.Format("Length: {0} /n Width: {1}",length, width);
        }
    }
}
