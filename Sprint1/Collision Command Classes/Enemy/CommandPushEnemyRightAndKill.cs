using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class CommandPushEnemyRightAndKill : ICommand
    {
        private IEnemy enemy;
        public CommandPushEnemyRightAndKill(IEnemy enemy)
        {
            this.enemy = enemy;
        }
        public void Execute()
        {
            enemy.xVelocity = 2f;
            enemy.Die();
        }
    }
}
