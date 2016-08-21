using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;

namespace RogueLikeGame
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        List<Enemy> Enemies = new List<Enemy>();
        DebugLog debug = new DebugLog();
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        AnimatedSprite explosion;
        Player player;
        Map map1 = new Map();
        ExperienceBar expBar;
        static SpriteFont font;
        StreamWriter sw = new StreamWriter("" + System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) + "/map.txt");
        GUI.DynamicButton DynamicB;
        Enemy Witch;
       static Texture2D healthbar;

        public static SpriteFont Font
        {
            get { return font; }
        }

        public static Texture2D Healthbar
        {
            get
            {
                return healthbar;
            }
            
        }
        int MonitorWidth, MonitorHeight;

        

        int[,] mapDetailed = new int[,]
        {
            {0,1,0,0,1},
            {0,1,1,1,1}
        };

       

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            graphics.PreferredBackBufferWidth = (int)ScreenManager.Instance.Dimensions.X;
            graphics.PreferredBackBufferHeight = (int)ScreenManager.Instance.Dimensions.Y;
            graphics.ApplyChanges();

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            this.IsMouseVisible = true;
            Enemies.Add(Witch);

            spriteBatch = new SpriteBatch(GraphicsDevice);

            //EXP Bar Koordinaten
            MonitorWidth = GraphicsDevice.Viewport.Width / 2;
            MonitorHeight = GraphicsDevice.Viewport.Height / 4;

            healthbar = Content.Load<Texture2D>(@"Textures\HealthBar");
            explosion = new AnimatedSprite(Content.Load<Texture2D>(@"Textures\explosions"), 0, 0, 64, 64, 16);
            player = new Player(Content.Load<Texture2D>(@"Textures\PlayerTwo"), 0, 0, 64, 64);
            font = Content.Load<SpriteFont>(@"myFont");
            Witch = new Enemy(Content.Load<Texture2D>(@"Textures\Demongirl"), 100, 100, 64, 64);
            expBar = new ExperienceBar
            (Content.Load<Texture2D>(@"Textures\EXP_BALKEN1"), Content.Load<Texture2D>(@"Textures\EXP_EXP1"), MonitorWidth - 100, GraphicsDevice.Viewport.Bounds.Bottom - 100);


            //Setzt die Position von der Animation auf 0
            explosion.X = GraphicsDevice.Viewport.Width;
            explosion.Y = GraphicsDevice.Viewport.Height;
            
            //Schreibt Daten der Karte in eine Datei
            foreach (var item in mapDetailed)
                sw.Write(item);
            sw.Close();

            map1.GenerateMap(mapDetailed, 64);

            ScreenManager.Instance.LoadContent(Content);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            ScreenManager.Instance.UnloadContent();
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            debug.AddItem("" + player.X);
            debug.AddItem("" + player.Y);
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            //Exp - Darstellungsberechnung
            var maxEP = player.ExpToUP;
            int divison = expBar.EXPWidth / maxEP * player.EXP;

            expBar.SetRectEXP = new Rectangle(MonitorWidth, MonitorHeight, divison ,expBar.EXPHeight);
          

            ScreenManager.Instance.Update(gameTime);
            explosion.Update(gameTime);
            player.Update(gameTime);
            base.Update(gameTime);

        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            ScreenManager.Instance.Draw(spriteBatch);
            spriteBatch.Begin();

            expBar.DrawExp(spriteBatch);
            expBar.Draw(spriteBatch);
            

            player.Draw(spriteBatch);
            Witch.Draw(spriteBatch);
            spriteBatch.DrawString(font, "Level: " + player.Level, new Vector2(0, 0), Color.White);
            spriteBatch.DrawString(font, "EXP: " + player.EXP, new Vector2(0, 40), Color.White);

            map1.Draw(spriteBatch);
            debug.Draw(spriteBatch);
            explosion.Draw(spriteBatch, 0, 0, false);
            
            spriteBatch.End();
            base.Draw(gameTime);
        }

        public void CheckCollision()
        {
            
        }
       
    }
}
