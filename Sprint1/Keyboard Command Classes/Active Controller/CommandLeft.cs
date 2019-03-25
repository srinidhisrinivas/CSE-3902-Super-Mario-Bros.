using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandLeft : KeyboardCommand
    {
        public CommandLeft(Game1 game) : base(game)
        {

        }
        public override void Execute()
        {
            game.Mario.GoLeft();
        }
    }
}
