using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace RogueLikeGame
{
    class Enemy
    {
        Texture2D t2dtexture;
        int xPos, yPos, height, width;

        public Enemy(Texture2D Ttexture, int XPOS, int YPOS, int HEIGHT, int WIDTH)
        {
            t2dtexture = Ttexture;
            xPos = XPOS;
            yPos = YPOS;
            height = HEIGHT;
            width = WIDTH;
        }
        public virtual void Update(GameTime gameTime)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(t2dtexture, new Rectangle(xPos, yPos, width, height), Color.White);
        }
    }
}
