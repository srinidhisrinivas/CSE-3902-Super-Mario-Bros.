using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class FallingWhiteFlagState : ProjectileState
    {
        public FallingWhiteFlagState(IProjectile projectile) : base(projectile)
        {
            this.Projectile.yVelocity = ItemUtility.flagVelocity;
            this.ProjectileSprite = ProjectileSpriteFactory.Instance.CreateWhiteFlagSprite();
        }
        public override void Bounce()
        {
            this.Projectile.ProjectileState = new StationaryWhiteFlagState(this.Projectile);
        }
    }
}
