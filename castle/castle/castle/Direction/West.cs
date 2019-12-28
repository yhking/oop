using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace castle
{
    public class West:Directions
    {
        public override Room goStep(Room currRoom)
        {
            return currRoom.westExit;
        }
    }
}
