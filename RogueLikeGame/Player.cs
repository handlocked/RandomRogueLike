﻿using System;
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
        private int experience = 0;

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

            if(experience >= ExpToLevelUP)
            {
                level++;
                experience = 0;
                ExpToLevelUP *= 2;
            }
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

            if (pressedkey.IsKeyDown(Keys.L))
            {
                experience += 2;
                System.Threading.Thread.Sleep(100);
            }
        }
           
    }
}
