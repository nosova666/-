using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace bladegame
{
    class Sword
    {
        private Texture2D texture;
        private Vector2 position;
        private Vector2 offset;
        private float rotation;
        private float attackRange;
        private float attackDamage;
        private bool isAttacking;

        public Sword(Texture2D swordTexture, Vector2 playerPosition, Vector2 swordOffset, float swordRange, float swordDamage)
        {
            texture = swordTexture;
            offset = swordOffset;
            attackRange = swordRange;
            attackDamage = swordDamage;
            isAttacking = false;
            UpdatePosition(playerPosition);
        }

        public void Update(GameTime gameTime, Vector2 playerPosition)
        {
            UpdatePosition(playerPosition);

            KeyboardState keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.Space))
            {
                isAttacking = true;
            }
            else
            {
                isAttacking = false;
            }
        }

        private void UpdatePosition(Vector2 playerPosition)
        {
            position = playerPosition + offset;
            rotation += 0.1f; // Поворот меча (можно настроить под вашу игру)
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, null, Color.White, rotation, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }

        public bool IsAttacking()
        {
            return isAttacking;
        }

        public bool CheckCollision(Enemy enemy)
        {
            if (isAttacking && Vector2.Distance(position, enemy.position) <= attackRange)
            {
                enemy.TakeDamage(attackDamage);
                return true;
            }
            return false;
        }
    }
}
