using SnakeGame.Models;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame.Services
{
    public static class GraphicsEngine
    {
        /// <summary>
        /// Draw Snake in the PictureBox by calling the DrawSnakePiece for each piece of the Snake
        /// </summary>
        /// <param name="e"></param>
        /// <param name="snake"></param>
        /// <param name="_settings"></param>
        public static void DrawSnake(PaintEventArgs e, Snake snake, Settings _settings)
        {
            if (snake != null)
            {
                DrawSnakePiece(e, snake.Head, _settings);

                if (snake.Body.Count > 0)
                {
                    foreach (var snakeBodyPiece in snake.Body)
                    {
                        DrawSnakePiece(e, snakeBodyPiece, _settings);
                    }
                }
            }
        }

        public static void DrawFood(PaintEventArgs e, Food food, Settings settings)
        {
            if (food != null)
            {
                // Create solid brush.
                SolidBrush blueBrush = new SolidBrush(Color.Red);

                // Create rectangle.
                Rectangle rect = new Rectangle(food.X, food.Y, settings.PieceSize, settings.PieceSize);

                // Fill rectangle to screen.
                e.Graphics.FillEllipse(blueBrush, rect);
            }
        }

        /// <summary>
        /// Draw a snake piece on the PictureBox
        /// </summary>
        /// <param name="e"></param>
        /// <param name="snakePiece"></param>
        private static void DrawSnakePiece(PaintEventArgs e, SnakePiece snakePiece, Settings settings)
        {
            // Create solid brush.
            SolidBrush blueBrush = new SolidBrush(snakePiece.GetSnakePieceColor());

            // Create rectangle.
            Rectangle rect = new Rectangle(snakePiece.X, snakePiece.Y, settings.PieceSize, settings.PieceSize);

            // Fill rectangle to screen.
            e.Graphics.FillRectangle(blueBrush, rect);
        }
    }
}
