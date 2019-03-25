using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandDown : KeyboardCommand
    {
        public CommandDown(Game1 game) : base(game)
        {
        }
        public override void Execute()
        {
            if (!(game.Mario is MagicMario))
            {
                game.Level.PortalManager.SwitchOnAllPortals();
            }
            game.Mario.Crouch();
     
        }

    }
}