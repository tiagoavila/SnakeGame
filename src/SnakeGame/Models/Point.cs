namespace SnakeGame.Models
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Point point)
            {
                return point != null && point.X == X && point.Y == Y;
            }

            return base.Equals(obj);
        }
    }
}
