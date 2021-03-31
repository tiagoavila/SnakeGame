using SnakeGame.Enums;

namespace SnakeGame.Models
{
    public class Settings
    {
        public Directions Direction { get; set; }
        public int PieceSize => 10;

        public Settings()
        {
            Direction = Directions.Right;
        }
    }
}
