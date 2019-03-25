using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class BigMarioLeftRun : BigMarioLeft
    {

        public BigMarioLeftRun(IMario mario) : base(mario)
        {
            MarioSprite = MarioSpriteFactory.Instance.CreateBigMarioLeftRunSprite();
        }

        public override void Jump()
        {
            base.Jump();
            Mario.State = new BigMarioLeftJump(Mario);
        }
        public override void GoRight()
        {
            Mario.State = new BigMarioLeftIdle(Mario);
        }
        public override void GoLeft()
        {

        }
        public override void Crouch()
        {
            Mario.State = new BigMarioLeftCrouch(Mario);
        }

        
        public override void BecomeFire()
        {
            Mario.State = new FireMarioLeftRun(Mario);
        }
       
       

    }
}
