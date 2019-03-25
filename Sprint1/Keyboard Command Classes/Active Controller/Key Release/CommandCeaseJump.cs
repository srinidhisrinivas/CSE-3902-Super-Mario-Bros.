using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandCeaseJump : KeyboardCommand
    {
        public CommandCeaseJump(Game1 game) : base(game)
        {
        }
        public override void Execute()
        {
            game.Mario.ResetGravity();
        }
    }
}