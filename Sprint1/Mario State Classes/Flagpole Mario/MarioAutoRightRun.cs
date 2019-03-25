using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class MarioAutoRightRun : FlagPoleMarioState
    {
        protected int stateTimer { get; set; }
        private ICommand winGame;
        protected MarioAutoRightRun(IMario mario, int time) : base(mario)
        {
            stateTimer = time;
            winGame = new CommandWinGame();
        }
        public override void Update(GameTime gameTime)
        {
            Mario.xVelocity = 2f;
            stateTimer--;
            if (stateTimer == 0)
            {
                Mario.StopMotionX();
                Mario.State = NextState;

                winGame.Execute();
            }
            else
            {
                MarioSprite.Update(gameTime);
            }
        }

    }
}