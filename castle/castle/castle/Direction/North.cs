using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace castle
{
    public class North : Directions
    {
        public override Room goStep(Room currRoom)
        {
            return currRoom.northExit;
        }
    }
}
