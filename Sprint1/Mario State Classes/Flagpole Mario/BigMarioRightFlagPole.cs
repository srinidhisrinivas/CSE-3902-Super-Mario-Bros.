using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSE3902
{
    class BigMarioRightFlagPole : FlagPoleMarioState
    {

        public BigMarioRightFlagPole(IMario mario) : base(mario)
        {
            MarioSprite = MarioSpriteFactory.Instance.CreateBigMarioRightFlagpoleSprite();
            NextState = new BigMarioLeftFlagPole(mario);
        }


    }
}