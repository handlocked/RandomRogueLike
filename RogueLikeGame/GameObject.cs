using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
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

        private int CursorX;
        private int CursorY;

        public int X
        {
            get
            {
                return xPos;
            }
            set
            {
                xPos = value;
            }
        }

        public int Y
        {
            get
            {
                return yPos;
            }
            set
            {
                yPos = value;
            }
        }
        
        public virtual void LoadContent()
        {
         
        }
        public virtual void Update(GameTime gameTime)
        {
            var Pcursor = Cursor.Position;
            CursorX = Pcursor.X;
            CursorY = Pcursor.Y;
            if (CursorX == xPos && CursorY == yPos)
            {

                X = Cursor.Position.X;
                Y = Cursor.Position.Y;
            }
              
        }
    }
}
