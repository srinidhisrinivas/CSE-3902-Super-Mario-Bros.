using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class CommandKillEnemy : ICommand
    {
        private IEnemy enemy;
        public CommandKillEnemy(IEnemy enemy)
        {
            this.enemy = enemy;
        }
        public void Execute()
        {
            enemy.Die();
        }
    }
}
