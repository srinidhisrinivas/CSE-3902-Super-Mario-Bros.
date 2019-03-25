using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public abstract class SongState : ISongState
    {
        protected ISong Song { get; set; }
        protected Song CurrentSong { get; set; }
        protected SongState(ISong song)
        {
            this.Song = song;
        }
        public virtual void Play()
        {
            MediaPlayer.Play(CurrentSong);
            MediaPlayer.IsRepeating = true;
        }
        
        public virtual void SlowDown()
        {

        }
        public virtual void SpeedUp()
        {

        }
        public virtual void ChangeToOverworld()
        {

        }
        public virtual void ChangeToUnderworld()
        {

        }
        public virtual void ChangeToStar()
        {

        }
        public virtual void RemoveStar()
        {

        }
    }
}
