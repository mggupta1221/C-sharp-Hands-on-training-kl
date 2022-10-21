using System;
using System.Collections.Generic;//collections are provided
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//need of List<> :array cannot remove the specific element at specific index
namespace BusRouteApplication
{
    public class Program2
    {
        public static void Main()
        {

            List<BusRoute> allRoutes = BusRouteRepository.InitializeRoutes();
            
            Console.WriteLine($"Before Removing:Elements={allRoutes.Count}");
             foreach(BusRoute route in allRoutes)
                    Console.WriteLine($"Route: {route}");
             Console.WriteLine();


            
            //allRoutes.Remove(allRoutes[2]);
            //allRoutes.RemoveAt(2) ;
            allRoutes.RemoveAll(route =>route.Origin.StartsWith("Test"));
             Console.WriteLine($"After Removing:Elements={allRoutes.Count}");
             foreach(BusRoute route in allRoutes)
                    Console.WriteLine($"Route: {route}");
             Console.WriteLine();
        }  
        
    }
}
