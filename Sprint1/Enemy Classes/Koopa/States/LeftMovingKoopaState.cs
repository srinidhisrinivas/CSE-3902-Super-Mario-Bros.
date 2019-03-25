using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CSE3902
{
    class LeftMovingKoopaState : KoopaState
    {
        public LeftMovingKoopaState(IEnemy enemy) : base(enemy)
        {
            Enemy.xVelocity = EnemyStateUtility.leftMovingKoopaXVelocity;
            this.EnemySprite = EnemySpriteFactory.Instance.CreateLeftKoopaSprite();
        }
        
       
        public override void GoLeft()
        {

        }

       
    }
}
