using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;



namespace RogueLikeGame.GUI
{
   

   
    class DynamicButton : UIObjects
    {
       
        private string text = "";
        

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




        public DynamicButton(string TEXT, int x, int y, Texture2D t2d)
        {
            text = TEXT;
            this.X = x;
            this.Y = y;
            this.Texture = t2d;
        }

        public override void Update(GameTime gameTime)
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {

            spriteBatch.Draw(Texture,new Rectangle(X, Y, Width, Height), Color.White);
            spriteBatch.DrawString(Game1.Font, text, new Vector2(X + Width / 15, Y + Height / 4), Color.Black);
            
        }

        

    
    }
}
