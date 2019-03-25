using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    
    abstract class KoopaShellState : KoopaState
    {
        protected KoopaShellState(IEnemy koopaShell) : base(koopaShell)
        {
            this.EnemySprite = EnemySpriteFactory.Instance.CreateStompedKoopaSprite();
        }
        public override void GoLeft()
        {
            this.Enemy.State = new LeftMovingShellState(this.Enemy);
        }

        public override void GoRight()
        {
            this.Enemy.State = new RightMovingShellState(this.Enemy);
        }
        public override void GetStomped()
        {
            
        }
    }

    
}
