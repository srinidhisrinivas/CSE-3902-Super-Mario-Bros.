using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandExplodeFireballAndKillEnemy : ICommand
    {
        private IProjectile projectile;
        private IEnemy enemy;
        public CommandExplodeFireballAndKillEnemy(IProjectile projectile,IEnemy enemy)
        {
            this.projectile = projectile;
            this.enemy = enemy;
        }
        public void Execute()
        {

            
            enemy.TakeDamage(new OnDeathActions(() =>
            {
                SoundManager.PlaySoundEffect(SoundUtility.stompSoundEffect);
                ScoreManager.Instance.HandleEnemyKillScore(projectile.ProjectileSource.Scoreboard, enemy.GetType(), enemy.Location);
            }));
            projectile.Destroy();
        }
    }
}