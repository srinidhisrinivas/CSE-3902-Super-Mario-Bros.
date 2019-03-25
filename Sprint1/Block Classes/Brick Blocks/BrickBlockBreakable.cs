using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class BrickBlockBreakable : Block
    {
        protected BrickBlockBreakable(Vector2 location) : base(location)
        {
            this.BlockState = new BreakableBlockState(this);
        }
        public override void PerformAction()
        {
            
        }
    }
}
