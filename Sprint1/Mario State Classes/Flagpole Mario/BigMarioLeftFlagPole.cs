using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class BigMarioLeftFlagPole : LeftFlagPoleMarioState
    {
        public BigMarioLeftFlagPole(IMario mario) : base(mario)
        {
            MarioSprite = MarioSpriteFactory.Instance.CreateBigMarioLeftFlagpoleSprite();
            NextState = new BigMarioAutoRightRun(mario, 100);
        }

    }
}