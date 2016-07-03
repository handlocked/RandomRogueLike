using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;


namespace RogueLikeGame
{
    class Player : GameObject
    {
        private float experience = 0f;

        KeyboardState pressedkey;
        Texture2D t2dtexture;

        int xPos, yPos, height, width;
   
        public Player(Texture2D Ttexture, int XPOS, int YPOS, int HEIGHT, int WIDTH)
        {
            t2dtexture = Ttexture;
            xPos = XPOS;
            yPos = YPOS;
            height = HEIGHT;
            width = WIDTH;


        }
        public void LoadContent()
        {
            
        }
        public void UnloadContent()
        { 
            
        }

        public override void Update(GameTime gameTime)
        {
            Move();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
           
            spriteBatch.Draw(t2dtexture, new Rectangle(xPos, yPos, width, height), Color.White);
          
        }

        public void Move()
        {
            pressedkey = Keyboard.GetState();

            if (pressedkey.IsKeyDown(Keys.W))
            {
                yPos -= 5;
            }
            if (pressedkey.IsKeyDown(Keys.S))
            {
                yPos += 5;
            }
            if (pressedkey.IsKeyDown(Keys.D))
            {
                xPos += 5;
            }
            if (pressedkey.IsKeyDown(Keys.A))
            {
                xPos -= 5;
            }
        }
           
    }
}
