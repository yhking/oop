using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace castle
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.printWelcome();

            Directions dir;

            while ( true )
            {
                String line = Console.ReadLine();
                String[] words = line.Split(' ');
                if ( words[0] == ("help") ) {
        	        game.printHelp();
                } else if (words[0] == ("go") ) {
                    game.goRoom(words[1]); 
                } else if ( words[0] == ("bye") ) {
        	        break;
                }
            }
        
            Console.WriteLine("感谢您的光临。再见！");
        }
    }
}
