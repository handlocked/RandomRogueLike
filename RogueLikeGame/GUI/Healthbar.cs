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
        
        private int health;

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
           this.X = xPos;
           this.Y = yPos;
        }

        public override void Update(GameTime gameTime)
        {
            
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
        
            spriteBatch.Draw(Bar, new Rectangle(this.X, this.Y, 50, 10), Color.White);

        }
    }
}
