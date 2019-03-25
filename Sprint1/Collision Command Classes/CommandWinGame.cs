using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandWinGame : ICommand
    {
        public CommandWinGame()
        {
        }
        public void Execute()
        {
            Game1.Instance.KeyboardController = new InactiveKeyboardController(Game1.Instance);
            Game1.Instance.Level.LevelTimer = new RapidEmptyTimer(Game1.Instance.Level.LevelTimer.RemainingTime);
            Game1.Instance.Level.LevelTimer.OnTickActions += () => ScoreManager.Instance.HandleTimerCoinAddition(Game1.Instance.Mario.Scoreboard);
            Game1.Instance.Level.LevelTimer.ElapsedActions += () =>
            {
                Game1.Instance.Level.ProgressLevel();
            };

        }

    }
}