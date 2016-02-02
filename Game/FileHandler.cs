using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GameEngine;

namespace Game
{
    public class FileHandler
    {
        /// <summary>
        /// Format
        /// Header:Position.X:Y:#Tiles:Tiles[]
        /// </summary>
        private const string Header = "NdNdv1";
        /// <summary>
        /// Loads a room data and image file
        /// </summary>
        /// <param name="dataFile">Room data file</param>
        /// <param name="imageFile">Room image file</param>
        /// <returns></returns>
        public static Room Load(string dataFile,string imageFile)
        {
            var dataFileWithPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName+@"\Images\"+dataFile;
            Room newRoom;
            if (!File.Exists(dataFileWithPath)) return null;
            using (var stream = File.Open(dataFileWithPath, FileMode.Open))
            using (var reader = new BinaryReader(stream, Encoding.UTF8))
            {

                var hd = Encoding.UTF8.GetBytes(Header);
                var buffer = new byte[hd.Length];
                reader.Read(buffer, 0, buffer.Length);
                var readHeader = Encoding.UTF8.GetString(buffer);
                if (readHeader != Header) return null;

                var posX = reader.ReadDouble();
                var posY = reader.ReadDouble();
                var tilesLength = reader.ReadInt32();
                newRoom = new Room(new Vector2((float)posX,(float)posY),imageFile)
                {
                    Tiles = new Tile[tilesLength]
                };

                for (var i = 0; i < tilesLength; i++)
                {
                    var tt = (TileTypes)reader.ReadInt32();
                    newRoom.Tiles[i] = new Tile() { TileType = tt };
                }
            }
            return newRoom;

        }
        /// <summary>
        /// Saves a room to data file
        /// </summary>
        /// <param name="room">Room to save</param>
        /// <param name="filename">Absolute path to file</param>
        /// <returns></returns>
        public static bool Save(Room room, string filename)
        {
            using (var stream = File.Open(filename, FileMode.Create))
            using (var writer = new BinaryWriter(stream, Encoding.UTF8))
            {
                var hd = Encoding.UTF8.GetBytes(Header);
                writer.Write(hd, 0, hd.Length);
                writer.Write(room.Position.X);
                writer.Write(room.Position.Y);
                writer.Write(room.Tiles.Length);
                foreach (var tile in room.Tiles)
                {
                    var tt = (int)tile.TileType;
                    writer.Write(tt);
                }

            }
            return true;

        }


    }
}
