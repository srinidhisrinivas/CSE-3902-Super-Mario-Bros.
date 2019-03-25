using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandPushShellRight : EnemyCollisionCommand
    {
       
        public CommandPushShellRight(IMario mario,IEnemy enemy, ICollision side) : base(mario, enemy, side)
        {
           
        }
        public override void Execute()
        {
            SoundManager.PlaySoundEffect(SoundUtility.kickSoundEffect);
            enemy.GoRight();
            mario.Location -= new Vector2(CollisionUtility.intersectBuffer, SpriteUtility.yOrigin);
            new CommandMoveEntityLeft(mario, side).Execute(); 
        }
    }
}