using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandConsumeRedMushroom : ItemCollisionCommand
    {
       
        public CommandConsumeRedMushroom(IMario mario, IItem mushroom) : base(mario, mushroom)
        {
            
        }
        public override void Execute()
        {
            SoundManager.PlaySoundEffect(SoundUtility.powerSoundEffect);
            mario.BecomeBig();
            ScoreManager.Instance.HandleItemScore(mario.Scoreboard, item.GetType(), item.Location);
            LevelEditFactory.RemoveItem(item);
        }
    }
}