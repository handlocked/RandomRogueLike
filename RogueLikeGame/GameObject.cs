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
        private bool focused = false;
        private Rectangle rect;
        private Point point;
        private int CursorX;
        private int CursorY;
        /// <summary>
        /// Die X Koordinate
        /// </summary>
        public int X
        {
            get { return xPos; }
            set { xPos = value; }
        }

        /// <summary>
        /// Die Y Koordinate
        /// </summary>
        public int Y
        {
            get{ return yPos; }
            set
            {
                yPos = value;
            }
        }
        /// <summary>
        /// Die höhe des Objekts
        /// </summary>
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        /// <summary>
        /// Die breite des Objektes
        /// </summary>
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public Rectangle Rect
        {
            get { return rect; }
            set { rect = value; }
        }

        public Point Point
        {
            get { return point; }
            set { point = value;}
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
                if (mouseState.RightButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed && !focused)
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

        public static void SetStandardPosition(Point position)
        {
          
        }
    }
}
