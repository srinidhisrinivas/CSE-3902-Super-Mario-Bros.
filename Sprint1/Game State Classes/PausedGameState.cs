using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class PausedGameState : IGameState
    {
        private IHUDElement pauseText;
        private Game1 game;
        public PausedGameState(Game1 game)
        {
            this.game = game;
            game.KeyboardController = new PausedKeyboardController(game);
            this.pauseText = new ScreenText(new StringDisplay(() => { return ScoreUtility.pauseText; }), new Vector2(game.ScreenDimensions.X / ScoreUtility.half - ScoreUtility.smallMargin, game.ScreenDimensions.Y / ScoreUtility.half));
            SoundManager.PlaySoundEffect(SoundUtility.pauseSoundEffect);
            SoundManager.PauseSong();

        }
        public void Update(GameTime gameTime)
        {
            pauseText.Update(gameTime);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            game.Level.Draw(spriteBatch,game.GraphicsDevice,Color.White, Color.White, Color.White, Color.White);
            spriteBatch.Begin();
            pauseText.Draw(spriteBatch);
            spriteBatch.End();
            
        }
    }
}
