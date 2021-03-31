using SnakeGame.Enums;
using SnakeGame.Models;
using SnakeGame.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        private Snake _snake;
        private Settings _settings;
        private Food _food;

        public Form1()
        {
            InitializeComponent();

            _snake = new Snake();

            _settings = new Settings();

            AddNewFoodInARandomPlace();
            StartGameTimer();
        }

        private void GameBox_Paint(object sender, PaintEventArgs e)
        {
            GraphicsEngine.DrawFood(e, _food, _settings);
            GraphicsEngine.DrawSnake(e, _snake, _settings);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    _settings.Direction = Directions.Up;
                    break;
                case Keys.Down:
                    _settings.Direction = Directions.Down;
                    break;
                case Keys.Left:
                    _settings.Direction = Directions.Left;
                    break;
                case Keys.Right:
                    _settings.Direction = Directions.Right;
                    break;
            }
        }

        private void StartGameTimer()
        {
            gameTimer.Interval = 1000 / 7; // Changing the game time to settings speed
            gameTimer.Tick += UpdateScreen; // linking a updateScreen function to the timer
            gameTimer.Start(); // starting the timer
        }

        public void UpdateScreen(object sender, EventArgs e)
        {
            UpdateSnakePositionBasedOnDirection();
            CheckIfFoodWasEatenByTheSnake();
            gameBox.Invalidate();
        }

        /// <summary>
        /// It does a loop in the body pieces updating each piece based on the position on the next piece in the array. And then update the head position based on the direction the snake is moving
        /// </summary>
        private void UpdateSnakePositionBasedOnDirection()
        {
            UpdateSnakeBodyPosition();

            switch (_settings.Direction)
            {
                case Directions.Up:
                    _snake.Head.Y -= _settings.PieceSize;
                    break;
                case Directions.Down:
                    _snake.Head.Y += _settings.PieceSize;
                    break;
                case Directions.Left:
                    _snake.Head.X -= _settings.PieceSize;
                    break;
                case Directions.Right:
                    _snake.Head.X += _settings.PieceSize;
                    break;
            }
        }

        /// <summary>
        /// It does a loop through each part of the body from the last piece to the first one and update the position of previous piece to the position of the next one in the array.
        /// In that way it keeps the body moving following the history of movements applied
        /// </summary>
        private void UpdateSnakeBodyPosition()
        {
            if (_snake.Body.Count > 0)
            {
                for (int i = _snake.Body.Count - 1; i >= 0; i--)
                {
                    if (i == 0)
                    {
                        _snake.Body[i].X = _snake.Head.X;
                        _snake.Body[i].Y = _snake.Head.Y;
                    }
                    else
                    {
                        _snake.Body[i].X = _snake.Body[i - 1].X;
                        _snake.Body[i].Y = _snake.Body[i - 1].Y;
                    }
                }
            }
        }

        private void AddNewFoodInARandomPlace()
        {
            int maxWidth = gameBox.Width / _settings.PieceSize;
            int maxHeight = gameBox.Height / _settings.PieceSize;

            var randomXPoint = new Random().Next(0, maxWidth) * _settings.PieceSize;
            var randomYPoint = new Random().Next(0, maxHeight) * _settings.PieceSize;

            if (_food == null)
            {
                _food = new Food(randomXPoint, randomYPoint);
            }
            else
            {
                _food.X = randomXPoint;
                _food.Y = randomYPoint;
            }
        }

        /// <summary>
        /// If the position of the head of the snake is equals to the position of the food, it adds a new piece to the body of the snake and adds a new food on some random place
        /// </summary>
        private void CheckIfFoodWasEatenByTheSnake()
        {
            if (_snake.Head.Equals(_food))
            {
                AddNewSnakePieceToBodyAfterEat();

                AddNewFoodInARandomPlace();
            }
        }

        /// <summary>
        /// Add a new piece at the end of the body of the snake after eat a food
        /// </summary>
        private void AddNewSnakePieceToBodyAfterEat()
        {
            SnakePiece lastSnakePiece = _snake.Body.Count > 0 ? _snake.Body.LastOrDefault() : _snake.Head;
            SnakePiece newBodyPiece = null;
            switch (_settings.Direction)
            {
                case Directions.Up:
                    newBodyPiece = new SnakePiece(lastSnakePiece.X, lastSnakePiece.Y + _settings.PieceSize);
                    break;
                case Directions.Down:
                    newBodyPiece = new SnakePiece(lastSnakePiece.X, lastSnakePiece.Y - _settings.PieceSize);
                    break;
                case Directions.Left:
                    newBodyPiece = new SnakePiece(lastSnakePiece.X + _settings.PieceSize, lastSnakePiece.Y);
                    break;
                case Directions.Right:
                    newBodyPiece = new SnakePiece(lastSnakePiece.X - _settings.PieceSize, lastSnakePiece.Y);
                    break;
            }

            if (newBodyPiece != null)
            {
                _snake.Body.Add(newBodyPiece);
            }
        }
    }
}
