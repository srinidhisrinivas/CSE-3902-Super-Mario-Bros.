using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class BumpedBlock : BlockStateAbstract
    {
        
        private int originalYHeight;
        private IBlock bumpedBlock;
        private Type bumpedBlockStateType;
        protected BumpedBlock(IBlock block, Type blockStateType) : base(block)
        {
            this.bumpedBlock = block;
            this.bumpedBlockStateType = blockStateType;
            block.yVelocity = BlockUtility.blockBumpVelocity;
            block.yAcceleration = BlockUtility.blockBumpAcceleration;
            originalYHeight = (int)bumpedBlock.Location.Y;

        }
        public override void Update(GameTime gameTime)
        {
            if(bumpedBlock.Location.Y > originalYHeight)
            {
                bumpedBlock.ResetGravity();
                bumpedBlock.StopMotionY();
                bumpedBlock.Location = new Vector2(bumpedBlock.Location.X, originalYHeight);
                Block.BlockState = (IBlockState)Activator.CreateInstance(this.bumpedBlockStateType, this.bumpedBlock);
                Block.PerformAction();
            }
        }
        public override void GetBumped()
        {

        }

    }
}
