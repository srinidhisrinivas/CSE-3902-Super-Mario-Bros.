using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class BigMarioRightJump : BigMarioRight
    {

        public BigMarioRightJump(IMario mario): base(mario)
        {
            MarioSprite = MarioSpriteFactory.Instance.CreateBigMarioRightJumpSprite();
        }
       
        public override void Crouch()
        {
        }
        public override void GoLeft()
        {
            base.JumpingLeftMotion();
        }
        public override void Stand()
        {
            Mario.State = new BigMarioRightIdle(Mario);
        }

        public override void Fall()
        {
           
        }
        public override void Idle()
        {

        }
        public override void Jump()
        {
           
        }
        public override void BecomeFire()
        {
            Mario.State = new FireMarioRightJump(Mario);
        }
        
    }
}