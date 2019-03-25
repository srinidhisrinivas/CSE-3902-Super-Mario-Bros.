using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class BigMarioState : MarioState
    {

        protected BigMarioState(IMario mario) : base(mario)
        {
            mario.PowerType = new BigMarioType();
        }
        
        public override void BecomeBig()
        {

        }
        public override void Jump()
        {
            SoundManager.PlaySoundEffect("SuperJump");
            this.Mario.yVelocity = MarioUtility.marioYVelocity;
            this.Mario.yAcceleration = MarioUtility.marioYAcceleration;
        }
        public override void DescendFlagpole()
        {
            Mario.State = new BigMarioRightFlagPole(Mario);
        }
        public override void RunRight(int time)
        {
            Mario.State = new BigMarioAutoRightRun(Mario, time);
        }
    }

}
