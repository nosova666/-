using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace bladegame
{
    public class Spriter
    {
        public Vector2 Position;
        public Vector2 Velocity;
        public Texture2D Texture { get; set; }
        public float Rotation;
        public Rectangle BoundingBox => new Rectangle(
            (int)Position.X,
            (int)Position.Y,
            Texture.Width,
            Texture.Height);

        public Spriter(Texture2D texture2D)
        {
            Texture = texture2D;
        }

        public void Update(GameTime gameTime)
        {
            Position += Velocity;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, Position, Color.White);
        }
    }
}
