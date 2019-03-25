using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandConsumeGreenMushroom : ItemCollisionCommand
    {
        
        public CommandConsumeGreenMushroom(IMario mario, IItem mushroom) : base(mario, mushroom)
        {
           
        }
        public override void Execute()
        {
            SoundManager.PlaySoundEffect(SoundUtility.oneUpSoundEffect);
            ScoreManager.Instance.HandleGreenMushroomCollection(mario.Scoreboard, item.GetType(), item.Location);
            LevelEditFactory.RemoveItem(item);
        }
    }
}