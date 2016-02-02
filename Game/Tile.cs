using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Game
{
    public enum TileTypes
    {
        Floor,
        Wall,
        Door,
        None
    }
    /// <summary>
    /// Describes one tile in a room.
    /// </summary>
    public class Tile
    {
        public TileTypes TileType { get; set; }
    }
}
