using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace castle
{
    public class HelpHandler:Handler
    {
       
        public HelpHandler(Game game)
            :base(game)
        {
            
        }
        public override void DoCmd(string dir)
        {
            Console.WriteLine("迷路了吗？你可以做的命令有：go bye help");
            Console.WriteLine("如：\tgo east");
        }
    }
}
