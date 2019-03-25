using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class FireToBigMarioRight : DamageTransitionState
    {
        public FireToBigMarioRight(IMario mario) : base(mario)
        {
            mario.PowerType = new BigMarioType();
            CurrentSpriteMap.Add(true, MarioSpriteFactory.Instance.CreateBigMarioRightIdleSprite());
            CurrentSpriteMap.Add(false, MarioSpriteFactory.Instance.CreateFireMarioRightIdleSprite());
            MarioSprite = CurrentSpriteMap[false];
            FinalState = new BigMarioRightIdle(mario);
        }
    }
}
