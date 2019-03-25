using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandMoveEntityRight : RigidBodyCollision
    {
        
        public CommandMoveEntityRight(IRigidBody body, ICollision side) : base(body, side)
        {
           
        }
        public override void Execute()
        {
            body.Location += new Vector2(side.IntersectingRectangle.Width, SpriteUtility.yOrigin);

        }
    }
}