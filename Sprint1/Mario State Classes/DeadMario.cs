using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class DeadMario : MarioState
    {
        private int standStillTimer;
        public DeadMario(IMario mario): base(mario)
        {
            SoundManager.StopSong();
            SoundManager.PlaySoundEffect(MarioUtility.marioDie);

            Game1.Instance.KeyboardController = new InactiveKeyboardController(Game1.Instance);
            MarioSprite = MarioSpriteFactory.Instance.CreateDeadMarioSprite();
            mario.PowerType = new DeadMarioType();
            standStillTimer = MarioUtility.deadMarioTimer;
            
            mario.StopMotionX();
            mario.StopMotionY();
            Mario.yAcceleration = MarioUtility.deadMarioYAcceleration;
            
        }
        public override void Crouch()
        {

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
        public override void BecomeBig()
        {
            Mario.State = new BigMarioRightIdle(Mario);
        }
        public override void BecomeFire()
        {
            Mario.State = new FireMarioRightIdle(Mario);
        }
        public override void Die()
        {
            
        }
        public override void Update(GameTime gameTime)
        {
            if(standStillTimer-- == MarioUtility.stateTimerZero)
            {
                Mario.yAcceleration = MarioUtility.movingMarioYAcceleration;
                this.Mario.yVelocity = MarioUtility.deadMarioYVelocity;
            }
            base.Update(gameTime);

            if (Mario.Location.Y > MarioUtility.screenYLimit)
            {
                new CommandMarioDie(Mario).Execute();
            }

        }
    }
}
