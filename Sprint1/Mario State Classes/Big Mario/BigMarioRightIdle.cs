using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class BigMarioRightIdle : BigMarioRight
    {

        public BigMarioRightIdle(IMario mario) : base(mario)
        {
            Mario.xVelocity = MarioUtility.marioXVelocity;
            MarioSprite = MarioSpriteFactory.Instance.CreateBigMarioRightIdleSprite();
        }

        public override void Jump()
        {
            base.Jump();
            Mario.State = new BigMarioRightJump(Mario);
        }
        public override void GoLeft()
        {
            Mario.State = new BigMarioLeftIdle(Mario);
        }
        public override void GoRight()
        {
            base.GoRight();
            Mario.State = new BigMarioRightRun(Mario);
        }
        public override void Crouch()
        {
            Mario.State = new BigMarioRightCrouch(Mario);
        }
       
        public override void BecomeFire()
        {
            Mario.State = new FireMarioRightIdle(Mario);
        }
        public override void Idle()
        {
            
        }
        
    }
}