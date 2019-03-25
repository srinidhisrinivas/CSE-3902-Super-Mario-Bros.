﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;

namespace CSE3902
{
    public class FastDistortedOverworldSong : SongState
    {

        public FastDistortedOverworldSong(ISong song) : base(song)
        {
            this.CurrentSong = SoundManager.StageSongMap["DistortedOverworld"];
        }


    }
}
