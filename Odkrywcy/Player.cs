using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odkrywcy
{
    class Player
    {
        public string name;
        public int place;
        public int previousPlace;
        public Color color;
        public PictureBox pic;

        public Player(string name, int place, int previousPlace, Color color, PictureBox pic)
        {
            this.name = name;
            this.place = place;
            this.previousPlace = previousPlace;
            this.color = color;
            this.pic = pic;
        }
    }
}
