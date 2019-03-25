using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CSE3902
{
    class RightMovingBowserState : EnemyState, IBowserState
    {
        public RightMovingBowserState(IEnemy enemy) : base(enemy)
        {
            this.EnemySprite = EnemySpriteFactory.Instance.CreateRightBowserSprite();
            this.Enemy.xVelocity = BlockUtility.rightMovingBowserXVelocity;
        }

        public override void GoLeft()
        {
            this.Enemy.State = new LeftMovingBowserState(this.Enemy);

        }
       
        public override void Die()
        {
            this.Enemy.State = new DeadBowserState(this.Enemy);
        }
        public void Jump()
        {

        }
        public void ShootFireball()
        {

        }
        public void Idle()
        {
            this.Enemy.State = new StationaryLeftFacingBowserState(this.Enemy);
        }
    }
}
