using Microsoft.Xna.Framework;

namespace CSE3902
{
    public class BowserBrain
    {
        private IBowser bowser;
        private ITimer fireballTimer;

        public BowserBrain(IBowser bowser)
        {
            this.bowser = bowser;
            this.fireballTimer = new RapidEmptyTimer(BlockUtility.fireballTimer);
            this.fireballTimer.ElapsedActions += new TimerElapsedAction(() => bowser.ShootFireball());
        }
        public void Update(GameTime gameTime)
        {
            if(Game1.Instance.Mario.State is DeadMario)
            {
                bowser.Idle();
                return;
            }
            Vector2 marioLocation = Game1.Instance.Mario.Location;
            if(marioLocation.X >= BlockUtility.two * BlockUtility.sixteen * BlockUtility.marioLocation104)
            {
                if(marioLocation.Y < BlockUtility.marioYLocation200 && bowser.Location.Y > BlockUtility.bowserYLocation480 - BlockUtility.two * BlockUtility.sixteen * BlockUtility.six)
                {
                    bowser.Jump();
                }
                fireballTimer.Update(gameTime);
                if(fireballTimer.RemainingTime == BlockUtility.zeroCheck)
                {
                    fireballTimer.Reset();
                }

                if(marioLocation.X > BlockUtility.two * BlockUtility.sixteen * BlockUtility.bowserXLocation126)
                {
                    if (marioLocation.X > bowser.Location.X)
                    {
                        bowser.GoRight();
                    }
                    else
                    {
                        bowser.GoLeft();
                    }
                }
                else
                {
                    bowser.Idle();
                }

            }

        }
    }
}