using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace castle
{
    public abstract class Directions
    {
        public abstract Room goStep(Room currRoom);
    }
}
