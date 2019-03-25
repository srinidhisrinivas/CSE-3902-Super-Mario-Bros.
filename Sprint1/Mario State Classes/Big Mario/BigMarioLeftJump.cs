using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class BigMarioLeftJump : BigMarioLeft
    {
        public BigMarioLeftJump(IMario mario) : base(mario)
        {
            MarioSprite = MarioSpriteFactory.Instance.CreateBigMarioLeftJumpSprite();
        }
        public override void Jump()
        {
        }
        public override void GoRight()
        {
            base.JumpingRightMotion();

        }
        public override void Stand()
        {
            Mario.State = new BigMarioLeftIdle(Mario);
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
        public override void BecomeFire()
        {
            Mario.State = new FireMarioLeftJump(Mario);
        }
        
        
    }
}
