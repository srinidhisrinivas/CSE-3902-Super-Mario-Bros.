using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandPause : KeyboardCommand
    {
        public CommandPause(Game1 game) : base(game)
        {

        }
        public override void Execute()
        {
            game.ChangeGameState(Game1.GameStates.Paused);

        }

    }
}