using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace castle
{
    public class Handler
    {
        protected Game game;
        public Handler(Game game)
        {
            this.game = game;
        }
        public virtual void DoCmd(String dir) { }

        public virtual bool IsByeCmd() { return false; }
    }
}
