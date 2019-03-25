using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CSE3902
{
    class StationaryLeftFacingBowserState : EnemyState, IBowserState
    {
        public StationaryLeftFacingBowserState(IEnemy enemy) : base(enemy)
        {
            this.EnemySprite = EnemySpriteFactory.Instance.CreateLeftBowserSprite();
            this.Enemy.StopMotionX();
        }

        public override void GoLeft()
        {
            this.Enemy.State = new LeftMovingBowserState(this.Enemy);

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
            this.Enemy.yVelocity = BlockUtility.StationaryLeftFacingBowserYVelocity;
        }
        public void ShootFireball()
        {
            LevelEditFactory.AddProjectile(new BowserFireball(this.Enemy.Location, this.Enemy.HitBox));
            SoundManager.PlaySoundEffect(BlockUtility.BowserFire);

        }
        public void Idle()
        {

        }

    }
}
