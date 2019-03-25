using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class FireMarioLeftCrouch : FireMarioLeft
    {
       
        public FireMarioLeftCrouch(IMario mario) : base(mario)
        {
            Mario.StopMotionX();
            MarioSprite = MarioSpriteFactory.Instance.CreateFireMarioLeftCrouchSprite();
        }

        public override void Jump()
        {
            
        }
        public override void GoRight()
        {
            
        }
        public override void GoLeft()
        {

        }
        
        
        public override void ShootFireball()
        {
            LevelEditFactory.AddProjectile(new Fireball(Mario, Fireball.FireballDirections.Left));
        }

    }
}
