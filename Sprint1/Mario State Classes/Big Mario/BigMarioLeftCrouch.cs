using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class BigMarioLeftCrouch : BigMarioLeft
    {
        public BigMarioLeftCrouch(IMario mario) : base(mario)
        {
            Mario.StopMotionX();
            MarioSprite = MarioSpriteFactory.Instance.CreateBigMarioLeftCrouchSprite();
             
        }
        public override void Jump()
        {

        }
        public override void GoLeft()
        {

        }
        public override void GoRight()
        {

        }
        public override void BecomeFire()
        {
            Mario.State = new FireMarioLeftCrouch(Mario);
        }
    }
}
