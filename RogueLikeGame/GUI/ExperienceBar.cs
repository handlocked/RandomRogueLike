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
        private Texture2D TExpPic;

        private int BarPosX, BarPosY;

        private int expWidth = 250;

        public int EXPWidth
        {
            get
            {
                return expWidth;
            }
        }

        private int expHeight = 100;

        public int EXPHeight
        {
            get
            {
                return expHeight;
            }
        }

        private Rectangle rect;

        public Rectangle SetRectEXP
        {
            set
            {
                rect = value;
            }
        }
   

        public ExperienceBar(Texture2D EXPBalken, Texture2D EXPPic, int xPos, int yPos)
        {
            Ttext2D = EXPBalken;
            TExpPic = EXPPic;
            BarPosX = xPos;
            BarPosY = yPos;
        }
        public override void Update(GameTime gameTime)
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Ttext2D, new Rectangle(BarPosX, BarPosY, expWidth, expHeight), Color.White);

        }

       

        public void DrawExp(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(TExpPic, rect, Color.White);

        }
        

    }
}
