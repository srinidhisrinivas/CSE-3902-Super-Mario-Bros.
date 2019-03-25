using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class CommandDropFlag : ICommand
    {
        private IBlock block;
        private IMario mario;
        private ICollision collisionType;
        public CommandDropFlag(IMario mario, IBlock block, ICollision collisionType)
        {
            this.block = block;
            this.mario = mario;
            this.collisionType = collisionType;
        }
        public void Execute()
        {
            SoundManager.PlaySoundEffect(SoundUtility.flagpoleSoundEffect);
            SoundManager.PlaySoundEffect(SoundUtility.stageClearSoundEffect);
            SoundManager.StopSong();
            Game1.Instance.Level.LevelTimer.TogglePause();
            block.PerformAction();
            new CommandMoveEntityLeft(mario, collisionType);
            ScoreManager.Instance.HandleFlagScore(mario.Scoreboard,  mario.Location);
            mario.DescendFlagpole();
        }
    }
}