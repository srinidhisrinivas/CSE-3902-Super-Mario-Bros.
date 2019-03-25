using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class StarSong : ISong
    {
        private ISong decoratedSong;
        public ISongState SongState { get; set; }
        public StarSong(ISong decoratedSong)
        {
            this.decoratedSong = decoratedSong;
            this.SongState = decoratedSong.SongState.GetType().Name.StartsWith("Fast") ? (ISongState)new FastStarSong(this) : (ISongState)new NormalStarSong(this);
        }

        public void Play()
        {
            SongState.Play();
        }

        
        public void SpeedUp()
        {
            SongState.SpeedUp();
            decoratedSong.SpeedUp();
        }

        public void SlowDown()
        {
            SongState.SlowDown();
            decoratedSong.SlowDown();
        }

        public void ChangeToOverworld()
        {
            decoratedSong.ChangeToOverworld();
        }

        public void ChangeToUnderworld()
        {
            decoratedSong.ChangeToUnderworld();
        }
        public void Refresh()
        {
            SoundManager.StopSong();
            SongState.Play();
        }
        public void Unwrap()
        {
            Game1.Instance.Level.LevelSong = decoratedSong;
            decoratedSong.Refresh();
        }
    }
}
