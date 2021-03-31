using System.Collections.Generic;

namespace SnakeGame.Models
{
    public class Snake
    {
        public SnakePiece Head { get; set; }
        public List<SnakePiece> Body { get; set; }

        public Snake()
        {
            Head = new SnakePiece(0, 0, true);
            Body = new List<SnakePiece>();
        }
    }
}
