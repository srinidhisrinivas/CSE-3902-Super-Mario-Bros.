using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class RigidBodyCollision : CollisionCommand
    {
        protected IRigidBody body { get; set; }
        protected RigidBodyCollision(IRigidBody body, ICollision side) : base(side)
        {
            this.body = body;
        }
    }
}
