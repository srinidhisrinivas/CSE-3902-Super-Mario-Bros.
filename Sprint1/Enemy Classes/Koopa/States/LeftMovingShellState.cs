using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CSE3902
{
    class LeftMovingShellState: KoopaShellState
    {
        public LeftMovingShellState(IEnemy enemy) : base(enemy)
        {
            Enemy.xVelocity = EnemyStateUtility.leftMovingShellXVelocity;
            this.EnemySprite = EnemySpriteFactory.Instance.CreateStompedKoopaSprite();
        }
      
        public override void GoLeft()
        {


        }
      
    }
}
