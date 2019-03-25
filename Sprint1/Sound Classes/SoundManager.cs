using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    public static class SoundManager
    {
        private static Song overworldSong, starMarioSong, underworldSong, fastOverworldSong, fastUnderworldSong, fastStarMarioSong,
            distortedOverworldSong, castleSong, fastCastleSong;
        public static Dictionary<string, Song> StageSongMap { get; } = new Dictionary<string, Song>();
        private static SoundEffect getCoin, breakBlock, oneUp, bumpBlock, shootFireball, downFlagpole, gameover, kick, marioDie,
            pause, downPipe, powerUp, powerUpAppear, smallJump, stageClear, stomp, superJump, bowserFire, bowserFall;

        private static Dictionary<string, SoundEffect> soundEffectMap;
        public static void Initialize(ContentManager content)
        {
            soundEffectMap = new Dictionary<string, SoundEffect>();
            distortedOverworldSong = content.Load<Song>(SoundUtility.distortedOverwoldName);
            overworldSong = content.Load<Song>(SoundUtility.overwoldName);
            fastOverworldSong = content.Load<Song>(SoundUtility.fastOverwoldName);
            fastUnderworldSong = content.Load<Song>(SoundUtility.fastUndergroundName);
            fastStarMarioSong = content.Load<Song>(SoundUtility.fastStarName);
            underworldSong = content.Load<Song>(SoundUtility.undergroundName);
            starMarioSong = content.Load<Song>(SoundUtility.starName);
            castleSong = content.Load<Song>("04-castle");
            fastCastleSong = content.Load<Song>("16-hurry-castle-");

            getCoin = content.Load<SoundEffect>(SoundUtility.coinName);
            breakBlock = content.Load<SoundEffect>(SoundUtility.breakBlockName);
            oneUp = content.Load<SoundEffect>(SoundUtility.oneUpName);
            bumpBlock = content.Load<SoundEffect>(SoundUtility.bumpName);
            shootFireball = content.Load<SoundEffect>(SoundUtility.fireballName);
            downFlagpole = content.Load<SoundEffect>(SoundUtility.flagpoleName);
            gameover = content.Load<SoundEffect>(SoundUtility.gameoverName);
            kick = content.Load<SoundEffect>(SoundUtility.kickName);
            pause = content.Load<SoundEffect>(SoundUtility.pauseName);
            downPipe = content.Load<SoundEffect>(SoundUtility.pipeName);
            powerUp = content.Load<SoundEffect>(SoundUtility.powerName);
            powerUpAppear = content.Load<SoundEffect>(SoundUtility.powerAppearName);
            smallJump = content.Load<SoundEffect>(SoundUtility.smallJumpName);
            stageClear = content.Load<SoundEffect>(SoundUtility.stageClearName);
            stomp = content.Load<SoundEffect>(SoundUtility.stompName);
            superJump = content.Load<SoundEffect>(SoundUtility.superJumpName);
            marioDie = content.Load<SoundEffect>(SoundUtility.dieName);
            bowserFire = content.Load<SoundEffect>("smb_bowserfire");
            bowserFall = content.Load<SoundEffect>("smb_bowserfall");

            StageSongMap.Clear();
            StageSongMap.Add(SoundUtility.overworldSoundEffect, overworldSong);
            StageSongMap.Add(SoundUtility.distortedOverworldSoundEffect, distortedOverworldSong);
            StageSongMap.Add(SoundUtility.fastOverworldSoundEffect, fastOverworldSong);
            StageSongMap.Add(SoundUtility.underworldSoundEffect, underworldSong);
            StageSongMap.Add(SoundUtility.fastUnderworldSoundEffect, fastUnderworldSong);
            StageSongMap.Add(SoundUtility.starSoundEffect, starMarioSong);
            StageSongMap.Add(SoundUtility.fastStarSoundEffect, fastStarMarioSong);
            StageSongMap.Add("Castle", castleSong);
            StageSongMap.Add("FastCastle", fastCastleSong);



            soundEffectMap.Add(SoundUtility.coinSoundEffect, getCoin);
            soundEffectMap.Add(SoundUtility.breakBlockSoundEffect, breakBlock);
            soundEffectMap.Add(SoundUtility.oneUpSoundEffect, oneUp);
            soundEffectMap.Add(SoundUtility.bumpSoundEffect, bumpBlock);
            soundEffectMap.Add(SoundUtility.fireballSoundEffect, shootFireball);
            soundEffectMap.Add(SoundUtility.flagpoleSoundEffect, downFlagpole);
            soundEffectMap.Add(SoundUtility.kickSoundEffect, kick);
            soundEffectMap.Add(SoundUtility.gameoverSoundEffect, gameover);
            soundEffectMap.Add(SoundUtility.pauseSoundEffect, pause);
            soundEffectMap.Add(SoundUtility.pipeSoundEffect, downPipe);
            soundEffectMap.Add(SoundUtility.powerSoundEffect, powerUp);
            soundEffectMap.Add(SoundUtility.powerAppearSoundEffect, powerUpAppear);
            soundEffectMap.Add(SoundUtility.smallJumpSoundEffect, smallJump);
            soundEffectMap.Add(SoundUtility.superJumpSoundEffect, superJump);
            soundEffectMap.Add(SoundUtility.stageClearSoundEffect, stageClear);
            soundEffectMap.Add(SoundUtility.stompSoundEffect, stomp);
            soundEffectMap.Add(SoundUtility.dieSoundEffect, marioDie);
            soundEffectMap.Add("BowserFire", bowserFire);
            soundEffectMap.Add("BowserFall", bowserFall);




        }

        public static void PlaySoundEffect(String effectName)
        {
            SoundEffect soundEffect = soundEffectMap[effectName];
            soundEffect.Play();
        }
        
        public static void StopSong()
        {
            MediaPlayer.Stop();
        }
        public static void PauseSong()
        {
            MediaPlayer.Pause();
        }
        public static void ResumeSong()
        {
            MediaPlayer.Resume();
        }
    }
}
