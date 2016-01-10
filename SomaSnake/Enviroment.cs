using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace SomaSnake
{
    public class Enviroment : GotPosition
    {
        private int type;

        public void Draw(PaintEventArgs e)
        {
            for (int i = 45; i <= 650; i += 5)
            {
                e.Graphics.FillRectangle(Brushes.Brown, i, 45, 5, 5);
                e.Graphics.FillRectangle(Brushes.Brown, i, 650, 5, 5);
            }

            for (int j = 45; j <= 650; j += 5)
            {
                e.Graphics.FillRectangle(Brushes.Brown, 45, j, 5, 5);
                e.Graphics.FillRectangle(Brushes.Brown, 650, j, 5, 5);
            }
      
        }
    }
}
