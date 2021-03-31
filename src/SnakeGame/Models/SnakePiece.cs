namespace SnakeGame.Models
{
    public class SnakePiece
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsHead { get; set; }

        public SnakePiece()
        {
            X = 0;
            Y = 0;
        }

        public SnakePiece(int x, int y, bool isHead)
        {
            X = x;
            Y = y;
            IsHead = isHead;
        }

        public SnakePiece(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
