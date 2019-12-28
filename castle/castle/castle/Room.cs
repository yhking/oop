using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace castle
{
    public class Room
    {
        public String description;
        public Room northExit;
        public Room southExit;
        public Room eastExit;
        public Room westExit;

        public Room(String description) 
        {
            this.description = description;
        }

        public void setExits(Room north, Room east, Room south, Room west) 
        {
            if(north != null)
                northExit = north;
            if(east != null)
                eastExit = east;
            if(south != null)
                southExit = south;
            if(west != null)
                westExit = west;
        }

        public override String ToString()
        {
            return description;
        }
    }
}
