using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class EnemyCollisionCommand : CollisionCommand
    {
        protected IEnemy enemy { get; set; }
        protected EnemyCollisionCommand(IMario mario, IEnemy enemy, ICollision side) : base(mario, side)
        {
            this.enemy = enemy;
        }
        protected EnemyCollisionCommand(IEnemy enemy, ICollision side) : this(null, enemy, side)
        {
            
        }
        
        protected EnemyCollisionCommand(IMario mario, IEnemy enemy) : this(mario, enemy, null)
        {
            
        }
    }
}
