using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandConsumeMagicMushroom : ItemCollisionCommand
    {

        public CommandConsumeMagicMushroom(IMario mario, IItem star) : base(mario, star)
        {

        }
        public override void Execute()
        {

            SoundManager.PlaySoundEffect(SoundUtility.powerSoundEffect);
            if (!(Game1.Instance.Mario is StarMario))
            {
                Game1.Instance.Mario = new MagicMario(mario);
                Game1.Instance.Level.LevelSong = new DistortedSong(Game1.Instance.Level.LevelSong);
                Game1.Instance.Level.LevelSong.Refresh();
                Game1.Instance.ChangeGameState(Game1.GameStates.Magic);
            }

            ScoreManager.Instance.HandleItemScore(mario.Scoreboard, item.GetType(), item.Location);
            LevelEditFactory.RemoveItem(item);
        }
    }
}