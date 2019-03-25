using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class LeftBowserFireballState : ProjectileState
    {
        public LeftBowserFireballState(IProjectile projectile) : base(projectile)
        {
            this.ProjectileSprite = ProjectileSpriteFactory.Instance.CreateBowserFireballSprite();
            this.Projectile.xVelocity = BlockUtility.projectileXVelocity;
        }
        public override void Destroy()
        {
            Projectile.ProjectileState = new InactiveFireballState(Projectile);
        }
        public override void Bounce()
        {
          
        }
    }
}
