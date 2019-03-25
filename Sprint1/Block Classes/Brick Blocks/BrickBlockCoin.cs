using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class BrickBlockCoin : Block
    {
        protected BrickBlockCoin(Vector2 location) : base(location)
        {
            this.PowerUp = new Coin(this.Location);
            this.BlockState = new BumpableBlockState(this);
        }

    }
}
