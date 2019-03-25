using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;

namespace CSE3902
{
    public class NormalUnderworldSong : SongState
    {
       
        public NormalUnderworldSong(ISong song) : base(song)
        {
            this.CurrentSong = SoundManager.StageSongMap["NormalUnderworld"];
        }
       
        public override void SpeedUp()
        {
            Song.SongState = new FastUnderworldSong(Song);
        }
        
        public override void ChangeToOverworld()
        {
            Song.SongState = new NormalOverworldSong(Song);
        }
       
    }
}
