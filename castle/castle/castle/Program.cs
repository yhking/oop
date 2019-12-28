using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using castle.Direction;

namespace castle
{
    class Program
    {
        private static Directions DirectionsFactory(string s)
        {
            switch (s)
            {
                case "north":
                    return new North();
                case "south":
                    return new South();
                case "west":
                    return new West();
                case "east":
                    return new East();
                default:
                    return null;
            }
        }

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
                    game.goRoom(DirectionsFactory(words[1]));
                } else if ( words[0] == ("bye") ) {
        	        break;
                }
            }
        
            Console.WriteLine("感谢您的光临。再见！");
        }
    }
}
