using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine;
using GameEngine.interfaces;

namespace Game
{
    public class Room:IGameObject
    {
        public int Initiative { get; }
        public bool IsActive { get; }
        public Vector2 Position { get; set; }
        public ScreenObject ScreenObject { get; set; }
        public IGameObject Target { get; set; }

        public void Action()
        {
        }
        public Room(Vector2 position, string img)
        {
            Position = position;
            ScreenObject = new ScreenObject(img);
        }
        public Tile[] Tiles { get; set; }
    

       
    }
}
