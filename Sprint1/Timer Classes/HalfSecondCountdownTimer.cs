using Microsoft.Xna.Framework;

namespace CSE3902
{
   
    public class HalfSecondCountdownTimer : CountdownTimer
    {
        
        public HalfSecondCountdownTimer(int initTimeValue, int warningTime) : base(initTimeValue, ScoreUtility.halfSecMsTimeStep, warningTime)
        {
           
        }
    }
}