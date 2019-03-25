using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CSE3902
{
    class RightMovingGoombaState: GoombaState
    {
        public RightMovingGoombaState(IEnemy enemy) : base(enemy)
        {
            Enemy.xVelocity = EnemyStateUtility.rightMovingGoombaXVelocity;
        }
        
       
        public override void GoRight()
        {

        }
       
    }
}
