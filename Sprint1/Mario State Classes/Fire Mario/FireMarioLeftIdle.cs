using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class FireMarioLeftIdle : FireMarioLeft
    {

        public FireMarioLeftIdle(IMario mario) : base(mario)
        {
            MarioSprite = MarioSpriteFactory.Instance.CreateFireMarioLeftIdleSprite();
            Mario.xVelocity = MarioUtility.marioXVelocity;
        }

        public override void Jump()
        {
            base.Jump();
            Mario.State = new FireMarioLeftJump(Mario);
        }
        public override void GoLeft()
        {
            base.GoLeft();
            Mario.State = new FireMarioLeftRun(Mario);
        }
        public override void GoRight()
        {
            Mario.State = new FireMarioRightIdle(Mario);
        }
        public override void Crouch()
        {
            Mario.State = new FireMarioLeftCrouch(Mario);
        }
       
        public override void Idle()
        {
            
        }
        public override void ShootFireball()
        {
            LevelEditFactory.AddProjectile(new Fireball(Mario, Fireball.FireballDirections.Left));
        }
    }
}