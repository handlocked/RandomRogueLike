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
        private bool focused = false;

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
            Rectangle rect = new Rectangle(this.X, this.Y, this.Width, this.Height);

            var mouseState = Mouse.GetState();
            var mouseposition = new Point(mouseState.X, mouseState.Y);

            if (rect.Contains(mouseposition))
            {
                if (mouseState.RightButton == ButtonState.Pressed && !focused)
                {
                    this.X = mouseposition.X;
                    this.Y = mouseposition.Y;
                    focused = true;
                }
            }

            if (mouseState.RightButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed && focused)
            {
                this.X = mouseposition.X;
                this.Y = mouseposition.Y;
            }

            if (mouseState.RightButton == Microsoft.Xna.Framework.Input.ButtonState.Released)
            {
                focused = false;
            }
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
