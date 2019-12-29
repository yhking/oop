using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace castle
{
    public class Game
    {
        private Room currentRoom;
        public Dictionary<String, Handler> handlers;

        public Game()
        {
            createRooms();
            handlers = new Dictionary<string, Handler>();
            handlers.Add("bye", new ByeHandler(this));
            handlers.Add("help", new HelpHandler(this));
            handlers.Add("go", new GoStepHandler(this));
        }

        private void createRooms()
        {
            Room outside, lobby, pub, study, bedroom;

            //	制造房间
            outside = new Room("城堡外");
            lobby = new Room("大堂");
            pub = new Room("小酒吧");
            study = new Room("书房");
            bedroom = new Room("卧室");

            //	初始化房间的出口
            outside.setExit("east", lobby);
            outside.setExit("south", study);
            outside.setExit("west", pub);
            lobby.setExit("west", outside);
            pub.setExit("east", outside);
            study.setExit("north", outside);
            study.setExit("east", bedroom);
            bedroom.setExit("west", study);
            lobby.setExit("up", bedroom);
            bedroom.setExit("down", lobby);

            currentRoom = outside;  //	从城堡门外开始
        }

        public void printWelcome() 
        {
            Console.WriteLine();
            Console.WriteLine("欢迎来到城堡！");
            Console.WriteLine("这是一个超级无聊的游戏。");
            Console.WriteLine("如果需要帮助，请输入 'help' 。");
            Console.WriteLine();
            ShowLocation();
        }

        // 以下为用户命令
        public void Play()
        {
            printWelcome();

            while (true)
            {

                String line = Console.ReadLine();
                String[] words = line.Split(' ');

                Handler handler = null;
                String value = (words.Length > 1) ? words[1] : "";

                if (handlers.ContainsKey(words[0]))
                {
                    handler = handlers[words[0]];
                    handler.DoCmd(value);
                    if (handler.IsByeCmd())
                    {
                        break;
                    }
                }

            }
            
        }


        public void goRoom(String direction)
        {
            var nextRoom = currentRoom.goStep(direction);
            if (nextRoom == null)
            {
                Console.WriteLine("这里没有门！");
            }
            else
            {
                currentRoom = nextRoom;
                ShowLocation();
            }
        }

        private void ShowLocation()
        {
            
            Console.WriteLine("现在你在" + currentRoom);
            Console.Write("出口有：");
            Console.WriteLine(currentRoom.showPrompt());
        }
    }
}
