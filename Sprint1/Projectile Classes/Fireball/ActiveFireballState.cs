using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class ActiveFireballState : ProjectileState
    {
        public ActiveFireballState(IProjectile projectile) : base(projectile)
        {
            this.ProjectileSprite = ProjectileSpriteFactory.Instance.CreateActiveFireballSprite();
        }
        public override void Destroy()
        {
            Projectile.ProjectileState = new InactiveFireballState(Projectile);
        }
        public override void Bounce()
        {
            Projectile.yVelocity = ItemUtility.fireballBounceVelocity;
        }
    }
}
