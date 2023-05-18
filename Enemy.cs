using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
    
namespace bladegame
{
    public class Enemy
    {
        private Texture2D texture;
        private Vector2 position;
        private float health;
        private float damage;
        private Vector2 targetPosition;
        private float speed;

        public Enemy (Texture2D enemyTexture, Vector2 enemyPosition, float enemyHealth, float enemyDamage, float enemySpeed)
        {
            texture = enemyTexture;
            position = enemyPosition;
            health = enemyHealth;
            damage = enemyDamage;
            speed = enemySpeed;
        }

        public void Update(GameTime gameTime, Vector2 playerPosition)
        {
            // Находим вектор направления к игроку
            Vector2 direction = playerPosition - position;
            direction.Normalize();

            // Обновляем позицию врага, двигая его в направлении игрока
            position += direction * speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }

    }
}
