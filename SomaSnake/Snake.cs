using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;   //  betettem ide hogy az osztály feleljen a kirajzolásáért.
using System.Windows.Forms; //  szintén

namespace SomaSnake
{
    public class Snake : GotPosition, IDrawable
    {
        private int size;
        protected char direction;
        List<BodyElement> body;

        public Snake()
        {
            this.size = 1;
            this.direction = 'u';
            this.position_x = 340;
            this.position_y = 340;
            body = new List<BodyElement>();
        }

        public int SIZE
        {
            get { return size; }
        }

        public char DIRECTION
        {
            get { return direction; }
            set
            {
                if (value == 'u' | value == 'l' | value == 'r' | value == 'd')
                    direction = value;
                else
                    throw new ArgumentException("Direction must be one of these: u(up), l(left), r(right), d(down)");
            }
        }

        public void Move()
        {
            this.lastPosition_x = this.position_x; // mikor kell this és mikor nem?
            this.lastPosition_y = this.position_y;
            
            switch (this.direction)
            {
                case 'r':
                    this.position_x+=10;
                    break;
                case 'd':
                    this.position_y+=10;
                    break;
                case 'l':
                    this.position_x-=10;
                    break;
                case 'u':
                    this.position_y-=10;
                    break;
            }

            MoveBody();
        }

        public void Eat()
        {
            if (this.size == 1)
                body.Add(new BodyElement(this.lastPosition_x, this.lastPosition_y));
            else
                body.Add(new BodyElement(body[size-2].LastPositionX, body[size-2].LastPositionY));

            this.size++;         
        }

        public void Draw(PaintEventArgs e)
        {
            using (Brush brush = new SolidBrush(Color.Green))
            {
                e.Graphics.FillRectangle(brush, position_x, position_y, 10, 10);  // fej - e.Graphics.FillRectangle(Brushes.Green, snake.PX, snake.PY, 10, 10); -- mi van ha this.position_x mi a különbség? azaz itt nem lesz, de mégis
                foreach (BodyElement element in body)
                {
                    e.Graphics.FillRectangle(brush, element.PositionX, element.PostitionY, 10, 10);
                }
            }
        }

        public void DirectionUp()
        {
            direction = 'u';            // ilyen függvények végén nem kell return-t tenni?
        }

        public void DirectionDown()
        {
            direction = 'd';
        }

        public void DirectionRight()
        {
            direction = 'r';
        }

        public void DirectionLeft()
        {
            direction = 'l';
        }

        private void MoveBody()
        {
            //if (size == 2)
            //{
            //    body[0].position_x = this.lastPosition_x;
            //    body[0].position_y = this.lastPosition_y;
            //}
            //else
            //    for (int i = 1; i < body.Count; i++)
            //    {
            //        body[i].position_x = body[i-1].lastPosition_x;
            //        body[i].position_y = body[i-1].lastPosition_y;
            //    }

            if (size >= 2)
            {
                body[0].LastPositionX = body[0].PositionX;
                body[0].LastPositionY = body[0].PostitionY;
                body[0].PositionX = this.lastPosition_x;
                body[0].PostitionY = this.lastPosition_y;

                for (int i = 1; i < body.Count; i++)
                {
                    body[i].LastPositionX = body[i].PositionX;
                    body[i].LastPositionY = body[i].PostitionY;
                    body[i].PositionX = body[i - 1].LastPositionX;
                    body[i].PostitionY = body[i - 1].LastPositionY;
                } 
            }
            

                
        }
    }


}
