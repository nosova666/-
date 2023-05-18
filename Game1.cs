using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace bladegame
{
    public class Game1 : Game
    {

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Spriter player;
        private Map map;
        private Enemy enemy;
        private Sword sword;
        private Obstacle obstacle;

        private Color Background;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            // Инициализация игровых объектов
            player = new Spriter(/* Параметры игрока */);
            map = new Map(/* Параметры карты */);
            enemy = new Enemy(/* Параметры врага */);
            sword = new Sword(/* Параметры меча */);
            obstacle = new Obstacle(/* Параметры игрового объекта */);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // Загрузка текстур и спрайтов
            Texture2D playerTexture = Content.Load<Texture2D>("player");
            Texture2D enemyTexture = Content.Load<Texture2D>("enemy");
            Texture2D swordTexture = Content.Load<Texture2D>("sword");
            Texture2D objectTexture = Content.Load<Texture2D>("object");

            // Установка текстур и спрайтов для объектов
            player.SetTexture(playerTexture);
            enemy.SetTexture(enemyTexture);
            sword.SetTexture(swordTexture);
            obstacle.SetTexture(objectTexture);

            player = new Spriter(Content.Load<Texture2D>("Player"))
            {
                Velocity = new Vector2(2,1)
            };
        }   
    // TODO: use this.Content to load your game content here}

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            player.Update(gameTime);
            base.Update(gameTime);

            player.Update(gameTime);
            enemy.Update(gameTime, player.Position);
            sword.Update(gameTime, player.Position);

            // Проверка коллизий между мечом и врагом
            if (sword.CheckCollision(enemy))
            {
                // Враг получает урон
            }

            // Проверка коллизий между игроком и игровым объектом
            if (player.CheckCollision(obstacle))
            {
                // Обработка подбора объекта
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            _spriteBatch.Begin();

            // Отрисовка игровых объектов
            map.Draw(_spriteBatch);
            player.Draw(_spriteBatch);
            enemy.Draw(_spriteBatch);
            sword.Draw(_spriteBatch);
            obstacle.Draw(_spriteBatch);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}