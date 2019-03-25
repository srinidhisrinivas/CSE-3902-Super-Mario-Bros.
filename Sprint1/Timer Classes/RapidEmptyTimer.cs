using Microsoft.Xna.Framework;

namespace CSE3902
{
    public class RapidEmptyTimer : CountdownTimer
    {
        public RapidEmptyTimer(int initTimeValue) : base(initTimeValue, ScoreUtility.rapidMsTimeStep, ScoreUtility.rapidTimeWarning)
        {

        }
    }
}