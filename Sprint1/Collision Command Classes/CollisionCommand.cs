using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class CollisionCommand : ICommand
    {
        protected IMario mario { get; set; }
        protected ICollision side { get; set; }
        protected CollisionCommand(IMario mario, ICollision side)
        {
            this.mario = mario;
            this.side = side;
        }
        protected CollisionCommand(IMario mario) : this(mario, null)
        {

        }
        protected CollisionCommand(ICollision side) : this(null, side)
        {

        }
        public abstract void Execute();
    }

}
