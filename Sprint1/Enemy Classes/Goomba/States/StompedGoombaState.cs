using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CSE3902
{
    class StompedGoombaState: GoombaState
    {
        private int squashTimer;
        public StompedGoombaState(IEnemy enemy) : base(enemy)
        {
            this.EnemySprite = EnemySpriteFactory.Instance.CreateStompedGoombaSprite();
            Enemy.StopMotionX();
            squashTimer = EnemyStateUtility.stompedGoombaSquashTimer;
        }
        public override void GetStomped()
        {
           
        }

        public override void Die()
        {

        }

        public override void GoLeft()
        {

        }

        public override void GoRight()
        {

        }
        public override void Update(GameTime gameTime)
        {
            squashTimer--;
            if(squashTimer == EnemyStateUtility.stompedGoombaSquashTimerZero)
            {
                LevelEditFactory.RemoveEnemy(Enemy);
            }
            base.Update(gameTime);
        }
    }
}
