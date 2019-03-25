using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class Scoreboard
    {
        public int PointCount { get; private set; }
        public int CoinCount { get; private set; }
        public int LifeCount { get; private set; }
        public Scoreboard()
        {
            this.PointCount = ScoreUtility.pointCountInit;
            this.CoinCount = ScoreUtility.coinCountInit;
            this.LifeCount = ScoreUtility.lifeCountInit;
        }
        public void AddPoints(int pointCount)
        {
            this.PointCount += pointCount;
        }
        public void AddCoins(int coinCount)
        {
            this.CoinCount += coinCount;
            int extraLives =this.CoinCount / ScoreUtility.coinMod;
            if (extraLives > ScoreUtility.extraLifeLowerBound)
            {
                int surplusCoins = this.CoinCount % ScoreUtility.coinMod;
                this.CoinCount = surplusCoins;
                this.AddLives(extraLives);
            }
        }
        public void AddLives(int lifeCount)
        {
            this.LifeCount += lifeCount;
        }
        public void SubtractLives(int lifeCount)
        {
            this.LifeCount -= lifeCount; 
        }

    }
}
