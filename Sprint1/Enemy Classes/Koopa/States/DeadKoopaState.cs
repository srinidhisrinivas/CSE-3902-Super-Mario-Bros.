using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CSE3902
{
    class DeadKoopaState: EnemyState
    {
        public DeadKoopaState(IEnemy enemy) : base(enemy)
        {
            this.EnemySprite = EnemySpriteFactory.Instance.CreateDeadKoopaSprite();
            Enemy.yVelocity = EnemyStateUtility.deadKoopaYVelocity;

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

            if(Enemy.Location.Y > EnemyStateUtility.deadKoopaYLocation)
            {
                LevelEditFactory.RemoveEnemy(Enemy);
            }
            base.Update(gameTime);
        }
    }
}
