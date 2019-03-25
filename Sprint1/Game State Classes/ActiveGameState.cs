using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class ActiveGameState : IGameState
    {
        private Game1 game;
        public ActiveGameState(Game1 game)
        {
            SoundManager.ResumeSong();
            this.game = game;
            game.Level.SetOverWorldConditions();
            game.KeyboardController = new ActiveKeyboardController(game);

        }
        public void Update(GameTime gameTime)
        {
            game.Level.Update(gameTime);
            foreach (IHUDElement element in game.gameHUDElements)
            {
                element.Update(gameTime);
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            game.Level.Draw(spriteBatch, game.GraphicsDevice,Color.White, Color.White, Color.White, Color.White);
           
        }
    }
}
