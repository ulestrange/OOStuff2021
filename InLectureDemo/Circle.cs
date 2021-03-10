using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InLectureDemo
{
    class Circle
    {
		private int radius;

		public int Radius
		{
			get { return radius; }
			set { radius = value; }
		}

		public Circle()
		{
			Radius = 1;
		}

		public Circle(int inputRadius)
		{
			Radius = inputRadius;
		}

		public double GetArea()
		{
			return radius * radius * 3.14;
		}







	}
}
