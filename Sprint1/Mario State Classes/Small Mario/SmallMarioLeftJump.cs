using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class SmallMarioLeftJump : SmallMarioState
    {

        public SmallMarioLeftJump(IMario mario) : base(mario)
        {
            MarioSprite = MarioSpriteFactory.Instance.CreateSmallMarioLeftJumpSprite();
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
            Mario.State = new SmallMarioLeftIdle(Mario);
        }
        public override void Crouch()
        {

        }
        public override void BecomeBig()
        {
            Mario.State = new SmallToBigMarioLeft(Mario);
        }

    }
}