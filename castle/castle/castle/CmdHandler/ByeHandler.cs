using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace castle
{
    public class ByeHandler:Handler
    {
        public ByeHandler(Game game)
            : base(game)
        {

        }
        public override void DoCmd(String dir)
        {
            Console.WriteLine("感谢您的光临。再见！");
        }

        public override bool IsByeCmd()
        {
            return true;
        }
    }
}
