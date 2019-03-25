using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandBigOrFireMarioBumpPowerUpBlock : BlockCollisionCommand
    {

        public CommandBigOrFireMarioBumpPowerUpBlock(IMario mario, IBlock block, ICollision side) : base(mario, block, side)
        {

        }
        public override void Execute()
        {
            if (!(mario.VerticalMotionState is FallingState))
            {
                block.PowerUp = new Flower(block.Location);
                new CommandMarioBumpItemBlock(mario, block, side).Execute();
            }

        }
    }
}