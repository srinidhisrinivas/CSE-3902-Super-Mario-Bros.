using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandMoveMarioRight : MarioCollisionCommand
    {
       
        public CommandMoveMarioRight(IMario mario, ICollision side) : base(mario, side)
        {
            
        }
        public override void Execute()
        {
            mario.Location += new Vector2(side.IntersectingRectangle.Width, SpriteUtility.yOrigin);

        }
    }
}