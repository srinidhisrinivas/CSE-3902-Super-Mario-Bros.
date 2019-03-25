using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class CommandMarioKillEnemy : EnemyCollisionCommand
    {
        
        public CommandMarioKillEnemy(IMario mario, IEnemy enemy) : base(mario, enemy)
        {
           
        }
        public override void Execute()
        {

            enemy.Die(new OnDeathActions(() => {
                SoundManager.PlaySoundEffect(SoundUtility.stompSoundEffect);
            ScoreManager.Instance.HandleEnemyKillScore(mario.Scoreboard, enemy.GetType(), enemy.Location); }
            ));
        }
    }
}
