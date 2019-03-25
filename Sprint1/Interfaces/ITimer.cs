using Microsoft.Xna.Framework;

namespace CSE3902
{
    public interface ITimer
    {
        TimerElapsedAction ElapsedActions { get; set; }
        TimerElapsedAction WarningActions { get; set; }
        TimerElapsedAction OnTickActions { get; set; }
        int RemainingTime { get; }
        void TogglePause();
        void Reset();
        void Update(GameTime gameTime);
        
    }

}