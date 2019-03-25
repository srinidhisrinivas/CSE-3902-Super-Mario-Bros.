using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;


namespace CSE3902
{
    public class InvertedKeyboardController : KeyboardController
    {
        private Dictionary<Keys, ICommand> continuousActionControlMappings;

        private Dictionary<Keys, ICommand> keyLiftCommandMappings;

        public InvertedKeyboardController(Game1 game) : base(game)
        {
            continuousActionControlMappings = new Dictionary<Keys, ICommand>();
            keyLiftCommandMappings = new Dictionary<Keys, ICommand>();

            continuousActionControlMappings.Add(Keys.Down, new CommandJump(game));
            continuousActionControlMappings.Add(Keys.Left, new CommandRight(game));
            continuousActionControlMappings.Add(Keys.Right, new CommandLeft(game));
            continuousActionControlMappings.Add(Keys.A, new CommandRight(game));
            continuousActionControlMappings.Add(Keys.S, new CommandJump(game));
            continuousActionControlMappings.Add(Keys.D, new CommandLeft(game));
            continuousActionControlMappings.Add(Keys.X, new CommandRun(game));

            singleActionControlMappings.Add(Keys.U, new CommandBig(game));
            singleActionControlMappings.Add(Keys.I, new CommandFire(game));
            singleActionControlMappings.Add(Keys.O, new CommandDead(game));
            singleActionControlMappings.Add(Keys.Z, new CommandDown(game));
            singleActionControlMappings.Add(Keys.C, new CommandShoot(game));
            singleActionControlMappings.Add(Keys.K, new CommandPause(game));

            keyLiftCommandMappings.Add(Keys.Down, new CommandCeaseJump(game));
            keyLiftCommandMappings.Add(Keys.Left, new CommandIdle(game));
            keyLiftCommandMappings.Add(Keys.Right, new CommandIdle(game));
            keyLiftCommandMappings.Add(Keys.S, new CommandIdle(game));
            keyLiftCommandMappings.Add(Keys.A, new CommandIdle(game));
            keyLiftCommandMappings.Add(Keys.D, new CommandDisablePortalsAndIdle(game));
            keyLiftCommandMappings.Add(Keys.Z,new CommandDisablePortalsAndIdle(game));
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
