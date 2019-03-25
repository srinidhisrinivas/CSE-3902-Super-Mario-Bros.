using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandIdle : KeyboardCommand
    {
        public CommandIdle(Game1 game) : base(game)
        {
            
        }
        public override void Execute()
        {
            game.Level.PortalManager.SwitchOffAllPortals();
            game.Mario.Idle();
        }
    }
}