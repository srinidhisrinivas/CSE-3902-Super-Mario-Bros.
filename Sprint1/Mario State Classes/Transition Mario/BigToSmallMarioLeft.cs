using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class BigToSmallMarioLeft : DamageTransitionState
    {
        public BigToSmallMarioLeft(IMario mario) : base(mario)
        {
            mario.PowerType = new SmallMarioType();
            CurrentSpriteMap.Add(true, MarioSpriteFactory.Instance.CreateSmallMarioLeftIdleSprite());
            CurrentSpriteMap.Add(false, MarioSpriteFactory.Instance.CreateBigMarioLeftIdleSprite());
            MarioSprite = CurrentSpriteMap[false];
            FinalState = new SmallMarioLeftIdle(mario);
        }  
    }
}