using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class Star : Item
    {
        public Star(Vector2 location) : base(location)
        {
            this.ItemState = new EmergingStarState(this);
        }

    }
}
