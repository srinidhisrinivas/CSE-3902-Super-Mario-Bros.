using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class FireMarioLeftJump : FireMarioLeft
    {

        public FireMarioLeftJump(IMario mario) : base(mario)
        {
            MarioSprite = MarioSpriteFactory.Instance.CreateFireMarioLeftJumpSprite();
        }
        public override void GoRight()
        {
            base.JumpingRightMotion();
        }
        public override void Jump()
        {
            
        }
        public override void Crouch()
        {

        }
        public override void Fall()
        {
            
        }
        public override void Idle()
        {

        }
        public override void Stand()
        {
            Mario.State = new FireMarioLeftIdle(Mario);
        }
        public override void ShootFireball()
        {
            LevelEditFactory.AddProjectile(new Fireball(Mario, Fireball.FireballDirections.Left));
        }
    }
}