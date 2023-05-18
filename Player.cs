using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace bladegame
{
    public class Player
    {   
        private Texture2D texture;   // model
        private Vector2 position;
        private float speed;

        public Player(Texture2D playerTexture, Vector2 playerPosition, float playerSpeed) // view
        {
            texture = playerTexture;
            position = playerPosition;
            speed = playerSpeed;
        }

        public void Update(GameTime gameTime) //controller
        {

            KeyboardState keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.Left))
            {
                position.X -= speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }
            else if (keyboardState.IsKeyDown(Keys.Right))
            {
                position.X += speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }

            if (keyboardState.IsKeyDown(Keys.Up))
            {
                position.Y -= speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }
            else if (keyboardState.IsKeyDown(Keys.Down))
            {
                position.Y += speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }

        }

        public void Draw(SpriteBatch spriteBatch) //controller
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
