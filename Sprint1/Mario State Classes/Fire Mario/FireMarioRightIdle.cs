using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class FireMarioRightIdle : FireMarioRight
    {

        public FireMarioRightIdle(IMario mario): base(mario)
        {
            Mario.xVelocity = MarioUtility.marioXVelocity;
            MarioSprite = MarioSpriteFactory.Instance.CreateFireMarioRightIdleSprite();
        }

        public override void Jump()
        {
            base.Jump();
            Mario.State = new FireMarioRightJump(Mario);
        }
        public override void GoLeft()
        {
            Mario.State = new FireMarioLeftIdle(Mario);
        }
        public override void GoRight()
        {
            base.GoRight();
            Mario.State = new FireMarioRightRun(Mario);
        }
        public override void Crouch()
        {
            Mario.State = new FireMarioRightCrouch(Mario);
        }
        
        public override void Idle()
        {
           
        }
        public override void ShootFireball()
        {
            LevelEditFactory.AddProjectile(new Fireball(Mario, Fireball.FireballDirections.Right));
        }
    }
}