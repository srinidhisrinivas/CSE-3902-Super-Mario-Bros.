using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;


namespace CSE3902
{
    public class ActiveKeyboardController : KeyboardController
    {
        private Dictionary<Keys, ICommand> continuousActionControlMappings;

        private Dictionary<Keys, ICommand> keyLiftCommandMappings;

        public ActiveKeyboardController(Game1 game) : base(game)
        {
            continuousActionControlMappings = new Dictionary<Keys, ICommand>();
            keyLiftCommandMappings = new Dictionary<Keys, ICommand>();

            continuousActionControlMappings.Add(Keys.Down, new CommandDown(game));
            continuousActionControlMappings.Add(Keys.Left, new CommandLeft(game));
            continuousActionControlMappings.Add(Keys.Right, new CommandRight(game));
            continuousActionControlMappings.Add(Keys.A, new CommandLeft(game));
            continuousActionControlMappings.Add(Keys.S, new CommandDown(game));
            continuousActionControlMappings.Add(Keys.D, new CommandRight(game));
            continuousActionControlMappings.Add(Keys.X, new CommandRun(game));

            singleActionControlMappings.Add(Keys.U, new CommandBig(game));
            singleActionControlMappings.Add(Keys.I, new CommandFire(game));
            singleActionControlMappings.Add(Keys.O, new CommandDead(game));
            singleActionControlMappings.Add(Keys.Z, new CommandJump(game));
            singleActionControlMappings.Add(Keys.C, new CommandShoot(game));
            singleActionControlMappings.Add(Keys.H, new CommandProgressLevel(game));
            singleActionControlMappings.Add(Keys.K, new CommandPause(game));

            keyLiftCommandMappings.Add(Keys.Down, new CommandDisablePortalsAndIdle(game));
            keyLiftCommandMappings.Add(Keys.Left, new CommandIdle(game));
            keyLiftCommandMappings.Add(Keys.Right, new CommandIdle(game));
            keyLiftCommandMappings.Add(Keys.S, new CommandIdle(game));
            keyLiftCommandMappings.Add(Keys.A, new CommandIdle(game));
            keyLiftCommandMappings.Add(Keys.D, new CommandDisablePortalsAndIdle(game));
            keyLiftCommandMappings.Add(Keys.Z, new CommandCeaseJump(game));
            keyLiftCommandMappings.Add(Keys.X, new CommandCeaseRun(game));


        }
        public override void Update(GameTime gameTime)
        {
            Keys[] pressedKeys = Keyboard.GetState().GetPressedKeys();
            foreach (Keys key in pressedKeys)
            {
                if (continuousActionControlMappings.ContainsKey(key))
                {
                    continuousActionControlMappings[key].Execute();
                }
            }
            foreach (Keys key in this.previouslyPressedKeys)
            {
                if (!pressedKeys.Contains(key) && this.keyLiftCommandMappings.ContainsKey(key))
                {
                    keyLiftCommandMappings[key].Execute();
                }
            }
            base.Update(gameTime);
        }
    }
}
