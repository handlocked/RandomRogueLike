using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Windows;


namespace RogueLikeGame.GUI
{
    public delegate void MouseEnter();
    public delegate void MouseLeft();

    class DynamicButton 
    {
        private string text = "";
        private int xPos;
        private int yPos;

        public int ButtonX
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

        public int ButtonY
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

        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
            }
        }


        public event EventHandler Clicked;

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
       
        }

        

    
    }
}
