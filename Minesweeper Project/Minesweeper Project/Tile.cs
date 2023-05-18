using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Minesweeper_Project
{
    class Tile
    {
        public string name;
        public bool ismine;
        public int xcoord;
        public int ycoord;

        public Tile(int x, int y, string n, int t, bool i, bool f)
        {
            name = n;
            xcoord = x;
            ycoord = y;
            ismine = i;
        }
    }
}
