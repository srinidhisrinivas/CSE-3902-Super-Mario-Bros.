using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandMoveEntityUp : RigidBodyCollision
    {
        
        public CommandMoveEntityUp(IRigidBody body, ICollision side) : base(body, side)
        {
            
        }
        public override void Execute()
        {
            body.StopMotionY();   
            body.Location -= new Vector2(SpriteUtility.xOrigin, side.IntersectingRectangle.Height);

        }
    }
}