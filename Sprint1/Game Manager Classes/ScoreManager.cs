using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;

namespace CSE3902
{
    public class ScoreManager
    {
        public static ScoreManager Instance { get; } = new ScoreManager();
        private Dictionary<Type, int> itemScoreValues;
        private Dictionary<Type, int> enemyKillScoreValues;
        private Dictionary<int, int> enemyChainScoreValues;

        private int timerPointScore;
        private int brickBreakScore;
        private ScoreManager()
        {
            itemScoreValues = new Dictionary<Type, int>();
            enemyKillScoreValues = new Dictionary<Type, int>();
            enemyChainScoreValues = new Dictionary<int, int>();
           

            itemScoreValues.Add(typeof(RedMushroom), ScoreUtility.redMushroomScore);
            itemScoreValues.Add(typeof(MagicMushroom), ScoreUtility.magicMushroomScore);
            itemScoreValues.Add(typeof(GreenMushroom), ScoreUtility.greenMushroomScore);
            itemScoreValues.Add(typeof(Flower), ScoreUtility.flowerScore);
            itemScoreValues.Add(typeof(Star), ScoreUtility.starScore);
            itemScoreValues.Add(typeof(Coin), ScoreUtility.coinScore);
            itemScoreValues.Add(typeof(StationaryCoin), ScoreUtility.stationCoinScore);

            enemyChainScoreValues.Add(ScoreUtility.chainLengthZero, ScoreUtility.chainLengthZeroScore);
            enemyChainScoreValues.Add(ScoreUtility.chainLengthOne, ScoreUtility.chainLengthOneScore);
            enemyChainScoreValues.Add(ScoreUtility.chainLengthTwo, ScoreUtility.chainLengthTwoScore);
            enemyChainScoreValues.Add(ScoreUtility.chainLengthThree, ScoreUtility.chainLengthThreeScore);
            enemyChainScoreValues.Add(ScoreUtility.chainLengthFour, ScoreUtility.chainLengthFourScore);
            enemyChainScoreValues.Add(ScoreUtility.chainLengthFive, ScoreUtility.chainLengthFiveScore);
            enemyChainScoreValues.Add(ScoreUtility.chainLengthSix, ScoreUtility.chainLengthSixScore);
            enemyChainScoreValues.Add(ScoreUtility.chainLengthSeven, ScoreUtility.chainLengthSevenScore);
            enemyChainScoreValues.Add(ScoreUtility.chainLengthEight, ScoreUtility.chainLengthEightScore);
            enemyChainScoreValues.Add(ScoreUtility.chainLengthNine, ScoreUtility.chainLengthNineScore);
            enemyChainScoreValues.Add(ScoreUtility.chainLengthTen, ScoreUtility.chainLengthTenScore);

            enemyKillScoreValues.Add(typeof(Goomba), ScoreUtility.goombaScore);
            enemyKillScoreValues.Add(typeof(Koopa), ScoreUtility.koopaScore);
            enemyKillScoreValues.Add(typeof(Bowser), 5000);


            this.timerPointScore = ScoreUtility.timerScoreInit;

            this.brickBreakScore = ScoreUtility.brickBreakScoreInit;
        }
        public void HandleEnemyKillScore(Scoreboard scoreboard, Type enemyType, Vector2 enemyLocation)
        {
            int addScore = enemyKillScoreValues[enemyType];
            scoreboard.AddPoints(addScore);
            LevelEditFactory.AddHUDElement(new DisappearingFloatingText(new StringDisplay(() => { return addScore.ToString(); }), enemyLocation));
        }
        public void HandleEnemyChainScore(Scoreboard scoreboard, Vector2 enemyLocation, int chainLength)
        {
            string reward;
            if (enemyChainScoreValues.ContainsKey(chainLength))
            {
                int addScore = enemyChainScoreValues[chainLength];
                scoreboard.AddPoints(addScore);
                reward = addScore.ToString();
            } else
            {
                scoreboard.AddLives(ScoreUtility.addOne);
                reward = ScoreUtility.oneUp;
            }
            LevelEditFactory.AddHUDElement(new DisappearingFloatingText(new StringDisplay(() => { return reward; }), enemyLocation));
            
        }
        public void HandleItemScore(Scoreboard scoreboard, Type itemType, Vector2 itemLocation)
        {
            int addScore = this.itemScoreValues[itemType];
            scoreboard.AddPoints(addScore);
            LevelEditFactory.AddHUDElement(new DisappearingFloatingText(new StringDisplay(() => { return addScore.ToString(); }), itemLocation));
        }
        public void HandleCoinCollection(Scoreboard scoreboard, Type coinType, Vector2 coinLocation)
        {
            int addScore = this.itemScoreValues[coinType];
            scoreboard.AddCoins(ScoreUtility.addOne);
            scoreboard.AddPoints(addScore);
            LevelEditFactory.AddHUDElement(new DisappearingFloatingText(new StringDisplay(() => { return addScore.ToString(); }), coinLocation));
        }
        public void HandleGreenMushroomCollection(Scoreboard scoreboard, Type mushroomType, Vector2 mushroomLocation)
        {
            int addScore = this.itemScoreValues[mushroomType];
            scoreboard.AddLives(ScoreUtility.addOne);
            scoreboard.AddPoints(addScore);
            LevelEditFactory.AddHUDElement(new DisappearingFloatingText(new StringDisplay(() => { return addScore.ToString(); }), mushroomLocation));
        }
        public void HandleFlagScore(Scoreboard scoreboard, Vector2 marioLocation)
        {
            int addScore = marioLocation.Y > ItemUtility.flagThresholdLocation ? ScoreUtility.segment1Score : ScoreUtility.segment2Score;
            scoreboard.AddPoints(addScore);
            LevelEditFactory.AddHUDElement(new DisappearingFloatingText(new StringDisplay(() => { return addScore.ToString(); }), marioLocation));
        }
        public void HandleTimerCoinAddition(Scoreboard scoreboard)
        {
            int addScore = this.timerPointScore;
            SoundManager.PlaySoundEffect("GetCoin");
            scoreboard.AddPoints(addScore);
        }

        public void HandleBrickBreakScore(Scoreboard scoreboard)
        {
            int addScore = this.brickBreakScore;
            scoreboard.AddPoints(addScore);
        }
    }

}