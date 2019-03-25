using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class Collision : ICollision
    {
        public Rectangle IntersectingRectangle { get; }
        protected Collision(Rectangle intersectingRectangle)
        {
            this.IntersectingRectangle = intersectingRectangle;

        }
    }
}
