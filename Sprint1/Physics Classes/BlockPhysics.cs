using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class BlockPhysics : UniversalPhysics
    {
        protected BlockPhysics(Vector2 location) : base(location)
        {
            this.yAcceleration = BlockUtility.blockGravity;
        }
        public override void ResetGravity()
        {
            this.yAcceleration = BlockUtility.blockGravity;
        }
    }
}
