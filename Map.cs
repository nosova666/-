using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace bladegame
{
    public  class Map
    {
        private Texture2D tileTexture;
        private Texture2D wallTexture;
        private int[,] tileMap; // Массив, представляющий карту плиток
        private int tileWidth;
        private int tileHeight;

        public Map(Texture2D tileTexture, Texture2D wallTexture, int[,] map, int tileWidth, int tileHeight)
        {
            this.tileTexture = tileTexture;
            this.wallTexture = wallTexture;
            tileMap = map;
            this.tileWidth = tileWidth;
            this.tileHeight = tileHeight;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int row = 0; row < tileMap.GetLength(0); row++)
            {
                for (int col = 0; col < tileMap.GetLength(1); col++)
                {
                    int tileType = tileMap[row, col];
                    // Определяем позицию для отрисовки текущей плитки
                    Vector2 position = new Vector2(col * tileWidth, row * tileHeight);
                    // В зависимости от типа плитки, отрисовываем плитку или стену
                    Texture2D texture = tileType == 0 ? tileTexture : wallTexture;
                    spriteBatch.Draw(texture, position, Color.White);
                }
            }
        }

    }
}
