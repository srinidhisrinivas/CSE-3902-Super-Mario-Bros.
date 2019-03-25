using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandStompShell : EnemyCollisionCommand
    {
        
        public CommandStompShell(IMario mario, IEnemy enemy, ICollision side) : base(mario, enemy, side)
        {
            
        }
        public override void Execute()
        {
            SoundManager.PlaySoundEffect(SoundUtility.stompSoundEffect);
            if ((side.IntersectingRectangle.X + mario.HitBox.Width) - (enemy.HitBox.X + enemy.HitBox.Width)/CollisionUtility.shellPushThreshold > 0)
            {
                enemy.GoLeft();
            } 
            else 
            {
                enemy.GoRight();
            }
            new CommandMoveEntityUp(mario, side).Execute();
            enemy.GetStomped();
        }
    }
}