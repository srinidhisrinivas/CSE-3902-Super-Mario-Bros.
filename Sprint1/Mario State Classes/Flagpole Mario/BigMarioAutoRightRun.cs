using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class BigMarioAutoRightRun : MarioAutoRightRun
    {
        public BigMarioAutoRightRun(IMario mario, int time) : base(mario, time)
        {
            MarioSprite = MarioSpriteFactory.Instance.CreateBigMarioRightRunSprite();
            NextState = new BigMarioLeftIdle(mario);
        }

    }
}