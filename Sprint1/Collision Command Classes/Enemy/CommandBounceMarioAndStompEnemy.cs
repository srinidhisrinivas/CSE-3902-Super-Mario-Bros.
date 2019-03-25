using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandBounceMarioAndStompEnemy : EnemyCollisionCommand
    {
        
        public CommandBounceMarioAndStompEnemy(IMario mario, IEnemy enemy, ICollision side) : base(mario, enemy, side)
        {
           
        }
        public override void Execute()
        {
            if(mario.VerticalMotionState is FallingState)
            {
                SoundManager.PlaySoundEffect(SoundUtility.stompSoundEffect);
                mario.Bounce();
                enemy.GetStomped();
                mario.StompChain = mario.StompChain + CollisionUtility.stompAdd;
                ScoreManager.Instance.HandleEnemyChainScore(mario.Scoreboard, enemy.Location, mario.StompChain);
                new CommandMoveEntityUp(mario, side);
            }
            
        }
    }
}