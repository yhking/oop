using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace castle
{
    public class Room
    {
        private String description;
        private Dictionary<String, Room> exits = new Dictionary<string, Room>();

        public Room(String description) 
        {
            this.description = description;
        }

        public string showPrompt()
        {
            StringBuilder sb = new StringBuilder();

            foreach(String dir in exits.Keys)
            {
                sb.Append(dir);
                sb.Append(" ");
            }

            return sb.ToString();
        }

        
        public Room goStep(String dir)
        {
            if (exits.ContainsKey(dir))
            {
                return exits[dir];
            }

            return null;
        }

        public void setExit(String dir, Room room)
        {
            exits.Add(dir, room);
        }

        public override String ToString()
        {
            return description;
        }
    }
}
