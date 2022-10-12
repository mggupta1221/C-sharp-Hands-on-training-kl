

public class Rectangle
{

    //the method defination of perimeter and area is same
    public void getArea(double length, double breadth)
    {
        Console.WriteLine("Area Of rectangle:" + (length * breadth));
    }

    public void getPerimeter(double length, double breadth)
    {
        Console.WriteLine("perimeter Of rectangle:" + (2 * (length + breadth)));
    }

    public delegate void rectangleDelegate(double lengthOfRectangle, double breadthOfrectangle);



    public static void Main()
    {
        Rectangle rect = new Rectangle();


        rectangleDelegate rectangleDelegateObject = new rectangleDelegate(rect.getPerimeter);
        //or
        //rectangleDelegate rectangleDelegateobject = rect.getArea;//wihhout calling constructor also we can define

        rectangleDelegateObject += rect.getArea;

        rectangleDelegateObject.Invoke(32.5, 33); //both methods get called 1.getArea 2.getPerimeter whichever added first gets called first
        Console.WriteLine();
        rectangleDelegateObject.Invoke(100, 56.8);

    }
}