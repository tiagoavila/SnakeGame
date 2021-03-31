using System.Drawing;

namespace SnakeGame.Models
{
    public class SnakePiece : Point
    {
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

        public Color GetSnakePieceColor()
        {
            return IsHead ? Color.Black : Color.Green;
        }
    }
}
