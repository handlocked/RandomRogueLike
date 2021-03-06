﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using RogueLikeGame.GUI;

namespace RogueLikeGame
{
    class ExperienceBar : UIObjects
    {
        private Texture2D Ttext2D;
        private Texture2D TExpPic;

        private int expWidth = 500;

        public int EXPWidth
        {
            get
            {
                return expWidth;
            }
        }

        private int expHeight = 25;

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
            get
            {
                return rect;
            }
            set
            {
                rect = value;
            }
        }
   

        public ExperienceBar(Texture2D EXPBalken, Texture2D EXPPic, int xPos, int yPos)
        {
            Ttext2D = EXPBalken;
            TExpPic = EXPPic;
            this.X = xPos;
            this.Y = yPos;
        }
        public override void Update(GameTime gameTime)
        {
            expHeight = 500;
           
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Ttext2D, new Rectangle(this.X, this.Y, expWidth, expHeight), Color.White);

        }

       

        public void DrawExp(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(TExpPic, rect, Color.White);

        }
        

    }
}
