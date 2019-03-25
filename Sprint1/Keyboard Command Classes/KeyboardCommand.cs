using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class KeyboardCommand : ICommand
    {
        protected Game1 game { get; set; }
        protected KeyboardCommand(Game1 game)
        {
            this.game = game;
        }
        public abstract void Execute();
    }
}
