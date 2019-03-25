using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class FireMarioRightCrouch : FireMarioRight
    {

        public FireMarioRightCrouch(IMario mario): base(mario)
        {
            Mario.StopMotionX();
            MarioSprite = MarioSpriteFactory.Instance.CreateFireMarioRightCrouchSprite();
        }
        public override void GoLeft()
        {

        }
        public override void GoRight()
        {
            
        }
        
        public override void Jump()
        {
            
        }
       
        public override void ShootFireball()
        {
            LevelEditFactory.AddProjectile(new Fireball(Mario, Fireball.FireballDirections.Right));
        }
    }
}