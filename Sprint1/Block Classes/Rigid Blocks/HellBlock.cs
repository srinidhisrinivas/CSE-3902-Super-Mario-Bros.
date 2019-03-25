using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class HellBlock : Block
    {
        public HellBlock(Vector2 location) : base(location)
        {
            this.BlockState = new RigidBlockState(this);
            BlockSprite = BlockSpriteFactory.Instance.CreateHellBlockSprite();

        }
        public override void GetBumped()
        {

        }
        public override void PerformAction()
        {

        }
    }
}
