using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace castle
{
    public class East : Directions
    {
        public override Room goStep(Room currRoom)
        {
            return currRoom.eastExit;
        }
    }
}
