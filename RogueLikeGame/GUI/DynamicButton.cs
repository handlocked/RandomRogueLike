using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;



namespace RogueLikeGame.GUI
{
    public delegate void MouseEnter();
    public delegate void MouseLeft();

   
    class DynamicButton : UIObjects
    {
        private Button button = new Button();
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


        public event EventHandler Clicked;

        public DynamicButton(string text)
        {
            button.Location = new System.Drawing.Point(100, 100);
            button.Show();
        }

        public override void Update(GameTime gameTime)
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
       
        }

        

    
    }
}
