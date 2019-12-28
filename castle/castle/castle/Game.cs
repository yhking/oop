using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace castle
{
    public class Game
    {
        private Room currentRoom;

        public Game()
        {
            createRooms();
        }

        public Room CurrentRoom
        {
            get { return currentRoom; }
            set { currentRoom = value; }
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
            outside.setExits(null, lobby, study, pub);
            lobby.setExits(null, null, null, outside);
            pub.setExits(null, outside, null, null);
            study.setExits(outside, bedroom, null, null);
            bedroom.setExits(null, null, null, study);

            currentRoom = outside;  //	从城堡门外开始
        }

        public void printWelcome() 
        {
            Console.WriteLine();
            Console.WriteLine("欢迎来到城堡！");
            Console.WriteLine("这是一个超级无聊的游戏。");
            Console.WriteLine("如果需要帮助，请输入 'help' 。");
            Console.WriteLine();
            Console.WriteLine("现在你在" + currentRoom);
            Console.Write("出口有：");
            if(currentRoom.northExit != null)
                Console.Write("north ");
            if(currentRoom.eastExit != null)
                Console.Write("east ");
            if(currentRoom.southExit != null)
                Console.Write("south ");
            if(currentRoom.westExit != null)
                Console.Write("west ");
            Console.WriteLine();
        }

        // 以下为用户命令

        public void printHelp() 
        {
            Console.Write("迷路了吗？你可以做的命令有：go bye help");
            Console.WriteLine("如：\tgo east");
        }

        

        public void goRoom(String direction)
        {
            var nextRoom = CurrentRoom.goStep(direction);
            if (nextRoom == null)
            {
                Console.WriteLine("这里没有门！");
            }
            else
            {
                CurrentRoom = nextRoom;
                CurrentRoom.showHits();
            }
        }

        //public void goRoom(String direction) 
        //{
        //    Room nextRoom = null;
        //    if(direction == ("north")) {
        //        nextRoom = currentRoom.northExit;
        //    }
        //    if(direction == ("east")) {
        //        nextRoom = currentRoom.eastExit;
        //    }
        //    if(direction == ("south")) {
        //        nextRoom = currentRoom.southExit;
        //    }
        //    if(direction == ("west")) {
        //        nextRoom = currentRoom.westExit;
        //    }

        //    if (nextRoom == null) {
        //        Console.WriteLine("那里没有门！");
        //    }
        //    else {
        //        currentRoom = nextRoom;
        //        Console.WriteLine("你在" + currentRoom);
        //        Console.Write("出口有: ");
        //        if(currentRoom.northExit != null)
        //            Console.Write("north ");
        //        if(currentRoom.eastExit != null)
        //            Console.Write("east ");
        //        if(currentRoom.southExit != null)
        //            Console.Write("south ");
        //        if(currentRoom.westExit != null)
        //            Console.Write("west ");
        //        Console.WriteLine();
        //    }
        //}
    }
}
