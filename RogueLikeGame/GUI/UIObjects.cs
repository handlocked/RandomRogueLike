using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace RogueLikeGame.GUI
{
    class UIObjects
    {
        private int xpos, ypos;

        public int X
        {
            get
            {
                return xpos;
            }
            set
            {
                xpos = value;
            }
        }

        public int Y
        {
            get
            {
                return ypos;
            }
            set
            {
                ypos = value;
            }
        }

        public virtual void Update(GameTime gameTime)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}
