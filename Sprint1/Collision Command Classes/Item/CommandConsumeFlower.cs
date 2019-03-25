using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandConsumeFlower : ItemCollisionCommand
    {
        
        public CommandConsumeFlower(IMario mario, IItem flower) : base(mario, flower)
        {
            
        }
        public override void Execute()
        {
            SoundManager.PlaySoundEffect(SoundUtility.powerSoundEffect);
            mario.BecomeFire();
            ScoreManager.Instance.HandleItemScore(mario.Scoreboard, item.GetType(), item.Location);
            LevelEditFactory.RemoveItem(item);
        }
    }
}