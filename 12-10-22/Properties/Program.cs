using System;
using System.Runtime.CompilerServices;

namespace Properties
{
    public class Program
    {



        //public string name;//name accessible from anywhere field is not secured

        //private string name; //to get access to this field from anyewhere noe we require public methods setter(set a value) ang getter(return a value)
        //public void setName(string name)
        //{
        //    this.name = name;
        //}
        //public string getName()
        //{
        //    return name;
        //}

        //in c# made easier to assign and get value of field by using property
        //private string name;
        //public string Name
        //{
        //    get //what will user get when wante to access name
        //    {

        //        return name; 
        //    }
        //    set
        //    {

        //        name = value; //implicit value     if program p=new progam() and p.name="Mukesh" them value="mukesh" set to name 
        //        if (!string.IsNullOrEmpty(value)) //can also provide conditions in it
        //        {
        //            name = value;
        //        }
        //    }
        //}





        ////c# made it shorter with backing field declared by compiler

        //public String Name { get; set; } //Convention use pascalcase for property
        //static void Main(string[] args)
        //{
        //    Program p = new Program();
        //    p.Name = "asas";
        //    Console.WriteLine(p.Name);
        //}



        //public string Name { get; private set; }  //made Name readonly to another classes another classes can access the value but not change it
        //static void Main(string[] args)
        //{
        //    Program p = new Program();
        //    p.Name = "asas";
        //    Console.WriteLine(p.Name);
        //}


        ////readonly string Subject = "Science"; //readonly can be intialized at time of declaration or can be only defined in constructor
        //readonly string ?subject2;
        ////subject2="math";       //error
        //public Program(string subject)
        //{
        //    subject2 = subject;
        //}
        //static void Main(string[] args)
        //{
        //        Program objProgram = new Program("Science");     
        //        Console.WriteLine(objProgram.subject2);
        //}

        //const keyword  ///no need to make it private as const cannot be changed convention capitalize the cost field |const static member of classs
        //const: make public always static:accessed by classname
    }
}