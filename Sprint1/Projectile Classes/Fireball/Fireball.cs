using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class Fireball : Projectile
    {
        public enum FireballDirections {Left, Right};
        public Fireball(IMario mario, FireballDirections fireballDirection) : base(mario.Location, mario)
        {
            this.Location -= new Vector2(0, mario.HitBox.Height / ItemUtility.fireballLocation);
            this.yVelocity = ItemUtility.fireballYVelocity;
            this.ProjectileState = new ActiveFireballState(this);
            switch (fireballDirection)
            {
                case FireballDirections.Left:
                    this.xVelocity = mario.xVelocity - ItemUtility.fireballXVelocity;
                    break;
                case FireballDirections.Right:
                    this.xVelocity = mario.xVelocity + ItemUtility.fireballXVelocity;
                    break;
            }
        }
        public override void Bounce()
        {
            ProjectileState.Bounce();
        }
        
    }
}
