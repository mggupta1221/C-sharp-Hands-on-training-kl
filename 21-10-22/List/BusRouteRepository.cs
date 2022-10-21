using System;


namespace BusRouteApplication
{
    public class BusRouteRepository
    {


        public static List<BusRoute> InitializeRoutes()
        {
            List<BusRoute> result = new List<BusRoute>();//list is empty after executing the constructor
          
                result.Add(new BusRoute(40,new string []{"Morcambe","Lancaster","Garstang","Preston"}));
                result.Add(new BusRoute(42,new string []{ "Lancaster", "Garstang","Blackpool"}));
                result.Add(new BusRoute(1_000,new string []{ "TestOrigin","TestDestination"}));
                result.Add(new BusRoute(100,new string []{"University", "Lancaster", "Morecambe" }));
                result.Add(new BusRoute(555,new string []{ "Lancaster","Carnforth","Kendel","Windermere","Keswik"}));
            return result;
        }

    }
}
