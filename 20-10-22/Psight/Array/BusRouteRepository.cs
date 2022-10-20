using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusRouteApplication
{
    public class BusRouteRepository
    {


        public static BusRoute [] InitializeRoutes()
        {
            return new BusRoute[] {
                new BusRoute(40,new string []{"Morcambe","Lancaster","Garstang","Preston"}),
                new BusRoute(42,new string []{ "Lancaster", "Garstang","Blackpool"}),
                new BusRoute(100,new string []{"University", "Lancaster", "Morecambe" }),
                new BusRoute(555,new string []{ "Lancaster","Carnforth","Kendel","Windermere","Keswik"}),
            };
        }

    }
}
