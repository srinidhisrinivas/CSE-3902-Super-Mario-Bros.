using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{

    class CommandCollectAxe : ItemCollisionCommand
    {

        public CommandCollectAxe(IMario mario, IItem axe) : base(mario, axe)
        {

        }
        public override void Execute()
        {
            Game1.Instance.Level.FloorManager.RetractBridges();
            SoundManager.StopSong();
            SoundManager.PlaySoundEffect("StageClear");
            mario.RunRight(BlockUtility.marioRunRight);
            LevelEditFactory.RemoveItem(item);
        }
    }
}