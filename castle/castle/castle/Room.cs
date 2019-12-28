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

        public void showHits()
        {
            Console.WriteLine("你在" + this);
            Console.Write("出口有: ");
            if (this.northExit != null)
                Console.Write("north ");
            if (this.eastExit != null)
                Console.Write("east ");
            if (this.southExit != null)
                Console.Write("south ");
            if (this.westExit != null)
                Console.Write("west ");
            Console.WriteLine();
        }

        
        public Room goStep(String direction)
        {
            var dir = DirectionsFactory.createDirections(direction);

            if (dir == null)
                return null;

            return dir.goStep(this);
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
