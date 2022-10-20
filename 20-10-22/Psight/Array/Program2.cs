using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusRouteApplication
{
    public class Program2
    {
        public static void Main()
        {

            BusRoute[] allRoutes = BusRouteRepository.InitializeRoutes();

            Console.WriteLine("Where DO You Want To Go ?");
            string location=Console.ReadLine();

            BusRoute [] routes = FindBusTo(allRoutes, location); 
            
            if(routes.Length > 0)
            {
                foreach(BusRoute route in routes)
                    Console.WriteLine($"You can Use route {route}");
            }
            else { Console.WriteLine($"No routes go to {location}"); }
        }


        public static BusRoute [] FindBusTo(BusRoute[] routes,string location)
        {
            return Array.FindAll(routes, route => route.Serves(location));
        }
    }
}
