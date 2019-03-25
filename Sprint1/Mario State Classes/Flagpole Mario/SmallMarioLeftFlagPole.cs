using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class SmallMarioLeftFlagPole : LeftFlagPoleMarioState
    {
        public SmallMarioLeftFlagPole(IMario mario) : base(mario)
        {
            MarioSprite = MarioSpriteFactory.Instance.CreateSmallMarioLeftFlagpoleSprite();
            NextState = new SmallMarioAutoRightRun(mario, 100);
        }

    }
}