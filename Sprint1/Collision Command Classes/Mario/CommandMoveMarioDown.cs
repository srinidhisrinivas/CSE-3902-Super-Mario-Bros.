using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandMoveMarioDown : MarioCollisionCommand
    {
        
        public CommandMoveMarioDown(IMario mario, ICollision side) : base(mario, side)
        {
            
        }
        public override void Execute()
        {
            
            mario.StopMotionY();
            mario.Location += new Vector2(SpriteUtility.xOrigin, side.IntersectingRectangle.Height);

        }
    }
}