using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandConsumeStar : ItemCollisionCommand
    {
        
        public CommandConsumeStar(IMario mario, IItem star) : base(mario, star)
        {
            
        }
        public override void Execute()
        {

            SoundManager.PlaySoundEffect(SoundUtility.powerSoundEffect);
            if (!(Game1.Instance.Mario is MagicMario))
            {
                Game1.Instance.Mario = new StarMario(mario);

                Game1.Instance.Level.LevelSong = new StarSong(Game1.Instance.Level.LevelSong);
                Game1.Instance.Level.LevelSong.Refresh();
            }

            ScoreManager.Instance.HandleItemScore(mario.Scoreboard, item.GetType(), item.Location);
            LevelEditFactory.RemoveItem(item);
        }
    }
}