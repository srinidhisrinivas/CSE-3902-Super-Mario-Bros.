﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public class CastleSong : ISong
    {
        public ISongState SongState { get; set; }
        public CastleSong()
        {
            this.SongState = new NormalCastleSong(this);
        }

        public void Play()
        {
            SongState.Play();
        }

        
        public void SpeedUp()
        {
            SongState.SpeedUp();
        }

        public void SlowDown()
        {
            SongState.SlowDown();
        }

        public void ChangeToOverworld()
        {
            SongState.ChangeToOverworld();
        }

        public void ChangeToUnderworld()
        {
            SongState.ChangeToUnderworld();
        }
        public void Refresh()
        {
            SoundManager.StopSong();
            SongState.Play();
        }
        public void Unwrap()
        {

        }
    }
}