using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class SmallMarioLeftCrouch : SmallMarioState
    {

        public SmallMarioLeftCrouch(IMario mario) : base(mario)
        {
            Mario.StopMotionX();
            MarioSprite = MarioSpriteFactory.Instance.CreateSmallMarioLeftIdleSprite();
        }

        public override void Jump()
        {
            Mario.State = new SmallMarioLeftIdle(Mario);
        }
        public override void BecomeBig()
        {
            Mario.State = new SmallToBigMarioLeft(Mario);
        }
        public override void GoRight()
        {
            
        }

        public override void GoLeft()
        {
            
        }
        public override void Fall()
        {
            Mario.State = new SmallMarioLeftJump(Mario);
        }
        public override void Idle()
        {
            Mario.State = new SmallMarioLeftIdle(Mario);

        }


    }
}
