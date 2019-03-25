using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class SmallMarioLeftRun : SmallMarioState
    {

        public SmallMarioLeftRun(IMario mario) : base(mario)
        {
            MarioSprite = MarioSpriteFactory.Instance.CreateSmallMarioLeftRunSprite();
        }

        public override void Jump()
        {
            base.Jump();
            Mario.State = new SmallMarioLeftJump(Mario);
        }
        public override void GoRight()
        {
            Mario.State = new SmallMarioLeftIdle(Mario);
        }
        public override void GoLeft()
        {

        }
      
        public override void BecomeBig()
        {
            Mario.State = new SmallToBigMarioLeft(Mario);
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