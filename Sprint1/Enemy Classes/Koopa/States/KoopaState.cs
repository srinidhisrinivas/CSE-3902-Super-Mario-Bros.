using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class KoopaState : EnemyState
    {
        protected KoopaState(IEnemy goomba) : base(goomba)
        {

        }
        public override void GetStomped()
        {
            this.Enemy.State = new StompedKoopaState(Enemy);
        }
        public override void Die()
        {
            this.Enemy.State = new DeadKoopaState(Enemy);
        }
        public override void GoRight()
        {
            this.Enemy.State = new RightMovingKoopaState(Enemy);
        }
        public override void GoLeft()
        {
            this.Enemy.State = new LeftMovingKoopaState(Enemy);
        }
    }
}