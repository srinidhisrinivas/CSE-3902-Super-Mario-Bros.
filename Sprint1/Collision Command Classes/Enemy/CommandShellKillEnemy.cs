using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandShellKillEnemy : EnemyCollisionCommand
    {
        private Koopa koopa;
        public CommandShellKillEnemy(IMario mario, Koopa koopa, IEnemy enemy, ICollision side) : base(mario, enemy, side)
        {
            this.koopa = koopa;
        }
        public override void Execute()
        {
            if (!(enemy.State is StompedGoombaState))
            {
                
                enemy.Die(new OnDeathActions(() =>
                {
                    koopa.KillChain += CollisionUtility.stompAdd;
                    ScoreManager.Instance.HandleEnemyChainScore(mario.Scoreboard, enemy.Location, koopa.KillChain);
                    SoundManager.PlaySoundEffect(SoundUtility.stompSoundEffect);
                }));
                
            }
                
            
            
        }
    }
}