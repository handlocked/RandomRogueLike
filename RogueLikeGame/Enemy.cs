using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace RogueLikeGame
{
    class Enemy : GameObject
    {
        Texture2D t2dtexture;
       

        public Enemy(Texture2D Ttexture, int XPOS, int YPOS, int HEIGHT, int WIDTH)
        {
            t2dtexture = Ttexture;
            this.X = XPOS;
            this.Y = YPOS;
            this.Height = HEIGHT;
            this.Width = WIDTH;
        }
        public override void Update(GameTime gameTime)
        {
            
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(t2dtexture, new Rectangle(this.X, this.Y, this.Width, this.Height), Color.White);
        }

        public void getNearbyPlayer(Player player)
        {
            if (this.Rect.Contains(player.Rect)
                player.Health = 50;
        }
    }
}
