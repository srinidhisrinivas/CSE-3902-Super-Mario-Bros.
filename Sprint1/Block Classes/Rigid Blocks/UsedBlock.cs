using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace CSE3902
    {
        public class UsedBlock : Block
        {
            public UsedBlock(Vector2 location) : base(location)
            {
                this.BlockState = new RigidBlockState(this);
                BlockSprite = BlockSpriteFactory.Instance.CreateUsedBlockSprite();

            }
            public override void GetBumped()
            {

            }
            public override void PerformAction()
            {

            }
        }
    }