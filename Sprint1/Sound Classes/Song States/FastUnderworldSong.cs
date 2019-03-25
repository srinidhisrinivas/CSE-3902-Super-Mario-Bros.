using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;

namespace CSE3902
{
    public class FastUnderworldSong : SongState
    {
       
        public FastUnderworldSong(ISong song) : base(song)
        {
            this.CurrentSong = SoundManager.StageSongMap["FastUnderworld"];
        }
       
        public override void SlowDown()
        {
            Song.SongState = new NormalUnderworldSong(Song);
        }
        
        public override void ChangeToOverworld()
        {
            Song.SongState = new FastOverworldSong(Song);
        }
       
    }
}
