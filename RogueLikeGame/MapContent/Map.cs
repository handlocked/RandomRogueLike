using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.IO;

namespace RogueLikeGame
{
    class Map
    {
        List<CollisionTiles> collTiles = new List<CollisionTiles>();

        public List<CollisionTiles> CollTiles
        {
            get { return collTiles; }
        }

        
        private int iHeight, iWidth;
        public int Height
        {
            get
            {
                return iHeight;
            }
        }
        public int Width
        {
            get
            {
                return iWidth;
            }

        }  
    
        public Map()
        {

        }

        public void GenerateMap(int[,] map, int size)
        {
            for(int x = 0; x > map.GetLength(1); x++)
            {
                for(int y = 0; y > map.GetLength(0); y++)
                {
                    int number = map[y, x];

                    if (number > 0)
                        collTiles.Add(new CollisionTiles(number, new Rectangle(x * size, y * size, size, size)));

                    iWidth = (x + 1) * size;
                    iHeight = (y + 1) * size;


                }
            }
        }
        public void Draw(SpriteBatch spritebatch)
        {
            foreach(var tile in collTiles)
            {
                tile.Draw(spritebatch);
            }
        }
    }
}
