using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace bladegame.PlayerMVC
{
    public class PlayerView
    {
        private Texture2D texture;
        private SpriteBatch spriteBatch;

        public PlayerView(Texture2D playerTexture, SpriteBatch spriteBatch)
        {
            texture = playerTexture;
            this.spriteBatch = spriteBatch;
        }

        public void Draw(PlayerModel playerModel)
        {
            spriteBatch.Draw(texture, playerModel.Position, Color.White);
        }
    }
}
