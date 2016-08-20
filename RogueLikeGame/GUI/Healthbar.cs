using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using RogueLikeGame.GUI;

namespace RogueLikeGame.GUI
{
    class Healthbar : UIObjects
    {
        private Texture2D Bar;
        private int xpos, ypos;
        private int health;

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


        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }

        public Healthbar(Texture2D HBar, int xPos, int yPos)
        {
            Bar = HBar;
            xpos = xPos;
            ypos = yPos;
        }

        public override void Update(GameTime gameTime)
        {
            
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
        
            spriteBatch.Draw(Bar, new Rectangle(xpos, ypos, 50, 10), Color.White);

        }
    }
}
