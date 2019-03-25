using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class FireMarioRightJump : FireMarioRight
    {

        public FireMarioRightJump(IMario mario): base(mario)
        {
            MarioSprite = MarioSpriteFactory.Instance.CreateFireMarioRightJumpSprite();
        }
        public override void Jump()
        {

        }
        public override void GoLeft()
        {
            base.JumpingLeftMotion();
        }
        public override void Crouch()
        {

        }
        public override void Stand()
        {
            Mario.State = new FireMarioRightIdle(Mario);
        }
        public override void Fall()
        {
            
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