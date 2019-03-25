﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandSmall : ICommand
    {
        private Game1 game;
        public CommandSmall(Game1 game)
        {
            this.game = game;
        }
        public void Execute()
        {
           game.Mario.BecomeSmall();
        }
    }
}