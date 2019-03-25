using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class FireToBigMarioLeft : DamageTransitionState
    {
        public FireToBigMarioLeft(IMario mario) : base(mario)
        {
            mario.PowerType = new BigMarioType();
            CurrentSpriteMap.Add(true, MarioSpriteFactory.Instance.CreateBigMarioLeftIdleSprite());
            CurrentSpriteMap.Add(false, MarioSpriteFactory.Instance.CreateFireMarioLeftIdleSprite());
            MarioSprite = CurrentSpriteMap[false];
            FinalState = new BigMarioLeftIdle(mario);
        }
    }
}