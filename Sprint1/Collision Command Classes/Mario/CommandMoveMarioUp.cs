using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandMoveMarioUp : MarioCollisionCommand
    {
       
        public CommandMoveMarioUp(IMario mario, ICollision side) : base(mario, side)
        {
           
        }
        public override void Execute()
        {
            if(!(mario.VerticalMotionState is RisingState))
            {
                mario.Stand();
            }
            mario.Location -= new Vector2(SpriteUtility.xOrigin, side.IntersectingRectangle.Height);

        }
    }
}