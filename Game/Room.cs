﻿using System;
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
        private const float TileSize=43;
        public int Initiative { get; }
        public bool IsActive { get; }
        public Vector2 Position { get; set; }
        public ScreenObject ScreenObject { get; set; }
        public Vector2 MovePosition { get; set; }
        public IGameObject Target { get; set; }

        public void Action()
        {
        }
        public Room(Vector2 position, string img)
        {
            Position = position;
            ScreenObject = new ScreenObject(img);
        }

        public TileTypes GetTile(Vector2 position)
        {
            var index =
                (int)
                    (Math.Floor(position.Y / TileSize) * Math.Ceiling(ScreenObject.Image.Source.Width / TileSize) +
                     Math.Floor(position.X / TileSize));

            if(index>=Tiles.Length || index<0)return TileTypes.None;
            return Tiles[index].TileType;
        }

        public Tile[] Tiles { get; set; }
    

       
    }
}