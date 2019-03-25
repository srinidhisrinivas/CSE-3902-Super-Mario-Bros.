using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;


namespace CSE3902
{
    public class GamepadController : IController
    {
        private Game1 game;
        private GamePadState previousState;
        
        public GamepadController(Game1 game)
        {
            this.game = game;
            this.previousState = GamePad.GetState(PlayerIndex.One);

        }
        public void Update(GameTime gameTime)
        {
            GamePadState currentState = GamePad.GetState(PlayerIndex.One);
            Vector2 thumbStickPos = currentState.ThumbSticks.Left;
            Vector2 previousThumbStickPos = previousState.ThumbSticks.Left;
            if(thumbStickPos.X < -0.5f)
            {
                new CommandLeft(game).Execute();
            }
            if (thumbStickPos.X > 0.5f)
            {
                new CommandRight(game).Execute();
            }
            if (thumbStickPos.Y < -0.5f)
            {
                new CommandDown(game).Execute();
            }
          
            if (thumbStickPos.X > -0.5f && previousThumbStickPos.X < -0.5)
            {
                new CommandRight(game).Execute();
            }
            if (thumbStickPos.X < 0.5f && previousThumbStickPos.X > 0.5f)
            {
                new CommandLeft(game).Execute();
            }
            
            if (thumbStickPos.Y < 0.5f && previousThumbStickPos.Y > 0.5f)
            {
                new CommandDown(game).Execute();
            }
            previousState = currentState;
        }
    }
}
