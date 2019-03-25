using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class SmallMarioRightRun : SmallMarioState
    {

        public SmallMarioRightRun(IMario mario) : base(mario)
        {
            MarioSprite = MarioSpriteFactory.Instance.CreateSmallMarioRightRunSprite();
        }

        public override void Jump()
        {
            base.Jump();
            Mario.State = new SmallMarioRightJump(Mario);
        }
        public override void GoLeft()
        {

            Mario.State = new SmallMarioRightIdle(Mario);
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
