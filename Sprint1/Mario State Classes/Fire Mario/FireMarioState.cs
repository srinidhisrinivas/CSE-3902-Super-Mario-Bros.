using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class FireMarioState : MarioState
    {

        protected FireMarioState(IMario mario) : base(mario)
        {
            mario.PowerType = new FireMarioType();
        }
        public override void BecomeBig()
        {

        }
        public override void BecomeFire()
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
            Mario.State = new FireMarioRightFlagPole(Mario);
        }
        public override void RunRight(int time)
        {
            Mario.State = new FireMarioAutoRightRun(Mario, time);
        }

    }

}
