using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace bladegame
{
    class Obstacle
    {
        private Texture2D texture;
        private Vector2 position;
        private bool isCollected;

        public Obstacle(Texture2D objectTexture, Vector2 objectPosition)
        {
            texture = objectTexture;
            position = objectPosition;
            isCollected = false;
        }

        public bool IsCollected()
        {
            return isCollected;
        }

        public void Collect()
        {
            isCollected = true;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (!isCollected)
            {
                spriteBatch.Draw(texture, position, Color.White);
            }
        }
    }   
}
