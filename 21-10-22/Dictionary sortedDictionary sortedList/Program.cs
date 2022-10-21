using System;
using System.Collections.Generic;//collections are provided

using System.Linq;
using System.Text;
using System.Threading.Tasks;
//need of List<> :array cannot remove the specific element at specific index
namespace BusRouteApplication
{
    public class Program
    {
        public static void Main()
        {

          /*  Dictionary<int,BusRoute> allRoutes = BusRouteRepository.InitializeRoutes();      //or       //var  allRoutes = BusRouteRepository.InitializeRoutes();
 
            Console.WriteLine($"Which Route no. do you want to look up?");
            int number=int.Parse(Console.ReadLine());
             //   var answer=allRoutes[number]; //searches the key in dictionary and retuns it if found otherwise throws an exception

              //  bool success=allRoutes.ContainsKey(number); //check is specific is present in dictionary or not
                bool successSorted=allRoutes.ContainsKey(number); //cific key is present in dictionary or not


             //   bool success1=allRoutes.TryGetValue(number, out BusRoute answer); //checks number ==key present and if present returns the answer

            
                
            if (success)
            {
                Console.WriteLine($"The route u Asked for is {allRoutes[number]}");
            }
            else
            {
                Console.WriteLine($"There are no route with Number:{number}");
            }
         
            Console.WriteLine();
            //enumerating through dictionary

            foreach(var route in allRoutes.Keys)    //to get only keys
            {
                Console.WriteLine(route);
            }

            Console.WriteLine();
            foreach(var route in allRoutes.Values)    //to get only values
            {
                Console.WriteLine(route);
            }
            Console.WriteLine();
            foreach(var route in allRoutes)    //to get only keys,values
            {
                Console.WriteLine(route);

            }
            */
































            /*
            SortedDictionary<int,BusRoute> allRoutesSorted = BusRouteRepository.InitializeRoutes();      //or       //var  allRoutesSorted = BusRouteRepository.InitializeRoutes();
            Console.WriteLine($"Which Route no. do you want to look up?");
            int number=int.Parse(Console.ReadLine());
             //   var answer=allRoutesSorted[number]; //searches the key in dictionary and retuns it if found otherwise throws an exception
              //  bool success=allRoutesSorted.ContainsKey(number); //check is specific is present in dictionary or not
                bool successSorted=allRoutesSorted.ContainsKey(number); //cific key is present in dictionary or not
             //   bool success1=allRoutesSorted.TryGetValue(number, out BusRoute answer); //checks number ==key present and if present returns the answer  
            if (successSorted)
            {
                Console.WriteLine($"The route u Asked for is {allRoutesSorted[number]}");
            }
            else
            {
                Console.WriteLine($"There are no route with Number:{number}");
            }        
            Console.WriteLine();
            //enumerating through dictionary
            foreach(var route in allRoutesSorted.Keys)    //to get only keys
            {
                Console.WriteLine(route);
            }
            Console.WriteLine();
            foreach(var route in allRoutesSorted.Values)    //to get only values
            {
                Console.WriteLine(route);
            }
            Console.WriteLine();
            foreach(var route in allRoutesSorted)    //to get only keys,values
            {
                Console.WriteLine(route);

            }            

            */











            SortedList<int,BusRoute> allRoutesSortedList = BusRouteRepository.InitializeRoutes();      //or       //var  allRoutesSorted = BusRouteRepository.InitializeRoutes();
            Console.WriteLine($"Which Route no. do you want to look up?");
            int number=int.Parse(Console.ReadLine());
             //   var answer=allRoutesSorted[number]; //searches the key in dictionary and retuns it if found otherwise throws an exception
              //  bool success=allRoutesSorted.ContainsKey(number); //check is specific is present in dictionary or not
                bool successSortedList=allRoutesSortedList.ContainsKey(number); //cific key is present in dictionary or not
             //   bool success1=allRoutesSorted.TryGetValue(number, out BusRoute answer); //checks number ==key present and if present returns the answer  
            if (successSortedList)
            {
                Console.WriteLine($"The route u Asked for is {allRoutesSortedList[number]}");
            }
            else
            {
                Console.WriteLine($"There are no route with Number:{number}");
            }        
            Console.WriteLine();
            //enumerating through dictionary
            foreach(var route in allRoutesSortedList.Keys)    //to get only keys
            {
                Console.WriteLine(route);
            }
            Console.WriteLine();
            foreach(var route in allRoutesSortedList.Values)    //to get only values
            {
                Console.WriteLine(route);
            }
            Console.WriteLine();
            foreach(var route in allRoutesSortedList)    //to get only keys,values
            {
                Console.WriteLine(route);

            }            
        }         
    }
}
