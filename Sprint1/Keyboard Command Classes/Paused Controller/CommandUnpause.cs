using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandUnpause : KeyboardCommand
    {
        public CommandUnpause(Game1 game) : base(game)
        {
           
        }
        public override void Execute()
        {
            if (game.Level.isMagic)
            {
                game.ChangeGameState(Game1.GameStates.Magic);
            }
            else
            {
                game.ChangeGameState(Game1.GameStates.Active);
            }
        }

    }
}