using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
   
    class CommandConsumeCoin : ItemCollisionCommand
    {
       
        public CommandConsumeCoin(IMario mario, IItem coin) : base(mario, coin)
        {
            
        }
        public override void Execute()
        {
            SoundManager.PlaySoundEffect(SoundUtility.coinSoundEffect);
            ScoreManager.Instance.HandleCoinCollection(mario.Scoreboard, item.GetType(), item.Location);
            LevelEditFactory.RemoveItem(item);
        }
    }
}