using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class BreakableBlockState : BlockStateAbstract
    {
        public BreakableBlockState(IBlock block) : base(block)
        {
            

        }
        public override void GetBumped()
        {
            Block.BlockState = new BumpedBrickBlock(Block);
        }
        public override void GetBroken()
        {
            Block.BlockState = new BrokenBlock(Block);
        }

    }
}