using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class FlagPoleMarioState : MarioState
    {
        protected IMarioState NextState { get; set; }
        protected FlagPoleMarioState(IMario mario) : base(mario)
        {
            mario.PowerType = new SmallMarioType();
            mario.StopMotionX();

        }
        public override void Run()
        {

        }
        public override void GoLeft()
        {

        }
        public override void GoRight()
        {

        }
        public override void Update(GameTime gameTime)
        {
            Mario.yVelocity = MarioUtility.flagPoleMarioYVelocity;
            if (Mario.Location.Y > MarioUtility.marioYLocation360)
            {
                Mario.Location += MarioUtility.marioLocation360;
                Mario.State = NextState;
            }
            else
            {
                base.Update(gameTime);
                MarioSprite.Update(gameTime);
            }
        }

    }

}