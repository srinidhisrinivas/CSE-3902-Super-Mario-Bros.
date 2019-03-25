using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;

namespace CSE3902
{
    public class NormalOverworldSong : SongState
    {
       
        public NormalOverworldSong(ISong song) : base(song)
        {
            this.CurrentSong = SoundManager.StageSongMap["NormalOverworld"];
        }
       
        public override void SpeedUp()
        {
            Song.SongState = new FastOverworldSong(Song);
        }
        
        public override void ChangeToUnderworld()
        {
            Song.SongState = new NormalUnderworldSong(Song);
        }
       
    }
}
