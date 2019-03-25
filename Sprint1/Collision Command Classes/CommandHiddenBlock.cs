﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandHiddenBlock : ICommand
    {
        private Game1 game;
        public CommandHiddenBlock(Game1 game)
        {
            this.game = game;
        }
        public void Execute()
        {
            game.HiddenBlock.PerformAction();
        }
    }
}