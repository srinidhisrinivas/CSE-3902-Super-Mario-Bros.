using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class BigToSmallMarioRight : DamageTransitionState
    {
        public BigToSmallMarioRight(IMario mario) : base(mario)
        {
            mario.PowerType = new SmallMarioType();
            CurrentSpriteMap.Add(true,MarioSpriteFactory.Instance.CreateSmallMarioRightIdleSprite());
            CurrentSpriteMap.Add(false, MarioSpriteFactory.Instance.CreateBigMarioRightIdleSprite());
            MarioSprite = CurrentSpriteMap[false];
            FinalState = new SmallMarioRightIdle(mario);
        }

    }
}