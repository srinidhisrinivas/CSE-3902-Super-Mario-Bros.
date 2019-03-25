using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CSE3902
{
    class DeadBowserState : EnemyState, IBowserState
    {
        public DeadBowserState(IEnemy enemy) : base(enemy)
        {
            this.EnemySprite = EnemySpriteFactory.Instance.CreateDeadGrayGoombaSprite();
            this.Enemy.StopMotionX();
        }
        public void Jump()
        {

        }
        public void ShootFireball()
        {

        }
        public void Idle()
        {

        }

    }
}
