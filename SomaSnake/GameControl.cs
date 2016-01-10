using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms; // legális, hogy ezt csak úgy beírtam, hogy menjen a KeyEventArgs?

namespace SomaSnake
{
    public class GameControl
    {
        private List<IDrawable> drawable;

        public GameControl()
        {
            this.drawable = new List<IDrawable>();
        }

        public void KeyboardEvent(KeyEventArgs e)
        {
            //switch (e.KeyCode)
            //{
            //    case Keys.W:
            //        snake.DirectionUp();
            //        break;
            //    case Keys.A:
            //        snake.DirectionLeft();
            //        break;
            //    case Keys.D:
            //        snake.DirectionRight();
            //        break;
            //    case Keys.S:
            //        snake.DirectionDown();
            //        break;
            //    case Keys.G:
            //        mainTimer.Start();
            //        foodTimer.Start();
            //        break;
            //    case Keys.H:
            //        mainTimer.Stop();
            //        foodTimer.Stop();
            //        break;
            //}
        }

        public void DrawAll(PaintEventArgs e)
        {
            foreach (IDrawable drawit in drawable)
            {
                drawit.Draw(e);
            }
        }

        public bool CheckCollision(Snake snake, Food food)
        {
            if (snake.PositionX == food.PositionX && snake.PostitionY == food.PostitionY)
            {
                snake.Eat();
                food.Eaten();
                return true;
            }
            else
                return false;
        }
    }
}
