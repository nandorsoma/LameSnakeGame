using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SomaSnake
{
    public interface IDrawable
    {
        void Draw(PaintEventArgs e);
    }
}
