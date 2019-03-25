using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class BigMarioLeftIdle : BigMarioLeft
    {

        public BigMarioLeftIdle(IMario mario) : base(mario)
        {
            MarioSprite = MarioSpriteFactory.Instance.CreateBigMarioLeftIdleSprite();
            Mario.xVelocity = MarioUtility.marioXVelocity;
        }

        public override void Jump()
        {
            base.Jump();
            Mario.State = new BigMarioLeftJump(Mario);
        }
        public override void GoLeft()
        {
            base.GoLeft();
            Mario.State = new BigMarioLeftRun(Mario);
        }
        public override void GoRight()
        {
            Mario.State = new BigMarioRightIdle(Mario);
        }
        public override void Crouch()
        {
            Mario.State = new BigMarioLeftCrouch(Mario);
        }
        
        public override void BecomeFire()
        {
            Mario.State = new FireMarioLeftIdle(Mario);
        }
        public override void Idle()
        {
            
        }

    }
}
