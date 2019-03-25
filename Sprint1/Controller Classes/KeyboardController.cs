using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class KeyboardController : IController
    {
        protected Dictionary<Keys, ICommand> singleActionControlMappings { get; }
        protected Keys[] previouslyPressedKeys { get; set; }


        protected Game1 game { get; set; }
        protected KeyboardController(Game1 game)
        {
            this.game = game;
            this.previouslyPressedKeys = Keyboard.GetState().GetPressedKeys();

            singleActionControlMappings = new Dictionary<Keys, ICommand>();

            singleActionControlMappings.Add(Keys.R, new CommandReset(game));
            singleActionControlMappings.Add(Keys.Q, new CommandQuit(game));

        }
        public virtual void Update(GameTime gameTime)
        {
            Keys[] pressedKeys = Keyboard.GetState().GetPressedKeys();
            foreach (Keys key in pressedKeys)
            {
                if (singleActionControlMappings.ContainsKey(key) && !previouslyPressedKeys.Contains(key))
                {
                    singleActionControlMappings[key].Execute();
                }
            }
            this.previouslyPressedKeys = pressedKeys;
        }
    }
}
