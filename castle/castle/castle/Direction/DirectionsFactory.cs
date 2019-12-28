using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace castle
{
    public class DirectionsFactory
    {

        public static Directions createDirections(string s)
        {
            switch (s)
            {
                case "north":
                    return new North();
                case "south":
                    return new South();
                case "west":
                    return new West();
                case "east":
                    return new East();
                default:
                    return null;
            }
        }


    }
}
