using SnakeGame.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        private SnakePiece _snakePiece;
        private Settings _settings;

        public Form1()
        {
            InitializeComponent();

            _snakePiece = new SnakePiece(0, 0, true);
            _settings = new Settings();

            StartGameTimer();
        }

        private void gameBox_Paint(object sender, PaintEventArgs e)
        {
            DrawSnakePiece(e, _snakePiece);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    _settings.Direction = Enums.Directions.Up;
                    break;
                case Keys.Down:
                    _settings.Direction = Enums.Directions.Down;
                    break;
                case Keys.Left:
                    _settings.Direction = Enums.Directions.Left;
                    break;
                case Keys.Right:
                    _settings.Direction = Enums.Directions.Right;
                    break;
            }
        }

        private void StartGameTimer()
        {
            gameTimer.Interval = 1000 / 50; // Changing the game time to settings speed
            gameTimer.Tick += UpdateScreen; // linking a updateScreen function to the timer
            gameTimer.Start(); // starting the timer
        }

        public void UpdateScreen(object sender, EventArgs e)
        {
            UpdateSnakePositionBasedOnDirection();
            gameBox.Invalidate();
        }

        private void UpdateSnakePositionBasedOnDirection()
        {
            switch (_settings.Direction)
            {
                case Enums.Directions.Up:
                    _snakePiece.Y--;
                    break;
                case Enums.Directions.Down:
                    _snakePiece.Y++;
                    break;
                case Enums.Directions.Left:
                    _snakePiece.X--;
                    break;
                case Enums.Directions.Right:
                    _snakePiece.X++;
                    break;
            }
        }

        private void DrawSnakePiece(PaintEventArgs e, SnakePiece snakePiece)
        {
            // Create solid brush.
            SolidBrush blueBrush = new SolidBrush(GetSnakePieceColor(snakePiece));

            // Create rectangle.
            Rectangle rect = new Rectangle(snakePiece.X, snakePiece.Y, 10, 10);

            // Fill rectangle to screen.
            e.Graphics.FillRectangle(blueBrush, rect);
        }

        private Color GetSnakePieceColor(SnakePiece snakePiece)
        {
            return snakePiece.IsHead ? Color.Black : Color.Green;
        }
    }
}
