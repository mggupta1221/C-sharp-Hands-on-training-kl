//using BusRouteApplication;
//using System;

//namespace ShowBusRoute
//{
//    public class Route
//    {
//        public static void Main()
//        {
//            BusRoute route40 = new BusRoute(40, "Latur", "Pune");

//            BusRoute route42 = new BusRoute(42, "Pune", "Mumbai");

//            BusRoute[] routes =
//            {
//                route40,
//                route42,
//                new(324,"bhosari","HInjewadi Phase 3")
//            };


//            Console.WriteLine("Getting Route:By Iterating using foreach loop");
//            //getting routes by iterating over it
//            foreach (BusRoute route in routes) //iterating/Enumerating over array using foreach
//            {
//                Console.WriteLine(route);

//            }

//            Console.WriteLine();
//            Console.WriteLine("Getting Route:By Iterating using for Loop");
//            for (int count= 0;count < routes.Length;count++) //iterating/Enumerating over array using for loop
//            {
//                Console.WriteLine($"{count}:{routes[count]}");

//            }



//            Console.WriteLine();
//            Console.WriteLine("Getting Route:By Index");
//            //getting routes by using index
//            Console.WriteLine(route42);
//            Console.WriteLine($"Second Last Route is: {routes[^2]}"); // routes[routes.length-2]
//            Console.WriteLine($"Last Route is: {routes[^1]}"); // routes[routes.length-1]


//        }
//    }
   
//}

