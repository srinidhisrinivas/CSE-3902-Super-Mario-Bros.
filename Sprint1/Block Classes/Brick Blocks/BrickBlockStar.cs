using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class BrickBlockStar : Block
    {
        protected BrickBlockStar(Vector2 location) : base(location)
        {
            this.PowerUp = new Star(this.Location);
            this.BlockState = new BumpableBlockState(this);
        }

    }
}
