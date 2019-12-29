using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace castle
{
    public class GoStepHandler: Handler
    {
        public GoStepHandler(Game game)
            : base(game)
        {

        }
        
        public override void DoCmd(string dir)
        {
            base.game.goRoom(dir);
        }
    }
}
