using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class CommandPushEnemyLeftAndKill : ICommand
    {
        private IEnemy enemy;
        public CommandPushEnemyLeftAndKill(IEnemy enemy)
        {
            this.enemy = enemy;
        }
        public void Execute()
        {
            enemy.xVelocity = -2f;
            enemy.Die();
        }
    }
}
