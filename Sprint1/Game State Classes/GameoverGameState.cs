using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class GameoverGameState : IntermediateGameState
    {
       
        public GameoverGameState(Game1 game) : base(game)
        {
            this.textContentList.Add(new ScreenText(new StringDisplay(() => { return ScoreUtility.gameoverText; }), new Vector2(game.ScreenDimensions.X / ScoreUtility.half - ScoreUtility.smallMargin, game.ScreenDimensions.Y / ScoreUtility.half)));
            SoundManager.PlaySoundEffect(SoundUtility.gameoverSoundEffect);
            SoundManager.StopSong();
        }
        
    }
}
