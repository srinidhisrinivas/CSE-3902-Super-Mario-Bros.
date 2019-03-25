using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class ItemCollisionCommand : CollisionCommand
    {
        protected IItem item { get; set; }
        protected ItemCollisionCommand(IMario mario, IItem item, ICollision side) : base(mario, side)
        {
            this.item = item;
        }
        protected ItemCollisionCommand(IItem item, ICollision side) : this(null, item, side)
        {
            
        }
        protected ItemCollisionCommand(IMario mario, IItem item) : this(mario, item, null)
        {

        }
       
        
       

    }
}
