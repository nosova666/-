using bladegame.PlayerMVC;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace bladegame
{
    public class PlayerController
    {
        private PlayerModel playerModel;
        private PlayerView playerView;

        public PlayerController(PlayerModel model, PlayerView view)
        {
            playerModel = model;
            playerView = view;
        }

        public void Update(GameTime gameTime)
        {
            // Логика обновления состояния игрока
            // Изменение свойств модели игрока
        }

        public void Draw()
        {
            playerView.Draw(playerModel);
        }
    }
}