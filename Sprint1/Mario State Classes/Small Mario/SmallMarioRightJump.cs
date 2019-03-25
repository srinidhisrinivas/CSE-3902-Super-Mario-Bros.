using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class SmallMarioRightJump : SmallMarioState
    {

        public SmallMarioRightJump(IMario mario) : base(mario)
        {
            MarioSprite = MarioSpriteFactory.Instance.CreateSmallMarioRightJumpSprite();
        }
        public override void Stand()
        {
            Mario.State = new SmallMarioRightIdle(Mario);
        }
        public override void Jump()
        {

        }
        public override void GoLeft()
        {
            base.JumpingLeftMotion();
        }
        public override void Crouch()
        {

        }
        public override void BecomeBig()
        {
            Mario.State = new SmallToBigMarioRight(Mario);
        }
    }
}