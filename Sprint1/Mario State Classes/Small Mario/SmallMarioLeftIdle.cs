using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class SmallMarioLeftIdle : SmallMarioState
    {

        public SmallMarioLeftIdle(IMario mario) : base(mario)
        {
            mario.xVelocity = MarioUtility.marioXVelocity;
            MarioSprite = MarioSpriteFactory.Instance.CreateSmallMarioLeftIdleSprite();
        }

        public override void Jump()
        {
            base.Jump();
            Mario.State = new SmallMarioLeftJump(Mario);
        }
        public override void GoLeft()
        {
            base.GoLeft();
            Mario.State = new SmallMarioLeftRun(Mario);
        }
        public override void GoRight()
        {
            Mario.State = new SmallMarioRightIdle(Mario);
        }
        
        public override void BecomeBig()
        {
            Mario.State = new SmallToBigMarioLeft(Mario);
        }
        public override void Fall()
        {
            Mario.State = new SmallMarioLeftJump(Mario);
        }
        

    }
}