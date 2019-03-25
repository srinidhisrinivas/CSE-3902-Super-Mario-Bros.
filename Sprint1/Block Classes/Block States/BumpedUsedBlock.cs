using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class BumpedUsedBlock : BumpedBlock
    {

        
        public BumpedUsedBlock(IBlock block) : base(block, typeof(RigidBlockState))
        {
            block.BlockSprite = BlockSpriteFactory.Instance.CreateUsedBlockSprite();

        }
       
        
    }
}
