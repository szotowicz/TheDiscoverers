using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odkrywcy
{
    public class Game
    {
        public int numberOfPlayers;
        public string red;
        public string blue;
        public string green;
        public string yellow;
        public char[] order;
        public string map;

        public Game(int numberOfPlayers, string red, string blue, string green, string yellow, char[] order, string map)
        {
            this.numberOfPlayers = numberOfPlayers;
            this.red = red;
            this.blue = blue;
            this.green = green;
            this.yellow = yellow;
            this.order = order;
            this.map = map;
        }
    }
}
