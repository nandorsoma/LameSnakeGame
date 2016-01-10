using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace SomaSnake
{
    public class Food : GotPosition, IDrawable
    {
        private static int nOfFood;
        bool visible;
        Random r = new Random();
        //private string foodType;

        static Food() // statikus konstruktor
        {
            nOfFood = 0;        // ez itt még nem jó, ennek itt inkább nOfFood++-nak kellene lennie. De hol lehet inicializálni egy static int-et?
        }

        public Food()
        {
            this.position_x = r.Next(5, 64)*10;     // így a koordinátája sosem fog eltérni a snaketől, mert osztható 10-el.
            this.position_y = r.Next(5, 64)*10;
            visible = false;
        }


        public void Draw(PaintEventArgs e)
        {
            if (visible)
                e.Graphics.FillRectangle(Brushes.Red, position_x, position_y, 10, 10);
        }

        public void CreateFood()
        {
            if (!visible)
            {
                this.position_x = r.Next(5, 64)*10;
                this.position_y = r.Next(5, 64)*10;
                visible = true;
            }
        }

        public void Eaten()
        {
            visible = false;
        }

        //public string FTYPE
        //{
        //    get { return foodType; }
        //    set
        //    {
        //        if (value == "apple")
        //            this.foodType = "apple";
        //        else
        //            throw new ArgumentException("Theres no such type of food!");
        //    }
        //}


    }


}
