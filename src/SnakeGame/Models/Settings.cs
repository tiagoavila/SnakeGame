using SnakeGame.Enums;

namespace SnakeGame.Models
{
    public class Settings
    {
        public Directions Direction { get; set; }

        public Settings()
        {
            Direction = Directions.Right;
        }
    }
}
