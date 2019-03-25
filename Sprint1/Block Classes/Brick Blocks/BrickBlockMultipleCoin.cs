using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class BrickBlockMultipleCoin : BrickBlockCoin
    {
        private int coinCount;

        protected BrickBlockMultipleCoin(Vector2 location) : base(location)
        {
            this.coinCount = BlockUtility.multipleCoinCount;
        }
        public override void GetBumped()
        {
            if (--coinCount == 0)
            {
                base.GetBumped();
            }
            else
            {
                this.PowerUp = new Coin(this.Location);
                this.BlockState = new BumpedBrickBlock(this);
            }
        }
    }
}
