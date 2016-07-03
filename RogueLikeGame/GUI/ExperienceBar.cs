using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using RogueLikeGame.GUI;

namespace RogueLikeGame
{
    class ExperienceBar : UIObjects
    {
        private Texture2D Ttext2D;

        private int exp = 0;

        public int EXP
        {
            get
            {
                return exp;
            }

            set
            {
                exp = value;
            }
        }

        public ExperienceBar(Texture2D text2d)
        {
            Ttext2D = text2d;
        }
        public override void Update(GameTime gameTime)
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Ttext2D, new Rectangle(100, 100, 250, 100), Color.White);
        }
        

    }
}
