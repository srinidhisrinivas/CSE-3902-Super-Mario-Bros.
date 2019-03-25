using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandMarioBumpItemBlock : BlockCollisionCommand
    {

        public CommandMarioBumpItemBlock(IMario mario, IBlock block, ICollision side) : base(mario, block, side)
        {

        }
        public override void Execute()
        {
            if (!(mario.VerticalMotionState is FallingState))
            {
                SoundManager.PlaySoundEffect(SoundUtility.powerAppearSoundEffect);
                new CommandMarioBumpBlock(mario, block, side).Execute();


            }

        }
    }
}