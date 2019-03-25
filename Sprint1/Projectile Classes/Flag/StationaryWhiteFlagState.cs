using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class StationaryWhiteFlagState : ProjectileState
    {
        public StationaryWhiteFlagState(IProjectile projectile) : base(projectile)
        {
            this.ProjectileSprite = ProjectileSpriteFactory.Instance.CreateWhiteFlagSprite();
        }
    }
}
