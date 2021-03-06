﻿using System;
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
       /// <summary>
       /// Current experience
       /// </summary>
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
        /// <summary>
        /// Current Level
        /// </summary>
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
        /// <summary>
        /// exp zum Level up
        /// </summary>
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

   
        private int health = 200;
        /// <summary>
        /// Aktuelles Leben 
        /// </summary>
        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        KeyboardState pressedkey;
        Texture2D t2dtexture;
      
       

    

        public Player(Texture2D Ttexture, int XPOS, int YPOS, int HEIGHT, int WIDTH)
        {
            t2dtexture = Ttexture;
            this.X = XPOS;
            this.Y = YPOS;
            this.Height = HEIGHT;
            this.Width = WIDTH;
            this.Rect = new Rectangle(this.X, this.Y, this.Width, this.Height);
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
           
            spriteBatch.Draw(t2dtexture, new Rectangle(this.X, this.Y, this.Width, this.Height), Color.White);
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
                experience += 5;
             
            }
        }

        public void damage(Enemy enemy)
        {
            var point = new Point(enemy.X, enemy.Y);
            if(this.Rect.Contains(point))
            {
                Health -= 10;
            }
        }
           
    }
}
