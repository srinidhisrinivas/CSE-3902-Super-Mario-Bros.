using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class SmallMarioState : MarioState
    {

        protected SmallMarioState(IMario mario) : base(mario)
        {
            mario.PowerType = new SmallMarioType();
        }
        

        public override void TakeDamage()
        {
                Mario.State = new DeadMario(Mario);
        }
        public override void BecomeFire()
        {
            
        }
        public override void Jump()
        {
            SoundManager.PlaySoundEffect("SmallJump");
            this.Mario.yVelocity = MarioUtility.marioYVelocity;
            this.Mario.yAcceleration = MarioUtility.marioYAcceleration;
        }
        public override void Crouch()
        {
            
        }
        public override void DescendFlagpole()
        {
            Mario.State = new SmallMarioRightFlagPole(Mario);
        }
        public override void RunRight(int time)
        {
            Mario.State = new SmallMarioAutoRightRun(Mario, time);
        }
    }

}
