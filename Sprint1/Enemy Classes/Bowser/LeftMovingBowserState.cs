using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CSE3902
{
    class LeftMovingBowserState : EnemyState, IBowserState
    {
        public LeftMovingBowserState(IEnemy enemy) : base(enemy)
        {
            this.EnemySprite = EnemySpriteFactory.Instance.CreateLeftBowserSprite();
            this.Enemy.xVelocity = BlockUtility.leftMovingBowserXVelocity;

        }

        public override void GoLeft()
        {

        }
        public override void GoRight()
        {
            this.Enemy.State = new RightMovingBowserState(this.Enemy);
        }
        public override void Die()
        {
            this.Enemy.State = new DeadBowserState(this.Enemy);
        }
        public void Jump()
        {
            this.Enemy.yVelocity = BlockUtility.leftMovingBowserYVelocity;
        }
        public void ShootFireball()
        {
            LevelEditFactory.AddProjectile(new BowserFireball(this.Enemy.Location, this.Enemy.HitBox));
            SoundManager.PlaySoundEffect(BlockUtility.BowserFire);
        }
        public void Idle()
        {
            this.Enemy.State = new StationaryLeftFacingBowserState(this.Enemy);
        }

    }
}
