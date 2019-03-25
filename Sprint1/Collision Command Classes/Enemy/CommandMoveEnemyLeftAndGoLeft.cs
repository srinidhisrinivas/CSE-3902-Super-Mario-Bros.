using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandMoveEnemyLeftAndGoLeft : EnemyCollisionCommand
    {
        
        public CommandMoveEnemyLeftAndGoLeft(IEnemy enemy, ICollision side) : base(enemy, side)
        {
            
        }
        public override void Execute()
        {
            new CommandMoveEntityLeft(enemy, side);
            if (!(enemy.State is StompedKoopaState))
            {
                enemy.GoLeft();
            }
        }
    }
}