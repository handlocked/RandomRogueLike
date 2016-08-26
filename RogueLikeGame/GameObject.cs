using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace RogueLikeGame
{
    class GameObject
    {
        private int xPos;
        private int yPos;
        private int width;
        private int height;

        private int CursorX;
        private int CursorY;

        public int X
        {
            get { return xPos; }
            set { xPos = value; }
        }

        public int Y
        {
            get{ return yPos; }
            set
            {
                yPos = value;
            }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public virtual void LoadContent()
        {
         
        }
        public virtual void Update(GameTime gameTime)
        {
            Rectangle rect = new Rectangle(this.X, this.Y, this.Width, this.Height);

            var mouseState = Mouse.GetState();
            var mouseposition = new Point(mouseState.X, mouseState.Y);

            if (rect.Contains(mouseposition))
            {
                if (mouseState.RightButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed)
                {
                    this.X = mouseposition.X;
                    this.Y = mouseposition.Y;
                }
            }
          

        }

        public void SetStandardPosition()
        {
          
        }
    }
}
