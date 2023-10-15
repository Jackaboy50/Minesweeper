using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Minesweeper_Project
{
    /// <summary>
    /// Represents a tile within the board 
    /// </summary>
    class Tile
    {
        public string name;
        public bool ismine;
        public int xcoord;
        public int ycoord;
        /// <summary>
        /// Initializes a new instance of the Tile class
        /// </summary>
        /// <param name="x">Specifies the X position of the tile</param>
        /// <param name="y">Specifies the Y position of the tile</param>
        /// <param name="n">Specifies the name of the tile</param>
        /// <param name="i">Specifies whether the tile is a mine</param>
        public Tile(int x, int y, string n, bool i)
        {
            name = n;
            xcoord = x;
            ycoord = y;
            ismine = i;
        }
    }
}
