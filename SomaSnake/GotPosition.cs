using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SomaSnake
{
    public abstract class GotPosition
    {
        protected int position_x;
        protected int position_y;
        protected int lastPosition_x;
        protected int lastPosition_y;

        public int PositionX
        {
            get { return position_x; }
            set
            {
                if (value <= 700 && value >= 0)
                    position_x = value;
                else
                    throw new ArgumentException("Position X must be between 0 and 700!");
            }
        }

        public int PostitionY
        {
            get { return position_y; }
            set
            {
                if (value <= 700 && value >= 0)
                    position_y = value;
                else
                    throw new ArgumentException("Position Y must be between 0 and 700!");
            }
        }

        public int LastPositionX
        {
            get { return lastPosition_x; }
            set
            {
                if (value <= 700 && value >= 0)
                    lastPosition_x = value;
                else
                    throw new ArgumentException("Position X must be between 0 and 700!");
            }
        }

        public int LastPositionY
        {
            get { return lastPosition_y; }
            set
            {
                if (value <= 700 && value >= 0)
                    lastPosition_y = value;         // ha ide csak simán position_y írok és a feljebb lévő lastpositionx-hez is akkor a program nem száll el, csak a 3. kockától a bal felső sarokba rajzolja. majd nézd meg miért, mert érdekes
                else
                    throw new ArgumentException("Position Y must be between 0 and 700!");
            }
        }

        public virtual void Draw(PaintEventArgs e)      // egyelőre nincs rá szükség, de asszem nem zavar itt
        {
            throw new System.NotImplementedException();
        }

    }
}
