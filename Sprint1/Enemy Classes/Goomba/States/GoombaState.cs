using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class GoombaState : EnemyState
    {
        protected GoombaState(IEnemy goomba) : base(goomba)
        {
            this.EnemySprite = EnemySpriteFactory.Instance.CreateGoombaSprite();
        }
        public override void GetStomped()
        {
            this.Enemy.State = new StompedGoombaState(Enemy);
        }
        public override void Die()
        {
            this.Enemy.State = new DeadGoombaState(Enemy);
        }
        public override void GoLeft()
        {
            this.Enemy.State = new LeftMovingGoombaState(Enemy);
        }
        public override void GoRight()
        {
            this.Enemy.State = new RightMovingGoombaState(Enemy);
        }
    }
}