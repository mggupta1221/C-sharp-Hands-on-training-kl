using System;


namespace BusRouteApplication
{
    public class BusRouteRepository
    {


      /*  public static Dictionary<int,BusRoute> InitializeRoutes()
        {
           
          
                BusRoute route40=(new BusRoute(40,new string []{"Morcambe","Lancaster","Garstang","Preston"}));
                 BusRoute route42=(new BusRoute(42,new string []{ "Lancaster", "Garstang","Blackpool"}));
                BusRoute route100=(new BusRoute(100,new string []{"University", "Lancaster", "Morecambe" }));
                 BusRoute route555=(new BusRoute(555,new string []{ "Lancaster","Carnforth","Kendel","Windermere","Keswik"}));
                BusRoute route5=(new BusRoute(5,new string []{ "Overton","Morcambe","Carnforth"}));



            var routes = new Dictionary<int,BusRoute>();
            routes.Add(42,route42);
             routes.Add(40,route40);
             routes.Add(100,route100);
             routes.Add(555,route555);
             routes.Add(5,route5);

            return routes;
        }
        */



     /*   public static SortedDictionary<int,BusRoute> InitializeRoutes()
        {
           
          
                BusRoute route40=(new BusRoute(40,new string []{"Morcambe","Lancaster","Garstang","Preston"}));
                 BusRoute route42=(new BusRoute(42,new string []{ "Lancaster", "Garstang","Blackpool"}));
                BusRoute route100=(new BusRoute(100,new string []{"University", "Lancaster", "Morecambe" }));
                 BusRoute route555=(new BusRoute(555,new string []{ "Lancaster","Carnforth","Kendel","Windermere","Keswik"}));
                BusRoute route5=(new BusRoute(5,new string []{ "Overton","Morcambe","Carnforth"}));



            var routes = new SortedDictionary<int,BusRoute>();
            routes.Add(42,route42);
             routes.Add(40,route40);
             routes.Add(100,route100);
             routes.Add(555,route555);
             routes.Add(5,route5);
            return routes;
        }
        */



       public static SortedList<int,BusRoute> InitializeRoutes()
        {

            BusRoute route40=(new BusRoute(40,new string []{"Morcambe","Lancaster","Garstang","Preston"}));
            BusRoute route42=(new BusRoute(42,new string []{ "Lancaster", "Garstang","Blackpool"}));
            BusRoute route100=(new BusRoute(100,new string []{"University", "Lancaster", "Morecambe" }));
            BusRoute route555=(new BusRoute(555,new string []{ "Lancaster","Carnforth","Kendel","Windermere","Keswik"}));
            BusRoute route5=(new BusRoute(5,new string []{ "Overton","Morcambe","Carnforth"}));
            var routes = new SortedList<int,BusRoute>();
            routes.Add(42,route42);
             routes.Add(40,route40);
             routes.Add(100,route100);
             routes.Add(555,route555);
             routes.Add(5,route5);
            return routes;
        }







    }
}
