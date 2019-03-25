using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CSE3902
{
    class StompedKoopaState: KoopaShellState
    {
        private int hideTimer;
        private IEnemyState stompedKoopaState;
        public StompedKoopaState(IEnemy enemy) : base(enemy)
        {
            this.stompedKoopaState = enemy.State;
            Enemy.StopMotionX();
            this.EnemySprite = EnemySpriteFactory.Instance.CreateStompedKoopaSprite();
            hideTimer = EnemyStateUtility.stompedKoopaHideTimer;
        }
      
        public override void Update(GameTime gameTime)
        {
            hideTimer--;
            if(hideTimer == EnemyStateUtility.stompedKoopaHideTimerZero)
            {
                this.Enemy.State = (IEnemyState)Activator.CreateInstance(stompedKoopaState.GetType(), Enemy);
            }
            base.Update(gameTime);
        }
        public override void GetStomped()
        {
            
        }
    }
}
