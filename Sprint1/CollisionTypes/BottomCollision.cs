using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class BottomCollision : Collision
    {
        public BottomCollision(Rectangle intersectingRectangle) : base(intersectingRectangle)
        {
        }
    }
}
