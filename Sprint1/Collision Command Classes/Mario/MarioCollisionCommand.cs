using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class MarioCollisionCommand : CollisionCommand
    {
       
        protected MarioCollisionCommand(IMario mario) : this(mario, null)
        {
            
        }
        protected MarioCollisionCommand(IMario mario, ICollision side) : base(mario, side)
        {
            this.mario = mario;
        }
    }
}
