using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Rectangle
    {

        //the method defination of perimeter and area is same
        public double getArea(double length, double breadth)
        {
            return (length * breadth);
        }

        public double getPerimeter(double length, double breadth)
        {
            return (2 * (length + breadth));
        }

        public delegate double rectangleDelegate(double lengthOfRectangle, double breadthOfrectangle);



        public static void Main()
        {
            Rectangle rect = new Rectangle();


            rectangleDelegate rectangleDelegateObject = new rectangleDelegate(rect.getArea);
            //or
            //rectangleDelegate rectangleDelegateobject = rect.getArea;//wihhout calling constructor also we can define

            rectangleDelegateObject += rect.getPerimeter; //result of first overriden by second so in multicast delegates it is good to use void type of methods


            double x = rectangleDelegateObject(33, 1);
            Console.WriteLine(x);

        }
    }
}

