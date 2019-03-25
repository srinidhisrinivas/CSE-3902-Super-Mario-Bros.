using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandMoveItemRightAndGoRight : ItemCollisionCommand
    {
        
        public CommandMoveItemRightAndGoRight(IItem item, ICollision side) : base(item, side)
        {
          
        }
        public override void Execute()
        {
            new CommandMoveEntityRight(item, side);
            item.ChangeDirection();
        }
    }
}