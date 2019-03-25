using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class FireMarioLeftFlagPole : LeftFlagPoleMarioState
    {
        public FireMarioLeftFlagPole(IMario mario) : base(mario)
        {
            MarioSprite = MarioSpriteFactory.Instance.CreateFireMarioLeftFlagpoleSprite();
            NextState = new FireMarioAutoRightRun(mario, 100);
        }

    }
}