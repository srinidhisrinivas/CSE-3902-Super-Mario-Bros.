using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;

namespace CSE3902
{
    public class FastOverworldSong : SongState
    {
       
        public FastOverworldSong(ISong song) : base(song)
        {
            this.CurrentSong = SoundManager.StageSongMap["FastOverworld"];
        }
       
        public override void SlowDown()
        {
            Song.SongState = new NormalOverworldSong(Song);
        }
        
        public override void ChangeToUnderworld()
        {
            Song.SongState = new FastUnderworldSong(Song);
        }
       
    }
}
