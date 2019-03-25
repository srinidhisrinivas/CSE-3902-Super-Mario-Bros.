using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class SmallMarioRightCrouch : SmallMarioState
    {

        public SmallMarioRightCrouch(IMario mario): base(mario)
        {
            Mario.StopMotionX();
            MarioSprite = MarioSpriteFactory.Instance.CreateSmallMarioRightIdleSprite();
        }

        public override void Jump()
        {
            Mario.State = new SmallMarioRightIdle(Mario);
        }

        public override void GoLeft()
        {

        }
        public override void GoRight()
        {

        }
        public override void BecomeBig()
        {
            Mario.State = new SmallToBigMarioRight(Mario);
        }
        public override void Fall()
        {
            Mario.State = new SmallMarioRightJump(Mario);
        }
        public override void Idle()
        {
            Mario.State = new SmallMarioRightIdle(Mario);

        }

    }
}
