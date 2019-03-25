using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class LevelResetGameState : IntermediateGameState
    {
        private int timer = GameUtility.levelResetTimer;

        public LevelResetGameState(Game1 game) : base(game)
        {
            this.textContentList.Add(new ScreenText(new StringDisplay(() => { return ScoreUtility.livesText; }), new Vector2(game.ScreenDimensions.X / ScoreUtility.half - ScoreUtility.largeMargin, game.ScreenDimensions.Y / ScoreUtility.half)));
            this.textContentList.Add(new ScreenText(new NumericDisplay(() => game.Mario.Scoreboard.LifeCount), new Vector2(ScoreUtility.lifeXLoc, game.ScreenDimensions.Y / ScoreUtility.half)));
            SoundManager.StopSong();

        }
        public override void Update(GameTime gameTime)
        {

            timer--;
            base.Update(gameTime);
            if (timer <= ScoreUtility.timerScoreInit)
            {
                game.ReloadLevel();
            }
        }
        
    }
}
