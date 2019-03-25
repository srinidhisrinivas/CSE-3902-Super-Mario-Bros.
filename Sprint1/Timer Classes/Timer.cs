using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class CountdownTimer : ITimer
    {
        public TimerElapsedAction ElapsedActions { get; set; }
        public TimerElapsedAction WarningActions { get; set; }
        public TimerElapsedAction OnTickActions { get; set; }
        public int RemainingTime { get; protected set; }

        protected int msTimeStep { get; set; }
        protected int initTimeValue { get; set; }
        protected int warningTime { get; set; }
        protected int previousRealTimeValue { get; set; }

        protected bool isPaused { get; set; }
        protected bool warningSignalled { get; set; }

        protected CountdownTimer(int initTimeValue, int msTimeStep, int warningTime)
        {
            this.ElapsedActions += new TimerElapsedAction(() => { });
            this.WarningActions += new TimerElapsedAction(() => { });
            this.OnTickActions += new TimerElapsedAction(() => { });

            this.RemainingTime = initTimeValue;
            this.initTimeValue = initTimeValue;
            this.msTimeStep = msTimeStep;
            this.warningTime = warningTime;

            this.isPaused = false;
            this.warningSignalled = false;

            this.previousRealTimeValue = ScoreUtility.previousRealTimeInit;
        }
        public virtual void Update(GameTime gameTime)
        {
            if (previousRealTimeValue == ScoreUtility.previousRealTimeInit)
            {
                previousRealTimeValue = (int)gameTime.TotalGameTime.TotalMilliseconds;
            }
            int currentRealTimeValue = (int)gameTime.TotalGameTime.TotalMilliseconds;
            if (currentRealTimeValue - previousRealTimeValue > msTimeStep)
            {
                if (!isPaused)
                {
                    RemainingTime--;
                }
                previousRealTimeValue = currentRealTimeValue;
            }
            if ((RemainingTime == this.warningTime) && !isPaused && !warningSignalled)
            {
                warningSignalled = true;
                this.WarningActions();

            }
            if ((RemainingTime == ScoreUtility.minRemainingTime) && !isPaused)
            {
                this.TogglePause();
                this.ElapsedActions();
            }
        }
        public virtual void TogglePause()
        {
            this.isPaused = true;
        }
        public virtual void Reset()
        {
            this.isPaused = false;
            this.warningSignalled = false;
            this.RemainingTime = initTimeValue;
        }
    }
    
}
