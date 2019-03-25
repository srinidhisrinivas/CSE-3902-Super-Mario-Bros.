using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandBounceItem : ItemCollisionCommand
    {
        
        public CommandBounceItem(IItem item, ICollision side) : base(item, side)
        {
           
        }
        public override void Execute()
        {
            new CommandMoveEntityUp(item, side).Execute();
            item.Bounce();
        }
    }
}