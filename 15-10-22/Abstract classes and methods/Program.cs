using System;
namespace Abstract_clases_and_methods
{
    public abstract class Figure  // abstract methods can contain abstract and non abstract methosd it is must for child to override all abstract methods fron parent abstracyt class
    {
        public double length, breadth, radius,height;
        public const double pi = 3.142;

        public abstract double GetArea(); //method name/signature will be same in all derived //it must be overridden in child class
        public void names()
        {

        }
    }
    //child can consume non abstract methods only if it has implemented all the abstract methods in parent abstract class
    public class Rectangle : Figure
    {

        public Rectangle(double length,double breadth)
        {
            this.length = length;       
            this.breadth = breadth;
        }
        public override double GetArea()
        {
            return length * breadth;
        }
    }


    public class Circle : Figure
    {

        public Circle(double radius)
        {
            this.radius = radius;
          
        }
        public override double GetArea()
        {
            return pi * radius * radius; ;
        }
    }


    public class Cylinder : Figure
    {

        public Cylinder(double radius,double height)
        {
            this.height = height;
            this.radius = radius;
        }
        public override double GetArea()
        {
            return 2*pi*((radius*height)+(radius*radius));
        }
    }

    public class Program
    {
        public static void Main()
        {
            Rectangle rectangleObj = new Rectangle(2.3, 4.5);
            Circle circleObj = new Circle(8.9);
            Cylinder cylinderObj = new Cylinder(4.5, 5.6);

            double areaOfRectangle = rectangleObj.GetArea();
            double areaOfCircle = circleObj.GetArea();
            double areaOfCylinder = cylinderObj.GetArea();

            Console.WriteLine($" Area Of Rectangle:{areaOfRectangle}\n Area OfCircle:{areaOfCircle}\n Area of Cylinder:{areaOfCylinder} ");

        }
    }
}