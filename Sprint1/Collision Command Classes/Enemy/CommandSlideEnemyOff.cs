using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandSlideEnemyOff : EnemyCollisionCommand
    {
       
        public CommandSlideEnemyOff(IEnemy enemy, ICollision side) : base(enemy, side)
        {
            
        }
        public override void Execute()
        {
            enemy.xVelocity += PhysicsUtility.enemySlideVelocity;
            new CommandMoveEntityLeft(enemy, side);
            enemy.GoLeft();
        }
    }
}