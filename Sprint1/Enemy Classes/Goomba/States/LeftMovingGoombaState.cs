using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CSE3902
{
    class LeftMovingGoombaState: GoombaState
    {
        public LeftMovingGoombaState(IEnemy enemy) : base(enemy)
        {
            Enemy.xVelocity = EnemyStateUtility.leftMovingGoombaXVelocity;
        }
        
        public override void GoLeft()
        {

        }
    }
}
