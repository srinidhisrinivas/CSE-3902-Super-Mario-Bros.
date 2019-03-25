using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class BlockCollisionCommand : CollisionCommand
    {
        protected IBlock block { get; set; }
        
        protected BlockCollisionCommand(IMario mario, IBlock block, ICollision side) : base(mario, side)
        {
            this.block = block;
        }
    }
    
}
