using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class BigMarioRightRun : BigMarioRight
    {

        public BigMarioRightRun(IMario mario) : base(mario)
        {
            MarioSprite = MarioSpriteFactory.Instance.CreateBigMarioRightRunSprite();
        }

        public override void Jump()
        {
            base.Jump();
            Mario.State = new BigMarioRightJump(Mario);
        }
        public override void GoLeft()
        {
            Mario.State = new BigMarioRightIdle(Mario);
        }
        public override void GoRight()
        {
            
        }
        public override void Crouch()
        {
            Mario.State = new BigMarioRightCrouch(Mario);
        }
       
        public override void BecomeFire()
        {
            Mario.State = new FireMarioRightRun(Mario);
        }
        
    }
}