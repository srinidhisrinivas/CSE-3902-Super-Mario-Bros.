using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandQuestionBlock : ICommand
    {
        private Game1 game;
        public CommandQuestionBlock(Game1 game)
        {
            this.game = game;
        }
        public void Execute()
        {
            game.QuestionBlock.PerformAction();
        }
    }
}