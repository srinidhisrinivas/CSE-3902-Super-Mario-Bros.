
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class LeftFlagPoleMarioState : FlagPoleMarioState
    {
        protected int stateTimer { get; set; }
        protected LeftFlagPoleMarioState(IMario mario) : base(mario)
        {
            stateTimer = MarioUtility.leftFlagPoleMarioStateTimer;
            mario.StopMotionX();
        }
        public override void Update(GameTime gameTime)
        {
            stateTimer--;
            if (stateTimer == MarioUtility.stateTimerZero)
            {
                Mario.xVelocity = MarioUtility.leftFlagPoleMarioXVelocity;
                Mario.State = NextState;
            }
            else
            {
                MarioSprite.Update(gameTime);
            }
        }

    }

}