using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SomaSnake
{
    public class BodyElement : GotPosition
    {
        public BodyElement() { 
                // kéne???
        }

        public BodyElement(int x, int y)
        {
            this.position_x = x;
            this.position_y = y;
        }

        public BodyElement(BodyElement element) // c++-ban én ezt referenciával, vagy pointerrel oldanám meg. itt ugye azért nem kell mert referenciatípus a class nem?
        {
            this.position_x = element.lastPosition_x;
            this.position_y = element.lastPosition_y;
        }

        public BodyElement(Snake head)
        {
            this.position_x = head.LastPositionX;
            this.position_y = head.LastPositionY;
        }

    }
}
