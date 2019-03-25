
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;


namespace CSE3902
{
    public class PausedKeyboardController : KeyboardController
    {

        public PausedKeyboardController(Game1 game) : base(game)
        {
            this.singleActionControlMappings.Add(Keys.P, new CommandUnpause(game));

        }
       
    }
}
