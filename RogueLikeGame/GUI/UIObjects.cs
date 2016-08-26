using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace RogueLikeGame.GUI
{
    class UIObjects
    {
        private int xpos, ypos, width = 200, height = 100;
        private Texture2D t2d;

        public int X
        {
            get { return xpos; }
            set { xpos = value; }
        }

        public int Y
        {
            get { return ypos; }
            set { ypos = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public Texture2D Texture
        {
            get { return t2d; }
            set { t2d = value;}
        }

        public virtual void Update(GameTime gameTime)
        {
           
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
