﻿using System;
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
            this.X = 200;
            this.Y = 200;
          
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

        public override void Draw(SpriteBatch spritebatch)
        {
            foreach (var item in messages)
            {
                this.Y += 20;
                spritebatch.DrawString(Game1.Font, item, new Vector2(this.X, this.Y), Microsoft.Xna.Framework.Color.LightGray);
            }
        }

       
    }
}