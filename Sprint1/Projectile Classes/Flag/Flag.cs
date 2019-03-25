using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class Flag : Projectile
    {
        public Flag(Vector2 location) : base(location)
        {
            this.yAcceleration = PhysicsUtility.suspendedGravity;
            this.ProjectileState = new StationaryWhiteFlagState(this);
        }
    }
}
