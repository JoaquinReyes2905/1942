using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace _1942
{
    public class Game1 : Game
    {
        Texture2D enemigo;
        int posicionX = 0;
        int posicionY = 0;
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        DateTime timew;
        DateTime tiempoActual;
        TimeSpan tiempo;


        public Game1()
        {

            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {

            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            enemigo = Content.Load<Texture2D>("img/player");
            timew = DateTime.Now;



        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            
            tiempoActual = DateTime.Now;
            tiempo = tiempoActual - timew;
            if (tiempo.Milliseconds >= 300)
            {
                timew = DateTime.Now;
                posicionX += 10;
                posicionY += 2;
            }

            // TODO: Add your update logic here

            base.Update(gameTime);
            
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(enemigo, new Vector2(posicionX, posicionY), Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}