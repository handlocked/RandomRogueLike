using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace RogueLikeGame
{
   
    class DebugLog: GUI.UIObjects
    {
        private List<string> messages = new List<string>();
        private string messagelog = "";

        public string Message
        {
            set { messagelog = value; }
        }
        public DebugLog()
        {
            this.X = 5;
            this.Y = 500;
          
        }

        public DebugLog(string message)
        {
            this.X = Screen.PrimaryScreen.Bounds.X;
            this.Y = Screen.PrimaryScreen.Bounds.Bottom ;
            messagelog = message;
        }
        
        public void AddItem(string message)
        {
            messages.Add(message);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
        public override void Draw(SpriteBatch spritebatch)
        {
          
                spritebatch.DrawString(Game1.Font, "" + messagelog, new Vector2(this.X, this.Y), Microsoft.Xna.Framework.Color.LightGray);
        }

       
    }
}
