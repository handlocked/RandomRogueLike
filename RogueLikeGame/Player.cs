using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using RogueLikeGame.GUI;

namespace RogueLikeGame
{
    
    class Player : GameObject
    {
        private int experience = 0;
        Healthbar healthbar;
       
        public int EXP
        {
            get
            {
                return experience;
            }
            set
            {
                experience = value;
            }
        }

        private int level = 1;

        public int Level
        {
            get
            {
                return level;
            }

            set
            {
                level = value;
            }
        }

        private int ExpToLevelUP = 10;

        public int ExpToUP
        {
            get
            {
                return ExpToLevelUP;
            }

            set
            {
                ExpToLevelUP = value;
            }
        }

        KeyboardState pressedkey;
        Texture2D t2dtexture;
        int width, height;
       

    

        public Player(Texture2D Ttexture, int XPOS, int YPOS, int HEIGHT, int WIDTH)
        {
            t2dtexture = Ttexture;
            this.X = XPOS;
            this.Y = YPOS;
            height = HEIGHT;
            width = WIDTH;
            healthbar = new Healthbar(Game1.Healthbar, this.X + 20, this.Y + 20);

        }
        public override void LoadContent()
        {
            
        }
        public void UnloadContent()
        { 
            
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            Move();
            healthbar.X = this.X + 10;
            healthbar.Y = this.Y - 20;
            if(experience >= ExpToLevelUP)
            {
                level++;
                experience = 0;
                ExpToLevelUP *= 2;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
           
            spriteBatch.Draw(t2dtexture, new Rectangle(this.X, this.Y, width, height), Color.White);
            healthbar.Draw(spriteBatch);
        }

        public void Move()
        {
            pressedkey = Keyboard.GetState();

            if (pressedkey.IsKeyDown(Keys.W))
            {
                this.Y -= 5;
            }
            if (pressedkey.IsKeyDown(Keys.S))
            {
                this.Y += 5;
            }
            if (pressedkey.IsKeyDown(Keys.D))
            {
                this.X += 5;
            }
            if (pressedkey.IsKeyDown(Keys.A))
            {
                this.X -= 5;
            }

            if (pressedkey.IsKeyDown(Keys.L))
            {
                experience += 2;
             
            }
        }
           
    }
}
