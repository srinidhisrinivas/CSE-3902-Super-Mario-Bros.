using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class SmallMarioRightIdle : SmallMarioState
    {

        public SmallMarioRightIdle(IMario mario): base(mario)
        {
            mario.xVelocity = MarioUtility.marioXVelocity;
            MarioSprite = MarioSpriteFactory.Instance.CreateSmallMarioRightIdleSprite();
        }

        public override void Jump()
        {
            base.Jump();
            Mario.State = new SmallMarioRightJump(Mario);
        }
        public override void GoLeft()
        {
            Mario.State = new SmallMarioLeftIdle(Mario);
        }
        public override void GoRight()
        {
            base.GoRight();
            Mario.State = new SmallMarioRightRun(Mario);
        }
        
        public override void BecomeBig()
        {
            Mario.State = new SmallToBigMarioRight(Mario);
        }
        public override void Fall()
        {
            Mario.State = new SmallMarioRightJump(Mario);
        }
        

    }
}
