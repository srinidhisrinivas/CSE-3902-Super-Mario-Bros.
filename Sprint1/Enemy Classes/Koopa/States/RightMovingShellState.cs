using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CSE3902
{
    class RightMovingShellState: KoopaShellState
    {
        public RightMovingShellState(IEnemy enemy) : base(enemy)
        {
            Enemy.xVelocity = EnemyStateUtility.rightMovingShellXVelocity;
            this.EnemySprite = EnemySpriteFactory.Instance.CreateStompedKoopaSprite();
        }
        public override void GoLeft()
        {
            this.Enemy.State = new LeftMovingShellState(Enemy);
        }

        public override void GoRight()
        {

        }

    }
}
