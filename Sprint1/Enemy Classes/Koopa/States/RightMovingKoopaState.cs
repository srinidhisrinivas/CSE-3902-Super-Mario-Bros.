using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CSE3902
{
    class RightMovingKoopaState: KoopaState
    {
        public RightMovingKoopaState(IEnemy enemy) : base(enemy)
        {
            Enemy.xVelocity = EnemyStateUtility.rightMovingKoopaXVelocity;
            this.EnemySprite = EnemySpriteFactory.Instance.CreateRightKoopaSprite();
        }
        
        

        public override void GoRight()
        {

        }
       
    }
}
