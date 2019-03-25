using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CSE3902
{
    public class InactiveFireballState : ProjectileState
    {
        private int explosionTimer;
        public InactiveFireballState(IProjectile projectile) : base(projectile)
        {
            Projectile.StopMotionX();
            Projectile.StopMotionY();
            Projectile.yAcceleration = PhysicsUtility.suspendedGravity;
            explosionTimer = ItemUtility.fireballTimer;
            this.ProjectileSprite = ProjectileSpriteFactory.Instance.CreateInactiveFireballSprite();
        }
        public override void Destroy()
        {

        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if(explosionTimer-- == 0)
            {
                LevelEditFactory.RemoveProjectile(Projectile);
            }
        }
    }
}
