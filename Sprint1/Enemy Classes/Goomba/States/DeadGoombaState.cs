using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CSE3902
{
    class DeadGoombaState: EnemyState
    {
        public DeadGoombaState(IEnemy enemy) : base(enemy)
        {
            this.EnemySprite = EnemySpriteFactory.Instance.CreateDeadGoombaSprite();
            Enemy.yVelocity = EnemyStateUtility.deadGoombaYVelocity;
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
            if(Enemy.Location.Y > EnemyStateUtility.deadGoombaYLocation)
            {
                LevelEditFactory.RemoveEnemy(Enemy);
            }
            base.Update(gameTime);
        }
    }
}
