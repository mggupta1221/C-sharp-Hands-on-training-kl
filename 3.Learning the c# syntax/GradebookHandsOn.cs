//c# hands on from 1.C# fundamental
internal class Program
{
    private static void Main(string[] args)
    {
        
        var result=0.0;
        var grades= new List<double>() { 22.5,11.2,45.3,67.5};
        grades.Add(56.8);
        Console.WriteLine(grades.Count);
        foreach (var grade in grades) {
            result += grade;
        }
        Console.WriteLine($"average is:{result/grades.Count:N4}");
       
    }
}


//var is used to define type at compile time
//dynamic is used to define tye of variable at runtime
//array has fixed size that can not be inv=creased or decreased so we use list fron collection.generics which is changeable type of array 
//we declare list with wrapper classes

//foreach loop is advanced version of for loop
    //syntax of for loop
            // foreach(type variable in array/list){} eg foreach(var x:str){} str is string array at compile time the type string will be assigned to x