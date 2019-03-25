using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandBrickBlock : ICommand
    {
        private Game1 game;
        public CommandBrickBlock(Game1 game)
        {
            this.game = game;
        }
        public void Execute()
        {
            game.BrickBlock.PerformAction();
        }
    }
}
