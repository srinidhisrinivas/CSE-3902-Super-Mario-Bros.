using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class BowserFireball : Projectile
    {
        public enum FireballDirections { Left, Right };
        public BowserFireball(Vector2 bowserLocation, Rectangle bowserHitBox) : base(bowserLocation)
        {
            this.Location -= new Vector2(BlockUtility.zeroCheck, bowserHitBox.Height / BlockUtility.three);
            this.yAcceleration = BlockUtility.bowserFireballYAcceleration;
            this.ProjectileState = new LeftBowserFireballState(this);
        }
        public override void Bounce()
        {
            ProjectileState.Bounce();
        }

    }
}
