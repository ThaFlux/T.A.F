using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using T.A.F.AttackbleUnit.Champion.Assassin;

namespace T.A.F
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public const int windowWidth = 800;
        public const int windowHeight = 600;

        public Texture2D bgTexture;
        public Texture2D joueurA;

        Assassin joueurAS = new Assassin(0,0,"Reflux");

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = windowWidth;
            graphics.PreferredBackBufferHeight = windowHeight;
     
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            bgTexture = Content.Load<Texture2D>("bgV1");
            joueurA = Content.Load<Texture2D>("AssassinV1");

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }



        
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        /// 

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            if (Keyboard.GetState().IsKeyDown(Keys.Z)) joueurAS.MoveForward(false); //avance
            if (Keyboard.GetState().IsKeyDown(Keys.S)) joueurAS.MoveForward(true);//recule
            if (Keyboard.GetState().IsKeyDown(Keys.Q)) joueurAS.MoveSide(false); //va a gauche
            if (Keyboard.GetState().IsKeyDown(Keys.D)) joueurAS.MoveSide(true);  //va a droite
            if (Keyboard.GetState().IsKeyDown(Keys.Space)) joueurAS.Dash();

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            spriteBatch.Draw(bgTexture, new Rectangle(0, 0, 800, 600), Color.White);
            spriteBatch.Draw(joueurA, new Rectangle(joueurAS.GetX(), joueurAS.GetY(), 47, 35), Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
